
//included libraries
	#include "Thread.h"
	#include "ThreadController.h"

//settings
	#define serialrate			115200
	#define serialmessagesize	200

	#define analogpot			A0
	#define analogfeed			A1
	#define analogVin			A2
	#define analogIin			A3
	#define analogTJin			A4

	#define analogout			9
 
//threads controllers
	ThreadController controller = ThreadController();
	Thread controllercommunication = Thread();

	ThreadController communicationusb = ThreadController();
	Thread communicationusbread = Thread();

//system
	String serialmessageusb;
	int transfermode = 0;

void setup (void) {

	Serial.begin(serialrate);
	serialmessageusb.reserve(serialmessagesize);

	pinMode(analogpot,	INPUT);
	pinMode(analogfeed, INPUT);
	pinMode(analogVin,	INPUT);
	pinMode(analogIin,	INPUT);
	pinMode(analogTJin,	INPUT);

	pinMode(analogout, OUTPUT);
	
	controller.add(&controllercommunication);
	controllercommunication.onRun(communication);
	controllercommunication.setInterval(200);

	communicationusb.add(&communicationusbread);
	communicationusbread.onRun(usbread);
	communicationusbread.setInterval(0);

}

void loop (void) {
	/*
	analogWrite(analogout, map(analogRead(analogpot), 0, 1023, 0, 255));

	Serial.print(F("PWM: ")); Serial.print(map(analogRead(analogpot), 0, 1023, 0, 255));
	Serial.print(F("	Vout: ")); Serial.print((float)(map(analogRead(analogpot), 0, 1023, 0, 1000))/100, 2);
	Serial.print(F("V	Iout: ")); Serial.print((float)(map(analogRead(analogpot), 0, 1023, 0, 2000))/100, 2);
	Serial.print(F("mA	Jout: ")); Serial.print((float)(map(analogRead(analogpot), 0, 1023, 4500, 105000))/100, 2);
	Serial.println(F("C"));

	Serial.print(F("PWM: ")); Serial.print(map(analogRead(analogfeed), 0, 1023, 0, 255));
	Serial.print(F("	Vinp: ")); Serial.print((float)(map(analogRead(analogVin), 0, 1023, 0, 1000))/100, 2);
	Serial.print(F("V	Iinp: ")); Serial.print((float)(map(analogRead(analogIin), 0, 1023, 0, 2000))/100, 2);
	Serial.print(F("mA	Jout: ")); Serial.print((float)(map(analogRead(analogTJin), 0, 1023, 4500, 105000))/100, 2);
	Serial.println(F("C"));
	
	Serial.println("");
	*/

	if (transfermode < 1) {
		analogWrite(analogout, map(analogRead(analogpot), 0, 1023, 0, 255));
		controller.run();
	}
	else {
		communicationusb.run();
	}

}

//communication
void communication(void) {

	if (Serial.available() > 0) {
		serialmessageusb = Serial.readStringUntil('\n');
		Serial.flush();
		if (serialmessageusb.equals(F("WC00001"))) {
			transfermode = 1;
			Serial.print(F("@RC00001                                                              %092#"));
			Serial.print('\n');
		}
	}

}

//usb read
void usbread(void) {

//sttings
	#define usbreadbuffer 75
	#define usbreadmod 99
	#define usbreadprefix "@"
	#define usbreadlimiter "#"
	#define usbreadtab "%"

//function
	if (Serial.available() > 0) {
		serialmessageusb = Serial.readStringUntil('\n');
		Serial.flush();

		if (serialmessageusb.substring(0, 1) == usbreadprefix && serialmessageusb.substring(usbreadbuffer - 1) == usbreadlimiter) {

			String serialdata = serialmessageusb.substring(1, serialmessageusb.indexOf(usbreadtab));
			String serialchecksum = serialmessageusb.substring(serialmessageusb.indexOf(usbreadtab) + 1, usbreadbuffer - 1);

			char dataarray[serialdata.length() + 1];

			serialdata.toCharArray(dataarray, serialdata.length() + 1);

			long datacalculations = 0;
			long datachecksum = 0;

			for (int i = 0; i < serialdata.length(); i++) {
				datacalculations = dataarray[i] * (i + 1);
				datachecksum += datacalculations;
			}
		
			datachecksum = datachecksum % usbreadmod;

			if (datachecksum == serialchecksum.toInt()) {
				usbdecoder(serialdata);
			}
			else {
				//checksum ERROR
				//usbwrite("ER0000000000");
			}

			serialmessageusb = "";
		}
	}
}

