using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace NHA_CScript{
public class CScriptNativeFixer{
        
/// <summary>
/// Rewrite The Unknown Natives File To Remove Doubles And Spaces!
/// For Development Use Only! (ONLY ONE FILE SHOULD BE USED WHEN THIS IS ENABLED!)
/// </summary>
public static bool  RewriteUnknownNatives { get; } = false;
            
/// <summary>
/// The Folder To Store The Natives Information Within
/// </summary>
public static string NativesFolder { get; }= "Natives";
/// <summary>
/// Create The Natives Folder If Not Existant
/// </summary>
public static void InitNativesFolder() {
if (!Directory.Exists(NativesFolder)) {
Directory.CreateDirectory(NativesFolder);
Downloader.NHAGtaDownloader.DownloadStringGithubUserContent("Natives/Natives.dat", (data) =>File.WriteAllText(NativesFile,data));
Downloader.NHAGtaDownloader.DownloadStringGithubUserContent("Natives/NativesUnknown.dat", (data) =>File.WriteAllText(NativesUnknownFile, data));
}}
/// <summary>
/// The Natives File To Read! 
/// Format:
/// 0x00000000,YaMotherSentMe
/// </summary>
public static string NativesFile { get; }= $"{NativesFolder}\\Natives.dat";
/// <summary>
/// The Unknown Natives File To Read!
/// Quicker To Scan If We Temp Remove The Unknowns From The Script Check If Theres Anything Else Left That Could Possibly Be Replaced :)
/// </summary>
public static string NativesUnknownFile { get; }= $"{NativesFolder}\\NativesUnknown.dat";


/// <summary>
/// If The Loaded Known/Unknown Natives Should Be From Assembly Or File 
/// </summary>
public static bool LoadDataFromExeInsteadOfFile=false;
        
/// <summary>
/// Get The Start Time
/// </summary>
public DateTime StartTime { get; private set; } = DateTime.Now;
/// <summary>
/// Get The Finish Time
/// </summary>
public Double FinishTime { get; private set; } = 0;
/// <summary>
/// Check If This Instance Has Ran
/// </summary>
public bool HasRan { get; private set; } =false;


/// <summary>
/// Get The Natives Either By File If Build New Is Enabled, Or By Class
/// </summary>
/// <returns></returns>
public static (string Find, string Replace)[] GetNativeRepalcementFix() {
var TS_STACK=new List<(string Find, string Replace)>();
var DB=new string[] { };

foreach(string Line in 
LoadDataFromExeInsteadOfFile?
Assembly.GetExecutingAssembly().GetManifestResourceString(".Natives.dat", "").Split('\n')
:
File.ReadAllText(NativesFile).Split('\n')
) {
DB= Line.Split(',');
TS_STACK.Add((DB[0].ToUpper().Replace("0X","0x"), DB[1]));
}
DB=null;
return TS_STACK.ToArray();
}

        

/// <summary>
/// Read The Currently Unknown Natives For Skipping Over
/// </summary>
/// <returns></returns>
public static string[] GetNativeUnknownFix() {
var TS_STACK=new List<string>();

foreach(string Line in
LoadDataFromExeInsteadOfFile ?
Assembly.GetExecutingAssembly().GetManifestResourceString(".NativesUnknown.dat","").Replace("\n","").Replace("\r", "").Split(',')
:
File.ReadAllText(NativesUnknownFile).Replace("\n", "").Replace("\r", "").Split(',')
)
TS_STACK.Add(Line.ToUpper().Replace("0X", "0x"));
return TS_STACK.ToArray();
}





/// <summary>
/// Fix Missing Natives From A CScript File
/// </summary>
/// <param name="ScriptName"></param>
/// <param name="Input"></param>
/// <param name="OnStateChanged"></param>
/// <param name="Cleaned"></param>
/// <returns></returns>
public async Task FixNatives(string ScriptName,string Input,Action<string> OnStateChanged, Action<string,bool> Cleaned) {
var IP = Input;
StartTime=DateTime.Now; 
HasRan = false;
OnStateChanged.Invoke("Fixing_Natives " + ScriptName+" Started!!!");

var UnknownNativesList=new List<string>();
            
var _TEMP_UnknownNativesList = GetNativeUnknownFix();
var _Temp_UnknownNative_String = "";
if (RewriteUnknownNatives){
//Replace Unknowns With Temporary Strings To Avoid Them In The Next Part
foreach (var Unknown in _TEMP_UnknownNativesList) 
if(Unknown.Trim().Length > 2?!UnknownNativesList.Contains((_Temp_UnknownNative_String = Unknown.Trim())):false){//Check If The Unknown Natives List Contains This Unknown
IP=IP.Replace(_Temp_UnknownNative_String, "UNKNOWN_NATIVE"+ _Temp_UnknownNative_String);
UnknownNativesList.Add(_Temp_UnknownNative_String);
}
}else if(IP.Contains("unk_0x")||IP.Contains("::_0x"))
//Replace Unknowns With Temporary Strings To Avoid Them In The Next Part
foreach (var Unknown in _TEMP_UnknownNativesList) 
if(Unknown.Trim().Length > 2?IP.Contains((_Temp_UnknownNative_String = Unknown.Trim())):false){//Check If The Script Contains The Unknowns
IP=IP.Replace(_Temp_UnknownNative_String, "UNKNOWN_NATIVE"+ _Temp_UnknownNative_String);
UnknownNativesList.Add(_Temp_UnknownNative_String);
}
_Temp_UnknownNative_String=null; _TEMP_UnknownNativesList = null;


if(IP.Contains("unk_0x")||IP.Contains("::_0x")){
var R2 = GetNativeRepalcementFix();
//Check For Any Natives
foreach ((string Find, string Replace) Stack in R2) 
if(!IP.Contains("unk_0x")&& !IP.Contains("::_0x")) // If No Unknowns Found
break;
else
IP = IP.Replace("_" + Stack.Find, Stack.Replace); //Replace The Current Native Long Hex With The Name
R2 = null;

// If Unknowns Found
if (IP.Contains("unk_0x")||IP.Contains("::_0x")){
var SS="";var OUT = "";
var KNOWNS = IP.Replace('^','~').Replace("unk_0x", "^0x").Replace("::_0x", "^0x");
foreach (var Unknown in KNOWNS.Split('^'))
if(Unknown.StartsWith("0x")?!UnknownNativesList.Contains((OUT = Unknown.Split('(')[0].ToUpper().Replace("0X", "0x"))):false){
UnknownNativesList.Add(OUT);
SS+= OUT + ",\n";
}
OUT=null;
if(SS.Length>5)
File.AppendAllText(NativesUnknownFile, "\n"+(SS.Trim('\n')));
SS=null;
KNOWNS=null;
}
}

///Replace The Avoidance Unknowns With Their Actual Original Long Hex Value!
foreach(var Unknown in UnknownNativesList)
IP=IP.Replace("UNKNOWN_NATIVE" + Unknown, Unknown);

///If Rewriting The Unknown Natives    
if (RewriteUnknownNatives){
if(File.Exists(NativesUnknownFile))
File.Delete(NativesUnknownFile);
var OUT = "";
foreach(var UNKNOWN in UnknownNativesList) 
OUT += UNKNOWN + ",\n";
File.WriteAllText(NativesUnknownFile, OUT.Trim('\n'));
OUT=null;
}

if(UnknownNativesList!=null){
UnknownNativesList.Clear();
UnknownNativesList=null;
}

HasRan=true;
FinishTime=(DateTime.Now - StartTime).TotalSeconds; 
OnStateChanged.Invoke("Fixing_Natives " + ScriptName + " Finished ("+ FinishTime + ")!!!");
Cleaned(IP, false);
}


}}