using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHA_CScript{

/// <summary>
/// The Types To Extract As (For Scanning C Script Files)
/// </summary>
public enum ExtractAs:uint { 
Offset,
Global,
Local,
Func,
}


public  static partial class Utilities{

/// <summary>
/// Return Strings From A Manifest Resource File By The Path Or The File Name If Unique Enough!
/// </summary>
/// <param name="ASM"></param>
/// <param name="EndResourceName"></param>
/// <returns></returns>
public static string GetManifestResourceString(this Assembly ASM,string EndResourceName,string IfNoFile=null){
foreach (var ResourceName in ASM.GetManifestResourceNames())
if (ResourceName.EndsWith("." + EndResourceName))
using (Stream stream = ASM.GetManifestResourceStream(ResourceName))
using (StreamReader reader = new StreamReader(stream))
return reader.ReadToEnd().Replace("\r", "");
return IfNoFile;
}


/// <summary>
/// Read Text From A File If It Exists If Not Return "IfNoFile"
/// </summary>
/// <param name="Path"></param>
/// <param name="IfNoFile"></param>
/// <returns></returns>
public static string FileExReadAllText(string Path,string IfNoFile=null) { 
if(File.Exists(Path))
return File.ReadAllText(Path);
return IfNoFile;
}
        
/// <summary>
/// Write Text To A File (Delete It If It Exists)
/// </summary>
/// <param name="Path"></param>
/// <param name="Write"></param>
public static void FileExWriteAllText(string Path,string Write) { 
if(File.Exists(Path))
File.Delete(Path);
File.WriteAllText(Path, Write);   
}


public static string OffsetSplitLog { get; } ="/////////////////////////////////////////////////////";
        


/// <summary>
/// Get Or Set The Last Game Version
/// </summary>
public static string GameVersion{
get=>FileExReadAllText(Environment.CurrentDirectory+"\\GameVersion.dat", "No-Version");
set=>FileExWriteAllText(Environment.CurrentDirectory+"\\GameVersion.dat",value); 
}

/// <summary>
/// Get Or Set The Last Game Build
/// </summary>
public static string GameBuild{
get=>FileExReadAllText(Environment.CurrentDirectory+ "\\GameBuild.dat", "No-Version");
set=>FileExWriteAllText(Environment.CurrentDirectory+ "\\GameBuild.dat", value); 
}

/// <summary>
/// Get The Results Directory
/// </summary>
public static string ResultsDirectory { get; }=Environment.CurrentDirectory+"\\Results";

/// <summary>
/// Get A Results File Path By Name
/// </summary>
/// <param name="Name"></param>
/// <returns></returns>
public static string ResultsFile(string Name)=>ResultsDirectory + "\\"+Name;

/// <summary>
/// Get The Offset File Suffix/Extension
/// </summary>
public static string OffsetFileSuffix { get; }=".Offset";

/// <summary>
/// Get A Results Offsets File By Name
/// </summary>
/// <param name="Name"></param>
/// <returns></returns>
public static string OffsetFile(string Name)=>
ResultsFile(Name.EndsWith(OffsetFileSuffix)?Name:Name+OffsetFileSuffix);

/// <summary>
/// Open The Results Directory
/// </summary>
public static void OpenResultsDirectory()=>
System.Diagnostics.Process.Start(ResultsDirectory);

/// <summary>
/// Create The Results Directory If Not Existant
/// </summary>
public static void SetupResultsDirectory(){
if(!Directory.Exists(ResultsDirectory)) 
Directory.CreateDirectory(ResultsDirectory);
}

public static Func<string> GetOffsets  =()=> null;        
public static Action<string> AddOffset = (X) => { };
public static void SaveAllOffsets(){
var Offsets= GetOffsets.Invoke();
if(Offsets!=null){
SetupResultsDirectory();
var F = ResultsFile("All_Game.Offsets");
if (File.Exists(F))
File.Delete(F);
File.WriteAllText(F, 
"//Offsets Extracted Using: "+Application.ProductName+" "+Application.ProductVersion+"\n//By: dr NHA"+"\n\n"+ OffsetSplitLog+"\n"+Offsets);
}}
public static void WriteOffsetFile(string FileName,string Script){
SetupResultsDirectory();
var OffsetX= OffsetFile(FileName.Replace(".c",""));
if (File.Exists(OffsetX)) 
File.Delete(OffsetX);
File.WriteAllText(OffsetX, Script);
}
public static Action<string,string> AddHash = (X,E) => { };
public static Action ClearLoadedOffsets = () => { };
public static Action SaveHashes = () => { };
public static Action ResetHashes = () => { };
public static Func<int> FoundHashCount = () => 0;


public static async Task<List<int>> DoAllScanPresets(string VoidFunc, ScanPreset[] ScanPresets){
if(ScanPresets!=null){
var LN2=new List<int>();int ID = 0;
foreach(ScanPreset ScanPreset in ScanPresets){try{
if(await ScanPreset.CheckForScript(VoidFunc))
LN2.Add(ID);
}catch(Exception e) { 
throw e;
}
ID++;
}
return LN2;
}
return null;        
}

public static async Task<bool> CheckForScript(string Void_Func, string[] ScriptIdentifiers, Action<string> DoWithResult) { 
var F=true;
foreach(string Identity in ScriptIdentifiers) {
if(Void_Func.Contains(Identity) == false) {
F = false;break;    
}}
if (F){
DoWithResult(Void_Func);
}
return F;
}

public enum ExtractSplitType:long { 
Last=0,
First=1,
Second=2,
Third=3,
Forth=4,
Five=5,
Six=6,
};
public static string ExtractOFS(string XFunction,string Rep, ExtractSplitType St){
var FirstRep = XFunction.Replace(Rep, "饕").Split('饕');
if (St == ExtractSplitType.Last){return FirstRep.Last();
}else if (St == ExtractSplitType.First){return FirstRep.First();
}else if (St == ExtractSplitType.Second){return FirstRep[1];
}else if (St == ExtractSplitType.Third){return FirstRep[2];
}else if (St == ExtractSplitType.Forth){return FirstRep[3];
}else if (St == ExtractSplitType.Five){return FirstRep[4];
}else if (St == ExtractSplitType.Six){return FirstRep[5];
}
return null;
}


public static async Task ExtractOffsetFromString(string XFunction,string OffsetName,(string, ExtractSplitType) Rep0, (string, ExtractSplitType) Rep1,Action<string> AddOffset , ExtractAs ExtractAs,bool Add1BeforeBackets, string Addition="") { 
var Offset= ExtractOFS(ExtractOFS(XFunction, Rep0.Item1, Rep0.Item2), Rep1.Item1, Rep1.Item2);
if (ExtractAs==ExtractAs.Global) {
if (!Offset.StartsWith("Global_")){  Offset = "Global_" + Offset; }
}else if (ExtractAs==ExtractAs.Local){ 
if (!Offset.StartsWith("Local_")){  Offset = "Local_" + Offset; }
}else if (ExtractAs==ExtractAs.Func) {
if (!Offset.StartsWith("func_")){ Offset = "func_" + Offset; }
}
if(Offset.Contains("/*") ) 
Offset=Offset.Replace("/*", "*");

if(Offset.Contains("*/") ) 
Offset=Offset.Replace("*/", "");

if(Offset.Contains(" *") ) 
Offset=Offset.Replace(" *", "*");

if (Offset.Contains("PLAYER::PLAYER_ID()")) 
Offset=Offset.Replace("PLAYER::PLAYER_ID()", "PlayerID");

if(Add1BeforeBackets)
if (Offset.Contains("[")) 
Offset= Offset.Replace(".f_1[","[").Replace("[",".f_1[");

AddOffset.Invoke(OffsetName+": "+Offset+ Addition);
}


}
}
