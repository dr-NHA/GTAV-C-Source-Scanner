using NHA_CScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
public partial class Sainan_Scripts : Form{






public Sainan_Scripts(){
InitializeComponent();
bool IsReady=true;
void SetText(string Ext=null) {
if (Ext == null) { Ext = ""; } 
if (Ext != "") 
Ext= " | "+Ext.Trim();
this.Text="Sainan Script Downloader"+ Ext; 
}
SetText("Ready!"); 
            
var FileDIr= "";
DownloadButton.FlatAppearance.BorderColor=Color.Red;

DownloadButton.Click +=async (X, E) => { if (DownloadButton.FlatAppearance.BorderColor == Color.Green && IsReady){
IsReady=false;
DownloadButton.FlatAppearance.BorderColor=Color.Orange;
List<string> SC=new List<string>();
foreach(string Item in DownloadList.CheckedItems)
SC.Add(Item);
var SCRIPTS=SC.ToArray();
SC.Clear();
SC=null;
int DL=0;
DownloadedList.Text = "";
SetText("Download Started!!!");
var L=new List<string>();
var Downloading=0;
var MaxAsyncDownloads=10;
foreach (string FileName in SCRIPTS) {Downloading++;
SetText($"Downloaded: {DL}/{SCRIPTS.Length}");
Downloader. DownloadFileFromAddressEXT(Downloader.DecompiledScriptsDownloader.GetUrlFromFilePath($"decompiled_scripts/{FileName}"), Downloader.ScriptsFolderDirectory(FileDIr+"\\"+ FileName), 
 () => {
L.Add(FileName);
label1.Focus();
DownloadedList.Lines= L.ToArray();    
DownloadedList.SelectionStart=DownloadedList.Text.Length;
DownloadedList.ScrollToCaret();
DL++; Downloading--; });
if (Downloading >= MaxAsyncDownloads+1)
while(Downloading > MaxAsyncDownloads)
await Task.Delay(10);   
await Task.Delay(10);   
}

for(; ; ) { 
SetText($"Downloaded: {DL}/{SCRIPTS.Length}");
if (DL == SCRIPTS.Length) { break; }
await Task.Delay(100);
}
SetText("Ready!");
IsReady = true;
DownloadButton.FlatAppearance.BorderColor=Color.Green;

}};


LatestDownload.Click += (X, E) => {if (IsReady){
IsReady =false;
DownloadButton.FlatAppearance.BorderColor=Color.Red;
SetText("Downloading: README!");
Downloader.DecompiledScriptsDownloader.DownloadStringGithubUserContent("README.md", (DATA)=> {

var R = DATA.Replace("#", "").Replace("Current Version:", "#").Split('#')[1].Split('\n')[0].Trim();
BuildName.Text = R.Split(' ').Last().Trim();
GameVersion.Text = R.Split('V')[1].Split(' ')[0].Trim();
FileDIr= $"Version {GameVersion.Text} Build {BuildName.Text}";
Downloader.SetupScriptsFolder(FileDIr);
    
SetText("Downloading: all_script_names!");
Downloader.DecompiledScriptsDownloader.DownloadStringGithubUserContent("all_script_names.txt", (AllScriptNames)=> {
/*var F= ScriptsFolderDirectory(FileDIr + "\\all_script_names.txt");if(File.Exists(F)){File.Delete(F);File.WriteAllText(F, AllScriptNames);}*/
DownloadList.Items.Clear();
foreach (string FileName in AllScriptNames.Split('\n'))
if(FileName!=""){DownloadList.Items.Add(FileName+".c",true);}

DownloadButton.FlatAppearance.BorderColor=Color.Green;
SetText("Ready!");
IsReady = true;
});

});
}};
}


    }
}
