using GlobalOffsetTester.NetworkGlobalOffsets;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalOffsetTester{
public partial class MainForm : Form{
      
NetworkGlobalOffsetList NGOL=null;

public MainForm((string HName, string HRepo, string HBranch)? HosterInfoX=null){
InitializeComponent();

if (HosterInfoX != null? HosterInfoX.HasValue:false) {
HosterName.Text = HosterInfoX.Value.HName;
HosterRepo.Text = HosterInfoX.Value.HRepo; 
HosterBranch.Text= HosterInfoX.Value.HBranch;
}

XGlobalOffsets.Visible = false;
this.MinimumSize = new Size(this.MinimumSize.Width, HosterInfo.Height + 38);
this.Height = this.MinimumSize.Height;

SetHosterInfo.Click += async (X, E) => { 
var DOWNLOADING=true;
NGOL = new NetworkGlobalOffsetList(HosterName.Text, HosterRepo.Text, HosterBranch.Text, () => { DOWNLOADING = false; });

while(DOWNLOADING) 
await Task.Delay(10);

GameVersions.Items.Clear();
foreach(GlobalOffsetListVersion Ver in NGOL.Versions)
GameVersions.Items.Add("Version: "+Ver.Version+" Build: "+Ver.Build);
HosterInfo.Visible = false;
this.MinimumSize = new Size(this.MinimumSize.Width, XGlobalOffsets.Height + 38);
this.Height = this.MinimumSize.Height;
XGlobalOffsets.Visible = true;
};

var DOWNLOADINGNEWVERSIONGLOBALS=false;
var SetGameVersionOLD = SetGameVersion.Text;
SetGameVersion.Click += (X, E) => {
if(!DOWNLOADINGNEWVERSIONGLOBALS){
DOWNLOADINGNEWVERSIONGLOBALS = true;
SetGameVersion.Text=$"Getting {GameVersion.Text.Trim()} ({BuildName.Text.Trim()}) Global Offsets";
NGOL.GetVersionGlobals(GameVersion.Text.Trim(), BuildName.Text.Trim(), (GlobalOffsets)=>{
if(GlobalOffsets!=null){
var X2="";
foreach(GlobalOffset globalOffset in GlobalOffsets.Values)
X2+=globalOffset.Name+": "+globalOffset.Value+"\n";
Globals.Text=X2.Trim('\n');
}else { 
Globals.Text="Global Offsets Version File Doesnt Exist!";
}
SetGameVersion.Text = SetGameVersionOLD;
    DOWNLOADINGNEWVERSIONGLOBALS = false;
});
}};

GameVersions.SelectedIndexChanged+=(X,E)=> { 
if(GameVersions.SelectedIndex>-1){
var GLOBALVER= ((string)GameVersions.SelectedItem).Replace("@","").
Replace("Version:", "@").Split('@')[1].Replace("Build:", "@").Split('@');
var B= GLOBALVER[1];
if (B.Contains('.')) { B = B.Split('.')[0]; }
GameVersion.Text = GLOBALVER[0].Substring(1).Trim();
BuildName.Text = B.Trim();

}};

}


}}