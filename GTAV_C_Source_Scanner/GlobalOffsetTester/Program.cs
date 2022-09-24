using System;
using System.Windows.Forms;

namespace GlobalOffsetTester{
internal static class Program{
/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
static void Main(string[] args){
(string HName, string HRepo, string HBranch)? HosterInfoX = null;
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
#region Argument Handling
if (args != null ? args.Length > 0 : false) {
if (args[0].ToLower() == "StartAs".ToLower()) {
var DBI = args[0].Contains("/")?  args[0].Split('/') : args[1].Split('/');
HosterInfoX = (DBI[0], DBI[1], DBI[2]);
DBI=null;
}
}
#endregion
Application.Run(new MainForm(HosterInfoX));
}
}
}
