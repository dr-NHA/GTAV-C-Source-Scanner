using NHA_CScript;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
public partial class ScannerUI : Form {
        
public static ScannerUI STATIC;
   
private Form SetupForm(Form BCUI){
BCUI.WindowState= FormWindowState.Minimized;
BCUI.ShowInTaskbar=false;
//BCUI.FormClosing+=(X,E)=>{ BCUI.WindowState = FormWindowState.Minimized;BCUI.Hide();E.Cancel = true;};
return BCUI;
}

public void CreateOpenButton(Button OpenButton,Form OpenForm)=>
OpenButton.Click+=(X,E)=> DynamicUI.Instances[Name].SwitchToUI(OpenForm);

public ScannerUI() {
InitializeComponent();
SetupUtilities();
STATIC = this;
ClearResults();

NHA_INFO.Text=
"Made By: dr NHA!\n\n" +
"Useful For:\n" +
"Scanning For Globals And Hashes!\n" +
"Cleaning Decompiled Scripts!\n" +
"Fixing Missing Natives In Decompiled Scripts!";
NHA_INFO.ReadOnly=true;

NGT.Click += (X, E) =>
GlobalOffsetTester.StartNew.OpenOffsetTester((
Downloader.NHAGtaDownloader.Name,
Downloader.NHAGtaDownloader.Repo,
Downloader.NHAGtaDownloader.Branch));


CreateOpenButton(BulkCleanerButton, SetupForm(new BulkCleanerUI()));
CreateOpenButton(GTA_DECOMP_SCRIPTS, SetupForm(new Sainan_Scripts()));
CreateOpenButton(OpenUploader, SetupForm(new Uploader()));
}

        
public void ClearResults() { 
STATIC.Text= "NHA's (C Source) - \n" +
$"Cleaner V{CScriptCleaner.VersionInfo}" +
" & " +
$"Function Scanner V{CScriptScanner.VersionInfo}";
ResultsLines.Text = STATIC.Text + "\n" +
"Rebuilt For Speed And Stability!\n\n";
}
public void AddResult(string S)=>ResultsLines.Text = ResultsLines.Text+ S + "\n";







public void SetupUtilities(){
Utilities.GetOffsets=()=>Offsets.Text;
Utilities.AddOffset=(Name) =>Offsets.Text+= Name + "\n";
Utilities.ClearLoadedOffsets=()=>Offsets.Text="";
List<string> HashNames=new List<string>();

Utilities.SetupResultsDirectory();
if (File.Exists(Utilities.ResultsFile("All_Game.Hashes"))) {
HashList.Text=File.ReadAllText(Utilities.ResultsFile("All_Game.Hashes"));
}
//Clear Offsets
Offsets.Text="";
//Setup Offsets
foreach(string Dir in Directory.GetFiles(Utilities.ResultsDirectory)){
if (Dir.EndsWith(Utilities.OffsetFileSuffix)) { 
//MessageBox.Show(Dir);
Offsets.Text+=$"{Dir.Split('\\').Last().Replace(Utilities.OffsetFileSuffix, " Offsets")}:\n"+File.ReadAllText(Dir).Trim('\n')+"\n\n"+Utilities.OffsetSplitLog+"\n";              
}
}
Offsets.Text= Offsets.Text.Trim('\n');

Utilities.SaveHashes=()=>{
if (File.Exists(Utilities.ResultsFile("All_Game.Hashes"))) {
HashList.Text= File.ReadAllText(Utilities.ResultsFile("All_Game.Hashes"));
}};
Utilities.ResetHashes=()=>{
if (File.Exists(Utilities.ResultsFile("All_Game.Hashes"))) {
File.Delete(Utilities.ResultsFile("All_Game.Hashes"));
}
HashList.Text="";
HashNames.Clear();
};
Utilities.FoundHashCount=()=>HashNames.Count;

Utilities.AddHash=async (HashName, HashValue)=>{
if(HashNames.Contains(HashName)==false){
HashNames.Add(HashName);
Utilities.SetupResultsDirectory();
File.AppendAllText(Utilities.ResultsFile("All_Game.Hashes"), HashName + ": " + HashValue + "\n");

}};

}

    }
}
