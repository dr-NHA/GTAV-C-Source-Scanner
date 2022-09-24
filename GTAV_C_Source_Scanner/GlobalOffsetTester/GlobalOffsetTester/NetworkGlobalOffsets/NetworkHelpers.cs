using NHA_Github;
using System;

namespace GlobalOffsetTester.NetworkGlobalOffsets{
public static class NetworkHelpers{

public static void GetVersions(string HosterName,string HosterRepo,string HosterBranch,Action<string[]> OnGotVersions) =>
Downloading.DownloadStringArrayGithubUserContent((HosterName, HosterRepo, HosterBranch, "Global_Offsets/Versions"), OnGotVersions);


public static void GetVersionGlobals(string HosterName,string HosterRepo,string HosterBranch,string Version,string Build,Action<string> OnGotGlobals)=>
Downloading.DownloadStringGithubUserContent((HosterName, HosterRepo, HosterBranch, 
"Global_Offsets/"+"V"+Version+ "_Build_" + Build+".Offsets"), OnGotGlobals);   

}
}
