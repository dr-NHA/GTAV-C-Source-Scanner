using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class am_hold_up : C_ScriptFile{
public string FileName=> ("am_hold_up" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{

#region ShowAllOnMinimap
new ScanPreset("ShowAllOnMinimap",new[]{
"weapon_unarmed",
"SNK_MNU"},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"ShowAllOnMinimap", ("Global_", ExtractSplitType.Second) ,("=", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};
        
public ScanPreset[] GetChars=>null;
public ScanPreset[] GetInts=> null;


}}
