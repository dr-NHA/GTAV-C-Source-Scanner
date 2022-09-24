using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GlobalOffsetTester{
public static class StartNew{

/// <summary>
/// NHA CScript Process File Name
/// </summary>
public static string StartFileName { get; } = "GlobalOffsetTester.exe";

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
/// Open The Offset Tester
/// </summary>
/// <param name="GithubUserRepoContent"></param>
/// <returns></returns>
public static async Task<Process> OpenOffsetTester((string UserName,string Repo,string Branch) GithubUserRepoContent)=>
StartProcess($"StartAs \"{GithubUserRepoContent.UserName}/{GithubUserRepoContent.Repo}/{GithubUserRepoContent.Branch}\"");
        
        
/// <summary>
/// Open The Offset Tester
/// </summary>
/// <returns></returns>
public static async Task<Process> OpenOffsetTester()=>StartProcess(null);

}}