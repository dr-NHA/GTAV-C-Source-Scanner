using NHA_Github;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NHA_CScript{
public static class Downloader{

public static string Hoster { get; } = "dr-NHA";

public static GithubDownloader DecompiledScriptsDownloader { get; } =
new GithubDownloader(Hoster, "GTAV-Decompiled-Scripts", "Main");
        
public static GithubDownloader NHAGtaDownloader { get; } =
new GithubDownloader(Hoster, "GtaV_2", "main");

/// <summary>
/// Get The Main Scripts Folder Directory
/// </summary>
/// <returns></returns>
public static string GetScriptsFolder() => Hoster + " Scripts";

/// <summary>
/// Check If The Main Scripts Folder Exists
/// </summary>
public static bool ScriptsFolderExists=>Directory.Exists(GetScriptsFolder());

/// <summary>
/// Get A Scripts Folder Directory
/// </summary>
/// <param name="ExtraDir"></param>
/// <returns></returns>
public static string ScriptsFolderDirectory(string ExtraDir)=> GetScriptsFolder() + "\\" + ExtraDir;

/// <summary>
/// Create A Scripts Folder Within The Scripts Directory (Also Creates The Main Directory Beforehand)
/// </summary>
/// <param name="ExtraDir"></param>
public static void SetupScriptsFolder(string ExtraDir=null) {
if (!ScriptsFolderExists) 
Directory.CreateDirectory(GetScriptsFolder());
if (ExtraDir != null?!Directory.Exists(ScriptsFolderDirectory(ExtraDir)):false)
Directory.CreateDirectory(ScriptsFolderDirectory(ExtraDir));
}



/// <summary>
/// Use A Sub/Child Process To Download A File From An Address!
/// </summary>
/// <param name="Address"></param>
/// <param name="FilePath"></param>
/// <param name="OnCompleted"></param>
/// <returns></returns>
public static async Task DownloadFileFromAddressEXT(string Address,string FilePath, Action OnCompleted) =>await 
StartNew.StartProcessReadOutputTillEnd(
$"DownloadFile \"{Address}\" \"{FilePath}\"", 
null,
(DAT) => OnCompleted.Invoke());


}
}