//usb decoder
void usbdecoder(String decoder) {

//sttings
	#define headersize 2
	#define controlsize 3
	#define datasize 64

//function
	String header = decoder.substring(0, headersize);
	String control = decoder.substring(headersize, headersize + controlsize);
	String data = decoder.substring(headersize + controlsize, headersize + controlsize + datasize);

	String controllerstring;
	String datawrite;
	String dataequalizer;

	if (header.substring(0, 1).equals("W")) {

		//Communication
		if (header.equals("WC")) {
			if (control.equals("000")) {
				transfermode = data.toInt();
			}
		}

		//Output
		if (header.equals("WV")) {
			if (control.equals("000")) {
				analogWrite(analogout, data.toInt());
			}
		}
	}


	if (header.substring(0, 1).equals("W") || header.substring(0, 1).equals("R")) {

		//Communication
		if (header.substring(1, 2).equals("C")) {

			if (control.equals("000")) {
				datawrite = String(transfermode);
				for (int k = 0; k < 2 - datawrite.length(); k++) {
					dataequalizer += "0";
				}
				controllerstring += dataequalizer;
				controllerstring += datawrite;
				dataequalizer = "";
			}

		}

		//Input's
		if (header.substring(1, 2).equals("V")) {

			if (control.equals("000")) {
				datawrite = analogRead(analogfeed);
				for (int k = 0; k < 4 - datawrite.length(); k++) {
					dataequalizer += "0";
				}
				controllerstring += dataequalizer;
				controllerstring += datawrite;
				dataequalizer = "";

				datawrite = analogRead(analogVin);
				for (int k = 0; k < 4 - datawrite.length(); k++) {
					dataequalizer += "0";
				}
				controllerstring += dataequalizer;
				controllerstring += datawrite;
				dataequalizer = "";

				datawrite = analogRead(analogIin);
				for (int k = 0; k < 4 - datawrite.length(); k++) {
					dataequalizer += "0";
				}
				controllerstring += dataequalizer;
				controllerstring += datawrite;
				dataequalizer = "";

				datawrite = analogRead(analogTJin);
				for (int k = 0; k < 4 - datawrite.length(); k++) {
					dataequalizer += "0";
				}
				controllerstring += dataequalizer;
				controllerstring += datawrite;
				dataequalizer = "";
			}

		}

		int bufferequalizer = datasize - controllerstring.length();

		for (int i = 0; i < bufferequalizer; i++) {
			controllerstring += " ";
		}

		usbwrite("R" + header.substring(1, 2) + control + controllerstring);
	
	}

}

//usb write
void usbwrite(String serialdata) {

	//sttings
	#define usbwritebuffer 75
	#define usbwritemod 99
	#define usbwriteprefix "@"
	#define usbwritelimiter "#"
	#define usbwritetab "%"

//function
	char dataarray[serialdata.length() + 1];

	serialdata.toCharArray(dataarray, serialdata.length() + 1);

	long datacalculations = 0;
	long datachecksum = 0;
	
	for (int i = 0; i < serialdata.length(); i++) {
		datacalculations = dataarray[i] * (i + 1);
		datachecksum = datachecksum + datacalculations;
	}

	datachecksum = datachecksum % usbwritemod;

	String checksumsize = String(datachecksum);
	int dataequalizer = usbwritebuffer - 3 - serialdata.length() - checksumsize.length();
	String checksum;

	for (int i = 0; i < dataequalizer; i++) {
		checksum = checksum + "0";
	}

	checksum = checksum + checksumsize;

	Serial.print(usbwriteprefix + serialdata + usbwritetab + checksum + usbwritelimiter);
	Serial.print('\n');
	Serial.flush();

}