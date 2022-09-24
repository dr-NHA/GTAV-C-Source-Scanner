using NHA_CScript.OffsetDefs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHA_CScript{
public class CScriptScanner{
        
/// <summary>
/// The Version Of The Scanner
/// </summary>
public static float Version { get; } = 1.2f;
/// <summary>
/// If The Scanner Version Is Beta
/// </summary>
public static bool IsBeta { get; } =false;
/// <summary>
/// Get The Version Info As Text
/// </summary>
public static string VersionInfo =>Version.ToString("#.##")+(IsBeta?"B":"");

/// <summary>
/// The Add Offset Function (Invoked Each Time A Offset Is Found!)
/// </summary>
private Action<string> AddOffsetFunc=null;

/// <summary>
/// Invoke The Add Offset Function
/// </summary>
/// <param name="Offset"></param>
public void XAddOffset(string Offset)=>
AddOffsetFunc?.Invoke(Offset);
        

/// <summary>
/// Action Called On Scan Finish
/// </summary>
private Action _ScanFinished=null;


/// <summary>
/// Setup A CScript Scanner
/// </summary>
/// <param name="XAddOffsetFunc"></param>
/// <param name="OnScanCompleted"></param>
public CScriptScanner(Action<string> XAddOffsetFunc,Action OnScanCompleted) {
ALL.FillDCScripts();
foreach (C_ScriptFile ScriptFile in ALL.CScripts.Values) 
AllowedScripts.Add(ScriptFile.FileName);
AddOffsetFunc=XAddOffsetFunc;
_ScanFinished=OnScanCompleted; 
}




/// <summary>
/// True If A File Has Been Opened
/// </summary>
public bool HasAFileBeenOpened { get; private set; } = false;

/// <summary>
/// Get/Set The Last File Name
/// </summary>
public string LastFileName { get; set; } ="Unknown.c";


/// <summary>
/// Clean The Stored Last File Name Text
/// </summary>
public void CleanLastFileName(){        
HasAFileBeenOpened=true;
if (LastFileName.Contains('\\')) {LastFileName = LastFileName.Split('\\').Last();}
if (LastFileName.Contains('/')) {LastFileName = LastFileName.Split('/').Last();}
LastFileName= LastFileName.ToLower();
}


/// <summary>
/// Get/Set The Last File Directory That Was Loaded  
/// </summary>
public string LastFileDirectory { get; set; } ="Unknown.c";



/// <summary>
/// Get Or Set The Script String
/// </summary>
public string ScriptString{
get {
if(System.IO.File.Exists(LastFileDirectory))
return System.IO.File.ReadAllText(LastFileDirectory);
else return null;
}     
set{
if(System.IO.File.Exists(LastFileDirectory))
System.IO.File.Delete(LastFileDirectory);
System.IO.File.WriteAllText(LastFileDirectory, value);
}
}
        


public async Task ScanScriptString(string CScriptFunctionType,string ClearTextType,Action<string> StateCallback,Action<string> OnScanFunc) { 
StateCallback.Invoke("Scanning "+LastFileName+" Within "+ClearTextType+" Functions!");
var XDate=DateTime.Now;
var XLine="";
foreach (string Line in ScriptString.Replace(CScriptFunctionType+ " func", "饕").Split('饕')) 
if ((XLine = Line)!=null?(XLine.Contains("\n\n") && XLine.StartsWith("_")):false) 
OnScanFunc(//Add The Function Type (void int Ect) Back
CScriptFunctionType + " func"//Also Add The Word func Back 
+(XLine.Replace("\n\n", "饕").Split('饕')[0])//Function Contents
);

var XDbA= (DateTime.Now - XDate).TotalSeconds;
StateCallback.Invoke("Finished "+LastFileName+" ("+ClearTextType+" Function) Scanning In: " + XDbA + " Second"+(XDbA >= 2?"'s":"")+" !");
}


public async Task ScanScriptString__EntryFunction__(Action<string> StateCallback,Action<string> OnScanFunc) { 
StateCallback.Invoke("Scanning "+LastFileName+ " Within Entry Function!");
var XDate=DateTime.Now;
var FUNC= ScriptString.Replace("void __EntryFunction__", "饕").Split('饕')[1].Replace(" func", "饕").Split('饕')[0];
if(FUNC.Contains("\n\n"))
FUNC= FUNC.Replace("\n\n", "饕").Split('饕')[0];
if(!FUNC.StartsWith("void __EntryFunction__"))
FUNC= "void __EntryFunction__"+FUNC;
OnScanFunc.Invoke(FUNC.Trim());

var XDbA= (DateTime.Now - XDate).TotalSeconds;
StateCallback.Invoke("Finished "+LastFileName+" (Entry Function) Scanning In: " + XDbA + " Second"+(XDbA >= 2?"'s":"")+" !");
}

        

public async Task GetHashes(Action<string> StateCallback,Action<string,string> HashFoundCallback) { 
StateCallback.Invoke("Scanning "+LastFileName+" For All Hashes / Objects");
var XDate=DateTime.Now;
var DA= '"'.ToString();
var XLine="";
var HashName="";
foreach (string Line in ScriptString.Replace("joaat(", "饕").Split('饕')) 
if ((XLine = Line)!=null?(XLine.StartsWith(DA) && XLine.Contains(DA+")"))?(HashName = XLine.Split('"')[1])!=null:false :false) 
HashFoundCallback.Invoke(HashName,Utilities.joaat(HashName).ToString("X2"));
XLine=null;
HashName=null;
var XDbA= (DateTime.Now - XDate).TotalSeconds;
StateCallback.Invoke("Finished "+LastFileName+" (Hash/Object) Scanning In: " + XDbA + " Second"+(XDbA >= 2?"'s":"")+" !");
_ScanFinished.Invoke();
}


public static List<string> AllowedScripts=new List<string>();
      

private bool _IsScanning=false;

public async Task FullScanScriptString(Action<string> OnStateChanged,Action<string> HashScanStateChanged,Action<string,string> HashFoundCallback){
Utilities.AddOffset=XAddOffset;
if(_IsScanning==false){
await Task.Delay(1);
if(_IsScanning==false){
_IsScanning=true;
if(AllowedScripts.Contains(LastFileName)){
OnStateChanged.Invoke(LastFileName+": Scanning: ");
var FN= ALL.GetCScriptFromName(LastFileName);

/// <summary>
/// Before The Script Has Been Scanned (Setup)
/// </summary>
FN.PreScan();

//Scan Entry Functions First
await ScanScriptString__EntryFunction__(OnStateChanged,async (X) => {
var DB = FN.GetEntryFunction;
if(DB!=null)
await ScanPreset.CheckForScript(DB, X);
});

await Task.Run(async () => { 
  //Scan Void Functions Second
var FUNCTIONS= FN.GetVoids;
if(FUNCTIONS != null){
var List=new List<int>();
var L2=new List<ScanPreset>();
var INDEX=0;
await ScanScriptString("void", "Regular Void", OnStateChanged, async (X) => {

var F= await Utilities.DoAllScanPresets(X, FUNCTIONS);
if(F!=null)
List.AddRange(F);
});
foreach(var P in FUNCTIONS) {
if(!List.Contains(INDEX))
L2.Add(P);
INDEX++;}
L2.ForEach(X => XAddOffset("****Cannot Find Script: "+X.Name));
}                     
});



//Scan Int Functions Third
await ScanScriptString("int", "Integer", OnStateChanged, async (X) => {
//var F=
await Utilities.DoAllScanPresets(X, FN.GetInts);
//if(F!=-1)
//ListedInts.RemoveAt(F);
});/*
foreach(Utilities.ScanPreset scanPreset in ListedInts)
System.Windows.Forms.MessageBox.Show(scanPreset.Name+" Failed To Be Found", "ListedInts: Scanner Error!");
*/

//Scan Char Functions Third
await ScanScriptString("char*", "Char Pointer", OnStateChanged, async (X) =>{
//var F=
await Utilities.DoAllScanPresets(X, FN.GetChars);
//if(F!=-1)
//ListedChars.RemoveAt(F);
});/*
foreach(Utilities.ScanPreset scanPreset in ListedChars)
System.Windows.Forms.MessageBox.Show(scanPreset.Name+" Failed To Be Found", "ListedChars: Scanner Error!");
*/         
                        
/*
await ScanScriptString("bool", "Boolean", OnStateChanged, (X) => {

});
await ScanScriptString("float", "Flotation", OnStateChanged, (X) => {

});
await ScanScriptString("Vector3", "Vector3", OnStateChanged, (X) => {

});
await ScanScriptString("var", "Variable", OnStateChanged, (X) => {

});*/
//await GetHashes(HashScanStateChanged,HashFoundCallback);
}

_ScanFinished.Invoke();
_IsScanning = false;
}else{
_IsScanning = true;
//await GetHashes(HashScanStateChanged, HashFoundCallback);
_ScanFinished.Invoke();
_IsScanning = false;
}
}
}
       
        





}}