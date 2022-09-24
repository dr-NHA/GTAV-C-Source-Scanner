using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class am_launcher : C_ScriptFile{
public string FileName=> ("am_launcher" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{
#region force_script_on_lobby
new ScanPreset("force_script_on_lobby",new[]{
"){\nint iVar0;\nint iVar1;\nint iVar2;\nswitch (Global_",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"force_script_on_lobby_trigger", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction.Replace("@","").Replace("if(NETWORK::NETWORK_IS_SCRIPT_ACTIVE(","@").Split('@')[1],
"force_script_on_lobby_scriptid", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

};

public ScanPreset[] GetChars=> new[]{
#region lobby_event_ids
new ScanPreset("lobby_event_ids",new[]{
"AM_HOLD_UP",
"AM_JOYRIDER",
"AM_PLANE_TAKEDOWN",
"AM_DISTRACT_COPS",
"AM_DESTROY_VEH",
"AM_HOT_TARGET",
"AM_CP_COLLECTION",
}, (XFunction) => {
var DB=XFunction.Replace("switch (iParam0){","").Replace("@","").Replace("int iParam0){","@").Split('@')[1].Trim().Replace("\n\n","\n");
var Cases=DB.Replace('"'.ToString(),"").Replace("\ncase ","@").Replace("\nreturn ","").Split('@');
var IND=0;
foreach(string Case in Cases){
if(Case.Contains(":")){
var D2=Case.Split(':');
var NAME=D2[1];
if(NAME.Contains(";"))
NAME=NAME.Replace(";","");
if(NAME.Contains("\n"))
NAME=NAME.Split('\n')[0];

if(!NAME.StartsWith("break") && !NAME.StartsWith("if(func_") &&  !NAME.StartsWith("}") && !NAME.Contains("()") && NAME.Replace(":","").Trim()!=""){
var V=D2[0].Trim();
if(V.Contains("\n"))
V=V.Split('\n')[0];
var OFFSET="LobbyEvent_"+D2[1].Replace(":","").Trim().Trim(';')+": "+V;
if(OFFSET.Contains(";\ndefault"))
OFFSET=OFFSET.Replace(";\ndefault","");
if(OFFSET.Contains(": case"))
OFFSET=OFFSET.Replace(": case",":");

AddOffset(OFFSET);
} }
IND++;
}

}),
#endregion

};


        public ScanPreset[] GetInts=> null;

}}