using NHA_CScript;
using Octokit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
public partial class Uploader : Form{

public static async Task PlayCompleted(){
SystemSounds.Asterisk.Play();
await Task.Delay(335);
SystemSounds.Asterisk.Play();
await Task.Delay(235);
SystemSounds.Asterisk.Play();
}
        
GitHubClient client;

public Uploader(){
InitializeComponent();
GitUserToken.ReadOnly = false;
ProjectList.Items.Clear();

var LOGS="";
void AddLog(string Text) =>LOGS+="\n"+Text;            


string REPO = null;
var GV="";
void UpdateGV() {  GV=$"V{Utilities.GameVersion}_Build_{Utilities.GameBuild}";}
UpdateGV();
UpdateInfo.Text=GV;
VisibleChanged += (X, E) => {
UpdateGV();
UpdateInfo.Text = GV;
};
CreatePAT.Click += (X, E) => Process.Start("https://github.com/settings/tokens");

LoginButton.Click +=async (X, E) => {
var credentials = new Credentials(GitUserToken.Text);
client = new GitHubClient(new ProductHeaderValue("NHAsCScriptScanner")){Credentials = credentials};
GitUserToken.ReadOnly = true;

ProjectList.Items.Clear();
foreach(Repository Repo in await client.Repository.GetAllForCurrent())    
ProjectList.Items.Add(Repo.Name);
};



SelectProject.Click+=async (X,E)=>{
if (ProjectList.SelectedIndex > -1) {
REPO= (string)ProjectList.SelectedItem;
UpdateGV();
var User= (client.User.Current());
for(; ; ){if(User.IsCompleted){ break;}await Task.Delay(10);}
 GV=$"V{Utilities.GameVersion}_Build_{Utilities.GameBuild}";
UpdateInfo.Text=GV;
        RepoX.Text = "Repo: "+ REPO;
}else
REPO=null;
};



UploadGlobalOffsets.Click +=async (X, E) => {
if(REPO != null){
var User = (client.User.Current());
for (; ; ) { if (User.IsCompleted) { break; } await Task.Delay(10); }

var OF="";
foreach(string Dir in Directory.GetFiles(Utilities.ResultsDirectory)){
if (Dir.EndsWith(Utilities.OffsetFileSuffix)) { 
OF+=File.ReadAllText(Dir).Trim('\n')+"\n";              
}}
OF = OF.Trim('\n');

await UploadFile(client,User, REPO, "Global_Offsets/" + GV + ".Offsets", OF, GV.Replace('_', ' ') + " Updated!");

await PlayCompleted();
}
};


UploadNatives.Click +=async (X, E) => { 
if(REPO != null){
var User = (client.User.Current());
for (; ; ) { if (User.IsCompleted) { break; } await Task.Delay(10); }

foreach(string Dir in Directory.GetFiles(CScriptNativeFixer.NativesFolder)){
if (Dir.EndsWith(".dat")) { 
var NAME= Dir.Replace("/","\\").Split('\\').Last();

var i=100;
while(true){
try{
await UploadFile(client,User, REPO, "Natives/" + NAME, File.ReadAllText(Dir).Trim('\n'), NAME.Substring(0, NAME.Length-4) + " Updated!");
break;
}catch(Exception ex) { }
await Task.Delay(i);i += 100;if(i>1000) i=1000;
}

}
}
 
await PlayCompleted();   
}
};


bool UploadingCleanedScripts=false;
UploadCleanedScripts.Click += async (X, E) => {
if(REPO!=null&&UploadingCleanedScripts == false){
UploadingCleanedScripts = true;
var VER= $"Version {Utilities.GameVersion} Build {Utilities.GameBuild}";
var User = (client.User.Current());
for (; ; )  if (User.IsCompleted)  break; else await Task.Delay(10); 
await Task.Delay(10);
AddLog( "Uploading: "+VER+" To Github: "+ User.Result.Name);
var NHA= "dr-NHA Scripts\\"+VER;

var ITEMS= Directory.GetFiles(NHA);
var COUNT = ITEMS.Length;
int Scanned=0;int ScannedNeeded =10;
var FID = 0;
foreach(string Dir in ITEMS) {
if (Dir.EndsWith(".c")) {
var NAME= Dir.Replace("/","\\").Split('\\').Last();
                
Scanned++;
Task.Run(async()=>{
    var TFIX = FID;
int WAIT=211;
while(true){
try{
await UploadFile(client,User, REPO, "Cleaned_Decompiled_Scripts/" + VER + "/" + NAME, File.ReadAllText(Dir).Trim('\n'), NAME + " Uploaded @ "+DateTime.UtcNow.ToString());
AddLog("Uploaded: [" + TFIX + "] " + NAME + " To Github!");
break;
}catch(Exception EF) { 
                
}

await Task.Delay(WAIT);
WAIT+=225;
if(WAIT> 12500) WAIT= 12500;
}
Scanned--;
});
await Task.Delay(15);
FID++;



if(Scanned>=ScannedNeeded){
await Task.Delay(55);
while (Scanned > ScannedNeeded - 2) { 
await Task.Delay(55);
}}

await Task.Delay(255);
}}


while (Scanned >= 1) 
await Task.Delay(35);
await PlayCompleted();
AddLog("Cleaned Scripts Uploader Ready!");
UploadingCleanedScripts=false;
}};



LOGS = "Ready!";


            UI.Tick += (X, E) => {
                if (UploadScriptsStatus.Text!= LOGS) {
                    UploadScriptsStatus.Text = LOGS;
                    UploadScriptsStatus.SelectionLength = 0;
                    UploadScriptsStatus.SelectionStart = UploadScriptsStatus.TextLength;
                    UploadScriptsStatus.ScrollToCaret();
                }
            };
}

public static async Task UploadFile(GitHubClient client,Task<User> User,string REPO,string FileAndPath,string Data,string UploadDescriptionText){      
dynamic fileDetails = null;
try{
var BRANCH = (await client.Repository.Get(User.Result.Login, REPO)).DefaultBranch;
//if (await URLExists("https://raw.githubusercontent.com/" + User.Result.Login+"/"+ REPO + "/"+BRANCH+"/"+ FileAndPath))
fileDetails= await client.Repository.Content.GetAllContentsByRef(User.Result.Login, REPO, FileAndPath, BRANCH);      
if(fileDetails!=null)
 await   client.Repository.Content.DeleteFile(User.Result.Login, REPO, FileAndPath, new DeleteFileRequest(UploadDescriptionText, fileDetails[0].Sha, BRANCH));
await Task.Delay(10);
}catch(Exception EE) { 
            
}
await client.Repository.Content.CreateFile(User.Result.Login, REPO, FileAndPath,new CreateFileRequest(UploadDescriptionText, Data));
}




public static async Task UploadFilesSLOW(GitHubClient client,Task<User> User,(string REPO,string FileAndPath,string Data,string UploadDescriptionText)[] Upload,dynamic Delay){      
foreach(var F in Upload){
await UploadFile(client,User, F.REPO, F.FileAndPath, F.Data, F.UploadDescriptionText);
await Task.Delay(Delay);
}}

public static async Task UploadFiles(GitHubClient client,Task<User> User,string REPO,(string FileAndPath,string Data)[] Upload,string UploadDescriptionText){      
NewCommit newCommit=null;
Dictionary<string,string> GetSHAFromFilePath= new Dictionary<string,string>();

TreeResponse TREE=null;
var NT= new NewTree() { };
string SHA=null;
var REPOSITORY=client.Repository.Get(User.Result.Login, REPO).Result;
Branch BRANCH=null;//await client.Repository.Branch.Get(User.Result.Login, REPO, REPOSITORY.DefaultBranch);

if(BRANCH != null){
SHA = BRANCH.Commit.Sha;
//var COMMIT = await client.Git.Commit.Get(User.Result.Login, REPO, SHA);
try{
TREE=await client.Git.Tree.GetRecursive(User.Result.Login, REPO, SHA);
foreach(var T in     TREE.Tree)
GetSHAFromFilePath.Add(T.Path.Split('/').Last(), T.Sha);
}catch(Exception E){

}
}

foreach(var FILE in Upload)
NT.Tree.Add(new NewTreeItem() {
    Content= FILE.Data,
    Path= FILE.FileAndPath,
   Type=TreeType.Commit,
   Mode = "160000"
});

if (TREE != null)
foreach(var NTX in NT.Tree) 
NTX.Sha = GetSHAFromFilePath[NTX.Path.Split('/').Last()];

var UploadTree=await client.Git.Tree.Create(User.Result.Login, REPO, NT);
if(UploadTree != null){
newCommit = new NewCommit(UploadDescriptionText, UploadTree.Sha, SHA);
if (newCommit!=null){
var commit = await client.Git.Commit.Create(User.Result.Login, REPO, newCommit);
await client.Git.Reference.Update(User.Result.Login, REPO, "heads/master", new ReferenceUpdate(commit.Sha));
}}
        
        }

        public static async Task<bool> URLExists (string url) {
        bool result = false;

        WebRequest webRequest = WebRequest.Create(url);
        webRequest.Timeout = 1200; // miliseconds
        webRequest.Method = "HEAD";

        HttpWebResponse response = null;

        try {
            response = (HttpWebResponse) await webRequest.GetResponseAsync();
            result = true;
        } catch (WebException webException) {
        } finally {
            if (response != null) {
                response.Close();
            }
        }

        return result;
    }


}
}
