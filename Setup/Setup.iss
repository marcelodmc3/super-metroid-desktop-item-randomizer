#define AppVersion "0.9"
#define AppName "SMDIRandomizer"
#define AppFullName "Super Metroid Desktop Item Randomizer"
#define AppGUID "{3d79d822-207f-48a1-aad4-27dc4396d52c}"
#define AppYear "2019"
#define AppExe "SMDIRandomizer.exe"
#define AppWebsite "https://github.com/marcelodmc3/super-metroid-desktop-item-randomizer"
#define AppHelpsite "https://github.com/marcelodmc3/super-metroid-desktop-item-randomizer/issues"
#define InstallID "{e8c433d9-4f2b-4d45-912e-9d4a8411f853}"
#define AppCompany "SMDIRandomizer"
#define AppCompanyFull "SMDIRandomizer"
#define AppDescription AppFullName + " installer version " + AppVersion

[CustomMessages]


[Setup]
AllowNoIcons=true
AppID={{#InstallID}
AppName={#AppName}
AppPublisher={#AppCompanyFull}
AppPublisherURL={#AppWebsite}
AppSupportURL={#AppHelpsite}
AppVerName={#AppFullName} {#AppVersion}
AppVersion={#AppVersion}
ChangesAssociations=true
CloseApplications=false
Compression=lzma2/ultra64
DefaultDirName={pf}\{#AppCompany}\{#AppName}
DefaultGroupName={#AppCompany}
DisableDirPage=false
DisableReadyPage=true
InternalCompressLevel=max
MinVersion=0,6.1.7601
OutputBaseFilename={#AppName}_{#AppVersion}_Setup
SetupIconFile=setup.ico
SetupLogging=true
ShowLanguageDialog=auto
SolidCompression=true
TimeStampsInUTC=true
UninstallDisplayIcon={app}\{#AppExe}
UninstallDisplayName={#AppFullName}
VersionInfoCompany={#AppCompanyFull}
VersionInfoCopyright={#AppCompanyFull} {#AppYear}
VersionInfoDescription={#AppDescription}
VersionInfoProductName={#AppName}
VersionInfoProductVersion={#AppVersion}
VersionInfoTextVersion={#AppVersion}
VersionInfoVersion={#AppVersion}
WizardImageFile=WizModernImage.bmp
WizardSmallImageFile=WizModernSmallImage.bmp
DisableProgramGroupPage=true

[CustomMessages]
AppDescription={#AppFullName} generates item randomized Super Metroid ROMs for SNES Emulators.
Ngen=Optimizing the performance of {#AppName} for your system.
InstallRun=Run the {#AppFullName}

[Files]
; Arquivos comuns
Source: smdirm.ico; DestDir: {app}
Source: website.url; DestDir: {app}

; Arquivos específicos do projeto
Source: bin\*.dll; DestDir: {app}; Flags: restartreplace ignoreversion;
Source: bin\*.exe; Excludes: *vshost.exe; DestDir: {app}; Flags: restartreplace ignoreversion

[Icons]
Name: {group}\{#AppFullName}; Filename: {app}\{#AppExe}; IconFilename: {app}\{#AppExe}; Comment: {cm:AppDescription}
Name: {group}\{#AppCompanyFull}; Filename: {app}\website.URL; IconFilename: {app}\smdirm.ico
Name: {commondesktop}\{#AppFullName}; Filename: {app}\{#AppExe}; IconFilename: {app}\{#AppExe}; Comment: {cm:AppDescription}

[Run]
; Otimizando a instalação
Filename: {code:Ngen64Cmd}; Parameters: "install ""{app}\{#AppExe}"""; StatusMsg: {cm:Ngen}; Check: CheckNgen64; Flags: runhidden
Filename: {code:Ngen64Cmd}; Parameters: "install ""{pf}\{#AppCompany}\LogReport.exe"""; StatusMsg: {cm:Ngen}; Check: CheckNgen64; Flags: runhidden

; Opção de executar após instalar
Filename: {app}\{#AppExe}; WorkingDir: {app}; Description: {cm:InstallRun}; Flags: nowait postinstall runasoriginaluser

[UninstallRun]
Filename: {code:Ngen64Cmd}; Parameters: "uninstall ""{app}\{#AppExe}"""; Check: CheckNgen64; Flags: runhidden

[Registry]

; Registros globais de usuário
Root: HKLM; Subkey: Software\{#AppCompany}; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: Software\{#AppCompany}\{#AppName}; Flags: uninsdeletekeyifempty; Permissions: users-modify
Root: HKLM; Subkey: Software\Microsoft\Windows\CurrentVersion\SharedDLLs; ValueType: dword; ValueName: {pf}\{#AppCompany}\LogReport.exe; ValueData: $FFFF; Flags: deletevalue dontcreatekey
Root: HKLM; Subkey: Software\Microsoft\Windows\CurrentVersion\Uninstall\{{#InstallID}_is1; ValueType: string; ValueName: ProductVersion; ValueData: {#AppVersion}

[Code]
const
	netfx_reg = 'Software\Microsoft\NET Framework Setup\NDP\v4\Full';
	netfx_reg32 = 'Software\Wow6432Node\Microsoft\NET Framework Setup\NDP\v4\Full';
	runoncename = '{#AppName}_setup';
var
	netfx_ngen64: string;
	netfx_ngen32: string;
	netfx_regasm: string;
	CancelWithoutPrompt: boolean;
	Restarted: Boolean;
	NeedRestartFlag: Boolean;

function Quote(const S: String): String;
begin
  Result := '"' + S + '"';
end;

function AddParam(const S, P, V: String): String;
begin
  if V <> '""' then
    Result := S + ' /' + P + '=' + V;
end;

function AddSimpleParam(const S, P: String): String;
begin
 Result := S + ' /' + P;
end;

procedure CreateRunOnceEntry;
var
	cmd: String;
begin
	cmd := Quote(ExpandConstant('{srcexe}')) + ' /restart=1';
	cmd := AddParam(cmd, 'LANG', ExpandConstant('{language}'));
	cmd := AddParam(cmd, 'DIR', Quote(WizardDirValue));
	cmd := AddParam(cmd, 'GROUP', Quote(WizardGroupValue));
	if WizardNoIcons then
		cmd := AddSimpleParam(cmd, 'NOICONS');
	cmd := AddParam(cmd, 'TYPE', Quote(WizardSetupType(False)));
	cmd := AddParam(cmd, 'COMPONENTS', Quote(WizardSelectedComponents(False)));
	cmd := AddParam(cmd, 'TASKS', Quote(WizardSelectedTasks(False)));
	RegWriteStringValue(HKLM, 'Software\Microsoft\Windows\CurrentVersion\RunOnce', runoncename, cmd);
end;

function CheckNgen64(): boolean;
var
	installpath: string;
begin
	if (netfx_ngen64 = '') then
	begin
		RegQueryStringValue(HKLM, netfx_reg, 'InstallPath', installpath);
		netfx_ngen64 := installpath + 'ngen.exe';
		if (not FileExists(netfx_ngen64)) then
		begin
			netfx_ngen64 := '';
		end;
	end;
	Result := (netfx_ngen64 <> '');
end;

function CheckNgen32(): boolean;
var
	installpath: string;
begin
	if (netfx_ngen32 = '') then
	begin
		if IsWin64 then
		begin
			RegQueryStringValue(HKLM,netfx_reg32, 'InstallPath', installpath);
		end
		else
		begin
			RegQueryStringValue(HKLM, netfx_reg, 'InstallPath', installpath);
		end;
		netfx_ngen32 := installpath + 'ngen.exe';
		if (not FileExists(netfx_ngen32)) then
		begin
			netfx_ngen32 := '';
		end;
	end;
	Result := (netfx_ngen32 <> '');
end;

function CheckRegAsm(): boolean;
var
	installpath: string;
begin
	if (netfx_regasm = '') then
	begin
		RegQueryStringValue(HKLM, netfx_reg, 'InstallPath', installpath);
		netfx_regasm := installpath + 'RegAsm.exe';
		if (not FileExists(netfx_regasm)) then
		begin
			netfx_regasm := '';
		end;
	end;
	Result := (netfx_regasm <> '');
end;

function Ngen64Cmd(Param: String): string;
begin
	Result := netfx_ngen64;
end;

function Ngen32Cmd(Param: String): string;
begin
	Result := netfx_ngen32;
end;

function RegAsmCmd(Param: String): string;
begin
	Result := netfx_regasm;
end;

function IsWin32(): boolean;
begin
	Result := not IsWin64;
end;

procedure CancelButtonClick(CurPageID: Integer; var Cancel, Confirm: Boolean);
begin
  if (CurPageID = wpInstalling) then
    Confirm := not CancelWithoutPrompt;
end;

function PrepareToInstall(var NeedsRestart: Boolean): String;
var
	res : Integer;
begin
	Exec(ExpandConstant('{sys}') + '\net.exe', 'stop TbitLogReport', '', SW_HIDE, ewWaitUntilTerminated, res);
	Result := '';
end;

function InitializeSetup: Boolean;
var
	winversion : cardinal;
begin
	CancelWithoutPrompt := False;
	NeedRestartFlag := False;
	winversion := GetWindowsVersion;
	
	if (RegKeyExists(HKEY_LOCAL_MACHINE, 'Software\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update\RebootRequired')) then
	begin
		MsgBox(ExpandConstant('{cm:WindowsUpdate}'), mbError, MB_OK);
		Result := False;
	end
	else
	begin
		if (ExpandConstant('{param:restart|0}') = '0') then
		begin
			if (RegValueExists(HKLM, 'Software\Microsoft\Windows\CurrentVersion\RunOnce', runoncename)) then
			begin
				RegDeleteValue(HKLM, 'Software\Microsoft\Windows\CurrentVersion\RunOnce', runoncename);
			end;
			Restarted := False;
			Result := True;
		end
		else
		begin
			Restarted := True;
			Result := True;
		end;
	end;
end;

function ShouldSkipPage(PageID: Integer): Boolean;
begin
	Result := Restarted;
end;

function NeedRestart(): Boolean;
begin
	Result := NeedRestartFlag;
end;
