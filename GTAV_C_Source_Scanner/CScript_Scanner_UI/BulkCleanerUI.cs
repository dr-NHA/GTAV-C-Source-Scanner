using NHA_CScript;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
public partial class BulkCleanerUI : Form{

public static async Task PlayCompleted(){
SystemSounds.Asterisk.Play();
await Task.Delay(335);
SystemSounds.Asterisk.Play();
await Task.Delay(235);
SystemSounds.Asterisk.Play();
}
        
/// <summary>
/// The Scanner For The C Scripts
/// </summary>
public CScriptScanner CScriptScanner;

public void SetTitle(string Data="") {  
this.Text= "NHA's (C Source) - (BULK) " +$"Cleaner V{CScriptCleaner.VersionInfo} "+Data;
}
        

public BulkCleanerUI(){
InitializeComponent();

var LastPath="";
SetTitle(" Status: Ready");
CScriptScanner = new CScriptScanner((Name) => {}, () => {});
            
OpenWithNotePad.Click += (X, E) => StartNew.OpenAllCompatibleScriptsWithNotepadPlusPlus();


bool CleaningOrScanning=false;
ClearScriptsToClean.Click += (X, E) => ScriptsToClean.Items.Clear();
            
ScriptDialog.FileOk += (X, E) =>{
LastPath = ScriptDialog.FileNames[0].Replace( ScriptDialog.FileNames[0].Replace('/', '\\').Split('\\').Last(),"").Trim('\\');

var Mt = LastPath.Split('\\').Last();
if (Mt.Contains("Version") && Mt.Contains("Build")){
var VER= Mt.Replace("Version","@").Split('@').Last().Replace("Build", "@").Split('@');
Utilities.GameVersion= VER[0].Trim();
Utilities.GameBuild= VER[1].Trim();
}
LastPath+="\\";
//MessageBox.Show(LastPath, ScriptDialog.FileNames[0].Replace('/', '\\').Split('\\').Last());
foreach (string Name in ScriptDialog.FileNames) {
if (StartNew.FailSafeTriggered) { break; }
if (Name.StartsWith(LastPath)) { 
ScriptsToClean.Items.Add(Name.Replace(LastPath,""));
}
}
};
FindCFiles.Click += (X, E) => ScriptDialog.ShowDialog();


DoCleanButton.Click += async (X, E) => {if(CleaningOrScanning==false){
CleaningOrScanning = true;
int IND=0;
string S='"'.ToString();
StatusX.Items.Clear();
int Scanned=0;int ScannedNeeded = 5;
foreach(string XItem in ScriptsToClean.Items) { IND++;
if (StartNew.FailSafeTriggered) { break; }
var Item= LastPath+"\\" +XItem;
var FileName= Item.Replace("/", "\\").Split('\\').Last();
SetTitle(" Cleaning Status: " + IND+"/"+ ScriptsToClean.Items.Count + " / " + FileName);
StartNew.DoCleanOnFile(FileName, Item, B => StatusX.Items.Add(B),()=> { });
if(Scanned>=ScannedNeeded){
Scanned = 0;
await Task.Delay(5);
}else
Scanned++;

}
await PlayCompleted();
SetTitle(" Status: Ready");
CleaningOrScanning=false;}};



FixNativesButton.Click += async (X, E) => {if(CleaningOrScanning==false){
CleaningOrScanning = true;
int IND=0;
string S='"'.ToString();
StatusX.Items.Clear();
int CCCC=0;var COUNT = ScriptsToClean.Items.Count;
int Scanned=0;int ScannedNeeded =30;
foreach(string XItem in ScriptsToClean.Items) { IND++;
if (StartNew.FailSafeTriggered) { break; }
var Item= LastPath+"\\" +XItem;
var FileName= Item.Replace("/", "\\").Split('\\').Last();
SetTitle(" Fixng Natives Status: " + IND+"/"+ COUNT + " / " + FileName);
Scanned++;
StartNew.DoNativeFixOnFile(FileName, Item, B => StatusX.Items.Add(B),()=> { Scanned--; CCCC++; });
if(Scanned>=ScannedNeeded){
await Task.Delay(55);
while (Scanned > ScannedNeeded - 3) { 
await Task.Delay(55);
}
}
await Task.Delay(55);
}

SetTitle(" Fixng Natives Status: "+CCCC+"/"+ COUNT + "!");
while (Scanned >= 1) 
await Task.Delay(35);
await PlayCompleted();
SetTitle(" Status: Ready");
CleaningOrScanning=false;}};







DoScanAll.Click +=async (X, E) => {if(CleaningOrScanning==false){
CleaningOrScanning = true;
int IND=0;
int IX=0;
string S='"'.ToString();
StatusX.Items.Clear();
Utilities.ClearLoadedOffsets();
foreach(string XItem in ScriptsToClean.Items) { IND++;
if (StartNew.FailSafeTriggered) { break; }
var Item= LastPath+"\\" +XItem;
var FileName= Item.Replace("/", "\\").Split('\\').Last();
SetTitle(" Scanning Status: "+IND+"/"+ ScriptsToClean.Items.Count + " / " + FileName);
StartNew.DoScanOnFile(Item,B=> StatusX.Items.Add(B),(Script) =>{ OnOffsetScanCompleted(FileName, Script);
IX++;
});
//await Task.Delay(1);
}

for(; ; ) {
if (StartNew.FailSafeTriggered|| IX >= ScriptsToClean.Items.Count) { break; }
SetTitle(" Scanning Status: "+ " |  Waiting For Scans: "+ IX + "/"+ ScriptsToClean.Items.Count);
await Task.Delay(10); }
Utilities.SaveAllOffsets();
await PlayCompleted();
SetTitle(" Status: Ready");
CleaningOrScanning=false;}};






CleanAndScan.Click +=async (X, E) => { 
if(CleaningOrScanning==false){
CleaningOrScanning = true;
int IND=0;int Finish = 0;
StatusX.Items.Clear();
Utilities.ClearLoadedOffsets();
int Scanned=0;int ScannedNeeded = 5;
foreach(string XItem in ScriptsToClean.Items) { IND++;var ID = IND;
if (StartNew.FailSafeTriggered) { break; }
var Item= LastPath+"\\" +XItem;
var FileName= Item.Replace("/", "\\").Split('\\').Last();
SetTitle(" Cleaning Status: "+IND+"/"+ ScriptsToClean.Items.Count+" | Scanning Status: "+ID+"/"+ ScriptsToClean.Items.Count + " /"+ FileName);
    
StartNew.DoCleanOnFile(FileName, Item, async B => StatusX.Items.Add(B), async () =>{
if(CScriptScanner.AllowedScripts.Contains(FileName)){
StartNew.DoScanOnFile(Item,async B=> StatusX.Items.Add(B),async (Script) => { 
OnOffsetScanCompleted(FileName, Script);
Finish++;
});}else;
Finish++;
});

if(Scanned>=ScannedNeeded){
Scanned = 0;
await Task.Delay(5);
}else
Scanned++;
}
for(; ; ) {
if (StartNew.FailSafeTriggered|| Finish>= ScriptsToClean.Items.Count) { break; }
SetTitle(" Cleaning Status: "+IND+" / "+ ScriptsToClean.Items.Count+ " |  Waiting For Scans: "+ Finish+"/"+ ScriptsToClean.Items.Count);
await Task.Delay(10); }
Utilities.SaveAllOffsets();
await PlayCompleted();
SetTitle(" Status: Ready");
CleaningOrScanning=false;}
};






DoHashScan.Click +=async (X, E) => { 
if(CleaningOrScanning==false){
CleaningOrScanning = true;
        
int IND=0;
Utilities.ResetHashes();
StatusX.Items.Clear();
var D1 = 0;
var XA= ScriptsToClean.Items.Count;
void RefreshTitle(string ExtraData="") { 
SetTitle(" Hash Scanning Status: "+IND+"/"+ ScriptsToClean.Items.Count+ " | Hashes: "+ Utilities.FoundHashCount()+ " | " + ExtraData);
}
bool Finished=false;
var LAST= (string)ScriptsToClean.Items[ScriptsToClean.Items.Count-1];
var Scanning=0;
foreach (string XItem in ScriptsToClean.Items) { IND++; Scanning++;
 if (StartNew.FailSafeTriggered) { break; }
var Item= LastPath+"\\" +XItem;
RefreshTitle(Item.Replace("/", "\\").Split('\\').Last());
StartNew.DoHashScanOnFile(Item, B => StatusX.Items.Add(B), () => { 
Scanning--;
if(XItem == LAST) { 
Finished=true;    
}
});

if(D1<=0){
D1 = 3;
if(Scanning>25){
for(; ; ){
if(Scanning<25){
break;
}await Task.Delay(20);}}
await Task.Delay(10);
}else
D1--;
}
for(; ; ) { 
if (StartNew.FailSafeTriggered) { break; }
RefreshTitle("Waiting For Scan To Finish!!!");
if(Finished) { break; }
await Task.Delay(10);        
}
await Task.Delay(TimeSpan.FromSeconds(3));        
Utilities.SaveHashes();
await PlayCompleted();
SetTitle(" Status: Ready");
CleaningOrScanning = false;
}            
};


}

public void OnOffsetScanCompleted(string FileName,string Script){
if(Script!=""){
Utilities.WriteOffsetFile(FileName, Script);
var OffsetX= Utilities.OffsetFile(FileName.Replace(".c",""));
var Offsets= OffsetX .Split('\\').Last().Replace(Utilities.OffsetFileSuffix," Offsets")+ ":\n";
foreach(string Offset in Script.Split('\n')){if(Offset.Contains(':')){Offsets+=Offset+"\n";}}
Utilities.AddOffset(Offsets.Trim('\n')+"\n\n"+Utilities.OffsetSplitLog);
}
}




private void StatusX_DoubleClick(object sender, EventArgs e){
var X="";
foreach(string Item in StatusX.Items) { X += Item + "\n"; }
Clipboard.SetText(X);
}


    }
}
