using NHA_CScript.OffsetDefs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NHA_CScript{
public static class StartNew{

/// <summary>
/// NHA CScript Process File Name
/// </summary>
public static string StartFileName { get; } = "NHA_CScript.exe";

/// <summary>
/// Start A NHA_CScript Process!
/// </summary>
/// <param name="StartArguments"></param>
/// <returns></returns>
public static Process StartProcess(string StartArguments){
var P = new Process(){ StartInfo=new ProcessStartInfo(StartFileName) { 
UseShellExecute=false,
RedirectStandardOutput=true,
Arguments= StartArguments,
CreateNoWindow=true,
WindowStyle=ProcessWindowStyle.Hidden,
}};
P.Start();
return P;
}

/// <summary>
/// Customised Start Process Read The Output Till The Process Ends
/// </summary>
/// <param name="StartArguments"></param>
/// <param name="OnProcessStarted"></param>
/// <param name="OnProcessExited"></param>
/// <returns></returns>
public static async Task<(Process StartedProcess, string Output)> 
StartProcessReadOutputTillEnd(string StartArguments,Action<Process> OnProcessStarted=null,Action<(Process StartedProcess, string Output)> OnProcessExited=null) {
var P=StartProcess(StartArguments);
OnProcessStarted?.Invoke(P);
var DB= (P, await P.StandardOutput.ReadToEndAsync());
OnProcessExited?.Invoke(DB);
return DB;
}

/// <summary>
/// Open All The Currently Compatible Scripts With Notepad++
/// </summary>
/// <returns></returns>
public static async Task OpenAllCompatibleScriptsWithNotepadPlusPlus() {
ALL.FillDCScripts();
var X2 = "";
var BASE = "\"" + Environment.CurrentDirectory + "\\" + Downloader.GetScriptsFolder() + "\\Version " + Utilities.GameVersion + " Build " + Utilities.GameBuild;
List<string> FileNames = new List<string>();
foreach (var XItem in ALL.CScripts.Values)
if (!FileNames.Contains(XItem.FileName)){
FileNames.Add(XItem.FileName);
X2 += BASE + "\\" + XItem.FileName + "\" ";
}
Process.Start(@"C:\Program Files\Notepad++\" + "notepad++.exe", X2.Trim(' '));
}


/// <summary>
/// Check If We Have Initiated Failsafe!
/// </summary>
public static bool FailSafeTriggered { get; private set; } =false;

/// <summary>
/// Initate Failsafe To Force Stop Workers!
/// </summary>
public static void InitiateFailsafe(){
FailSafeTriggered = true;
var P = StartProcess($"FailSafe");
P.WaitForExit();
}

/// <summary>
/// Clean A File!
/// </summary>
/// <param name="FileName"></param>
/// <param name="FileDir"></param>
/// <param name="StatusChanged"></param>
/// <param name="OnCompleted"></param>
/// <returns></returns>
public static async Task DoCleanOnFile(string FileName,string FileDir,Action<string> StatusChanged,Action OnCompleted) { 
var P = StartProcess($"CleanFile \"{FileName}\" \"{FileDir}\"");
var Output = await P.StandardOutput.ReadToEndAsync();
if (Output.Contains("\n")) {
foreach(string SX in Output.Split('\n'))
if(SX.Trim()!="")
StatusChanged.Invoke(SX);
}else if(Output.Trim()!="")
StatusChanged.Invoke(Output);
OnCompleted.Invoke();
}


/// <summary>
/// Fix Missing Natives In A File And Log Any Unknown If Not Already Logged
/// </summary>
/// <param name="FileName"></param>
/// <param name="FileDir"></param>
/// <param name="StatusChanged"></param>
/// <param name="OnCompleted"></param>
/// <returns></returns>
public static async Task DoNativeFixOnFile(string FileName,string FileDir,Action<string> StatusChanged,Action OnCompleted) { 
var P = StartProcess($"FixNatives \"{FileName}\" \"{FileDir}\"");
var Output = await P.StandardOutput.ReadToEndAsync();
if (Output.Contains("\n")) {
foreach(string SX in Output.Split('\n'))
if(SX.Trim()!="")
StatusChanged.Invoke(SX);
}else if(Output.Trim()!="")
StatusChanged.Invoke(Output);
OnCompleted.Invoke();
}


/// <summary>
/// Scan For Globals And Locals Ect With The Custom Offset Defs!
/// </summary>
/// <param name="FileDir"></param>
/// <param name="StatusChanged"></param>
/// <param name="OnCompleted"></param>
/// <returns></returns>
public static async Task DoScanOnFile(string FileDir,Action<string> StatusChanged,Action<string> OnCompleted){
if(CScriptScanner. AllowedScripts.Contains(FileDir.Replace("/", "\\").Split('\\').Last())){
var P = StartProcess($"ScanFile \"{FileDir}\"");
var Script="";
var Output = await P.StandardOutput.ReadToEndAsync();
if (Output.Contains("\n")) {
foreach(string SX in Output.Split('\n')){
if(SX.Trim()!=""){
if(SX.StartsWith("$@#%")){
StatusChanged.Invoke(SX.TrimStart('$').TrimStart('@').TrimStart('#').TrimStart('%'));
}else{
if(SX.StartsWith("~#")){
var SA= SX.TrimStart('~').TrimStart('#').Split(':');
Utilities.AddHash(SA[0], SA[1].Trim());
}else
Script+=SX+"\n";
}
}}
}else if(Output.Trim()!="")
if(Output.StartsWith("$@#$")){
StatusChanged.Invoke(Output.TrimStart('$').TrimStart('@').TrimStart('#').TrimStart('%'));
}else{
if(Output.StartsWith("~#")){
var SA= Output.TrimStart('~').TrimStart('#').Split(':');
Utilities.AddHash(SA[0], SA[1].Trim());
}else
Script+= Output + "\n";
}
OnCompleted(Script.Trim());
}else { OnCompleted(""); }
}

        
/// <summary>
/// Scan A File For Any Possible Hashes!
/// </summary>
/// <param name="FileDir"></param>
/// <param name="StatusChanged"></param>
/// <param name="OnCompleted"></param>
/// <returns></returns>
public static async Task DoHashScanOnFile(string FileDir,Action<string> StatusChanged,Action OnCompleted){
var P = StartProcess($"HashScanFile \"{FileDir}\"");
var Output = await P.StandardOutput.ReadToEndAsync();
if (Output.Contains("\n")) {
foreach(string SX in Output.Split('\n')){
if(SX.Trim()!=""){
if(SX.StartsWith("$@#%")){
StatusChanged.Invoke(SX.TrimStart('$').TrimStart('@').TrimStart('#').TrimStart('%'));
}else{
var SA= SX.Split(':');
Utilities.AddHash(SA[0], SA[1].Trim());
}
}}
}else if(Output.Trim()!="")
if(Output.StartsWith("$@#$")){
StatusChanged.Invoke(Output.TrimStart('$').TrimStart('@').TrimStart('#').TrimStart('%'));
}else{
var SA= Output.Split(':');
Utilities.AddHash(SA[0], SA[1].Trim());
}
OnCompleted();
}



/*This Setup Is BAD!
public async Task DoHashScanOnFile(string FileDir,Action<string> StatusChanged,Action<string,string> HashFound,Action OnCompleted){
CScriptScanner.LastFileName= FileDir;
CScriptScanner.LastFileDirectory= FileDir;
CScriptScanner.CleanLastFileName();
await CScriptScanner.GetHashes(StatusChanged, HashFound);
OnCompleted.Invoke();
}*/


    }
}
