using NHA_Github;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalOffsetTester.NetworkGlobalOffsets{

public class NetworkGlobalOffsetList {

public GlobalOffsets AllGlobalOffsets = new GlobalOffsets();
public NetworkGlobalOffsetList(string HName,string HRepo,string HBranch,Action OnVersionsDownloadedComplete=null) { 
HosterRepo = HRepo;
HosterBranch = HBranch;
HosterName = HName;
Versions.Clear();
GetVersions((X)=> { OnVersionsDownloadedComplete?.Invoke(); });
}
private Dictionary<string,GlobalOffset> GlobalOffsets=new Dictionary<string, GlobalOffset>();
public Dictionary<string, GlobalOffset> GetGlobalOffsets=> GlobalOffsets;
public async Task<GlobalOffset> GetGlobalOffset(string OffsetName) { 
if(GlobalOffsets.TryGetValue(OffsetName,out GlobalOffset value)) 
return value;
return null;
}

private  List<GlobalOffsetListVersion> V=new List<GlobalOffsetListVersion>();
public  List<GlobalOffsetListVersion> Versions {
get=>V;
private set =>V = value;
}

private string[] HosterInfo = { "", "", "" };

public string HosterName{
get => HosterInfo[0];
private set=> HosterInfo[0]= value;
}
public string HosterRepo{
get => HosterInfo[1];
private set=> HosterInfo[1]= value;
}
public string HosterBranch{
get => HosterInfo[2];
private set=> HosterInfo[2]= value;
}

public void GetVersions(Action<GlobalOffsetListVersion[]> OnGotVersions) =>
Downloading.DownloadStringArrayGithubUserContent((HosterName, HosterRepo, HosterBranch, "Global_Offsets/Versions"),async (XVersions) => { 
Versions.Clear();
foreach(string Version in XVersions) { 
var GLOBALVER= Version.Replace("@","").Replace("_Build_", "@").Split('@');
var VN= GLOBALVER[0].Substring(1);
if (await GetGlobalOffset(VN) ==null){
var B= GLOBALVER[1];
if (B.Contains('.')) { B = B.Split('.')[0]; }
Versions.Add(new GlobalOffsetListVersion(VN, B.Trim()));  
}}
OnGotVersions.Invoke(Versions.ToArray());
});

        
public async Task GetVersionGlobals(string Version,string Build, Action<Dictionary<string,GlobalOffset>> OnGotGlobals) =>
NetworkHelpers.GetVersionGlobals(HosterName, HosterRepo, HosterBranch, Version, Build, async (X) => {
if(X!=null){
GlobalOffsets.Clear();
foreach(string GlobalOffset in X.Split('\n')) { 
if(GlobalOffset.Trim(' ')!=""){
var X2=GlobalOffset.Split(':');
//Add Underscores At The Start Till The Global Offsets Doesnt Contain This Name
while(GlobalOffsets.ContainsKey(X2[0]))
X2[0]="_"+X2[0];

GlobalOffsets.Add(X2[0],new GlobalOffset(X2[0], X2[1].Trim()));
await Task.Delay(1);
}}
AllGlobalOffsets.Setup(this);
OnGotGlobals(GlobalOffsets);
}else{
OnGotGlobals(null);
}
});

}
}
