; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Multicalibrador Interface"
#define MyAppVersion "1.0"
#define MyAppPublisher "Solitec Eletr�nica Industrial"
#define MyAppURL "http://www.eletronicaindustrial.com.br"
#define MyAppExeName "Multicalibrador Inteface.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1DA48024-D005-47D4-BA93-537186621CC4}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\Solitec Eletr�nica Industrial\SGS Interface\System\
DisableDirPage=yes
DisableProgramGroupPage=yes
OutputDir=D:\Projetos\Projeto Solitec, Multicalibrador\InnoSetup
OutputBaseFilename=Setup
SetupIconFile=D:\Projetos\Projeto Solitec, Multicalibrador\Visual Studio 12\Multicalibrador Inteface\Multicalibrador Inteface\Solitec.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Projetos\Projeto Solitec, Multicalibrador\Visual Studio 12\Multicalibrador Inteface\Multicalibrador Inteface\bin\Debug\Multicalibrador Inteface.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
