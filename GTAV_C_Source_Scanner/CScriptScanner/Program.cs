using System;
using System.Net;
using System.Threading.Tasks;

namespace NHA_CScript{
internal class Program{

public static async Task WaitForFailsafe() { 
for(; ;){
if(System.IO.File.Exists(Environment.CurrentDirectory+"\\.CScript.Failsafe")){
break;}
await Task.Delay(100);
}
Environment.Exit(0);
Environment.FailFast(null);
}

static void Main(string[] args){
if (args.Length > 0) {
if (args[0] == "CleanFile" && args.Length > 1) {
WaitForFailsafe();
var CS = new CScriptCleaner();
CS.CleanStrings(args[1],System.IO.File.ReadAllText( args[2]), (X) =>Console.WriteLine(X),  (X, E) => {
if(E==false){
if (System.IO.File.Exists(args[2])){System.IO.File.Delete(args[2]);}
System.IO.File.WriteAllText(args[2], X);
}
Environment.Exit(0);
Environment.FailFast(null);
});
System.Threading.Thread.Sleep(-1);



}else  if (args[0] == "FixNatives" && args.Length > 1) {
WaitForFailsafe();
var CS = new CScriptNativeFixer();
CS.FixNatives(args[1],System.IO.File.ReadAllText( args[2]), (X) =>Console.WriteLine(X),  (X, E) => {
if(E==false)
if (System.IO.File.Exists(args[2])) System.IO.File.Delete(args[2]);
System.IO.File.WriteAllText(args[2], X);
Environment.Exit(0);
Environment.FailFast(null);
});
System.Threading.Thread.Sleep(-1);



}else if (args[0] == "ScanFile" && args.Length > 0) {
WaitForFailsafe();
var CS = new CScriptScanner((Name) => { Console.WriteLine(Name); }, 
() => {// Console.WriteLine("$@#%Finished");
Environment.Exit(0);
Environment.FailFast(null); });
CS.LastFileDirectory= args[1];
CS.LastFileName= CS.LastFileDirectory;
CS.CleanLastFileName();

CS.FullScanScriptString((STATE) => { Console.WriteLine("$@#%"+STATE); },
    (STATE) => { Console.WriteLine("$@#%HASH_SCANNER: "+STATE); },
(HashName,HashValue) => { Console.WriteLine("~#"+HashName+": " + HashValue); }
);
System.Threading.Thread.Sleep(-1);


}else if (args[0] == "HashScanFile" && args.Length > 0) {
WaitForFailsafe();
var CS = new CScriptScanner((Name) => { Console.WriteLine(Name); }, 
() => {// Console.WriteLine("$@#%Finished");
Environment.Exit(0);
Environment.FailFast(null); });
CS.LastFileDirectory= args[1];
CS.LastFileName= CS.LastFileDirectory;
CS.CleanLastFileName();
CS.GetHashes((STATE) => { Console.WriteLine("$@#%" + STATE); },
(HashName, HashValue) => { Console.WriteLine(HashName + ": " + HashValue); });

System.Threading.Thread.Sleep(-1);



}else if (args[0] == "DownloadFile" && args.Length > 0) {
WaitForFailsafe();
DownloadFileFromAddress(args[1], args[2], () => {// Console.WriteLine("$@#%Finished");
Environment.Exit(0);
Environment.FailFast(null); });

System.Threading.Thread.Sleep(-1);

}else if (args[0] == "FailSafe") {
System.IO.File.WriteAllText(Environment.CurrentDirectory+"\\.CScript.Failsafe","Blank Failsafe File");
System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2.1));
if(System.IO.File.Exists(Environment.CurrentDirectory+"\\.CScript.Failsafe")){
System.IO.File.Delete(Environment.CurrentDirectory+"\\.CScript.Failsafe");}
Environment.Exit(0);
Environment.FailFast(null);
}

};
}

        
        
public static void DownloadFileFromAddress(string address,string FilePath,Action OnCompleted) {
WebClient WC = new WebClient();
WC.DownloadFileCompleted += (X, E) => {
OnCompleted.Invoke();
WC.Dispose();
GC.Collect(GC.GetGeneration(WC));
WC=null;
};
WC.DownloadFileAsync(new Uri(address), FilePath);
}




}}
