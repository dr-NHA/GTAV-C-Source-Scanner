using NHA_CScript;
using System;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
internal static class Program{
[STAThread]
static void Main(){
CScriptNativeFixer.InitNativesFolder();
Application.ApplicationExit += (X, E) =>StartNew.InitiateFailsafe(); 
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new DynamicUI(new ScannerUI()));
}
}
}
