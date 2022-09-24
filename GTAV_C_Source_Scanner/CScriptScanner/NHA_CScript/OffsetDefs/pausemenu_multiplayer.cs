using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class pausemenu_multiplayer:C_ScriptFile{
public string FileName=> ("pausemenu_multiplayer" + ".c").ToLower();
public void PreScan(){

} 

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{

#region PlayerSessionNew
new ScanPreset("PlayerSessionNew_Function",new[]{
"MISC::CLEAR_BIT(&Global_",
"if(PLAYER::IS_SPECIAL_ABILITY_ENABLED(PLAYER::PLAYER_ID(),"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"PlayerSessionNew", ("MISC::CLEAR_BIT(&Global_", ExtractSplitType.Second) ,(",", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};
        
public ScanPreset[] GetChars=>null;
public ScanPreset[] GetInts=> null;

}}