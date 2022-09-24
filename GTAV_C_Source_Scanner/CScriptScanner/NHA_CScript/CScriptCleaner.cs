using System;
using System.Threading.Tasks;

namespace NHA_CScript{
public  class CScriptCleaner{
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
public bool HasRan { get; private set; } = false;

/// <summary>
/// The Version Of The Cleaner
/// </summary>
public static float Version { get; } =2.72f;
/// <summary>
/// If The Cleaner Version Is Beta
/// </summary>
public static bool IsBeta { get; } = false;
/// <summary>
/// Get The Version Info As Text
/// </summary>
public static string VersionInfo { get; } =Version.ToString("#.##")+(IsBeta?"B":"");
/// <summary>
/// Get The Signing Text For The Cleaner
/// </summary>
public static string CleanerCo { get; } =$"//Cleaned With dr NHA's C Script Cleaner V{VersionInfo}";
/// <summary>
/// Get The Default Cleaning Replacement Array
/// </summary>
public static (string Find, string Replace)[] ReplacementArray { get {
if(_ReplacementArray == null){
_ReplacementArray = new[] {
(" ", " "),
("       ", " "),
("      ", " "),
("     ", " "),
("    ", " "),
("    ", " "),
("   ", " "),
("  ", " "),
("   ", ""),
("  ", " "),
("	", " "),
("\r", ""),
("\b", ""),
("\n", ""),
(": ", ":\n"),
("{", "{\n"),
(";", ";\n"),
("\n}", "}"),
("}", "\n}"),
("}", "}\n"),
("\n \n", ""),
("}\n\n", "}\n"),
("\n\n}", "\n}"),
("}\n}", "}}\n"),
(";}", ";\n}"),
("\n ", "\n"),
("\n ", "\n"),
("\n  ", "\n"),
("\n   ", "\n"),
("\n    ", "\n"),
("if ", "if"),
(") {", "){"),
(" =", "="),
("= ", "="),
("BitTest", "MISC::IS_BIT_SET"),
("#region Local Varv", "#region Local Var\nv"),
("#region Local Var ", "#region Local Var\n"),
("\n\n}", "\n}"),
("\n\n}", "\n}"),
("}\nelse", "}else"),
("}\n else", "}else"),
("else\n{", "else{"),
("}\n}", "}}"),
("}\n\n", "}\n"),
("}\n \n", "}\n"),
("} \n \n", "}\n"),
("}\n;", "};"),
("{\nVar0\n};", "{Var0};"),
("void ", "\n\nvoid "),
("char* func_", "\n\nchar* func_"),
("int func_", "\nint func_"),
("float func_", "\n\nfloat func_"),
("bool func_", "\n\nbool func_"),
("Vector3 func", "\n\nVector3 func_"),
("var func", "\n\nvar func_"),
("struct<10> func_", "\n\nstruct<10> func_"),
("struct<9> func_", "\n\nstruct<9> func_"),
("struct<8> func_", "\n\nstruct<8> func_"),
("struct<7> func_", "\n\nstruct<7> func_"),
("struct<6> func_", "\n\nstruct<6> func_"),
("struct<5> func_", "\n\nstruct<5> func_"),
("struct<4> func_", "\n\nstruct<4> func_"),
("struct<3> func_", "\n\nstruct<3> func_"),
("struct<2> func_", "\n\nstruct<2> func_"),
("struct<1> func_", "\n\nstruct<1> func_"),
};
}
return _ReplacementArray;
} }
/// <summary>
/// Storage For The Replacement Array
/// </summary>
private static (string Find, string Replace)[] _ReplacementArray =null;



/// <summary>
/// Clean A Script
/// </summary>
/// <param name="ScriptName"></param>
/// <param name="Input"></param>
/// <param name="OnStateChanged"></param>
/// <param name="Cleaned"></param>
/// <returns></returns>
public async Task CleanStrings(string ScriptName,string Input,Action<string> OnStateChanged, Action<string,bool> Cleaned) {
var IP = Input;
bool HAR = false;
StartTime=DateTime.Now;
FinishTime = 0;
HasRan = false;
if(IP.StartsWith(CleanerCo)){
///Already Cleaned!
OnStateChanged.Invoke("Cleaning " + ScriptName + " Stopped As The File Is Already Cleaned!");
HAR = true;
FinishTime=(DateTime.Now - StartTime).TotalSeconds; 
}else{ 
///Cleaner Hasnt Already Ran!
OnStateChanged.Invoke("Cleaning "+ ScriptName+" Started!!!");
await Task.Delay(20);
///Fix New Lines
for (; ; ) {if(IP.Contains("\n ")) {IP = IP.Replace("\n","");}else { break; }}

///General Replacement
foreach ((string Find, string Replace) Stack in ReplacementArray) 
IP = IP.Replace(Stack.Find, Stack.Replace);


///Spacing Fix
for (; ; ) {if(IP.Contains("  ")) {IP = IP.Replace("  "," ");}else { break; }}
for (; ; ) {if(IP.Contains(" {")) {IP = IP.Replace(" {","{");}else { break; }}
for (; ; ) {if(IP.Contains(" if")) {IP = IP.Replace(" if","if");}else { break; }}
for (; ; ) {if(IP.Contains("\n ")) {IP = IP.Replace("\n ","\n");}else { break; }}
for (; ; ) {if(IP.Contains("}\n}")) {IP = IP.Replace("}\n}","}}");}else { break; }}
for (; ; ) {if(IP.Contains("\n\n}")) {IP = IP.Replace("\n\n}", "\n}");}else { break; }}
IP= CleanerCo + "\n"+IP;
}
HasRan=true;
if(HAR==false){
FinishTime=(DateTime.Now -StartTime).TotalSeconds; 
OnStateChanged.Invoke("Cleaning " + ScriptName + " Finished ("+FinishTime+")!!!");
}
Cleaned(IP, HAR);
}



}}