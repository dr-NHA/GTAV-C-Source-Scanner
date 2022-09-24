using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class tuneables_processing : C_ScriptFile{
public string FileName=> ("tuneables_processing" + ".c").ToLower();
public void PreScan(){

} 

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new[]{

#region NightclubCargo
new ScanPreset("NightclubCargo_Function",new[]{
"(iParam0, iParam1, 1162393585, &(Global_",
"), 1);",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"NightclubCargo", ("(iParam0, iParam1, 1162393585, &(Global_", ExtractSplitType.Last) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region Snow

new ScanPreset("turn_snow_on_off",new[]{
"joaat(\"turn_snow_on_off\"), &(Global_",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"turn_snow_on_off", ("joaat(\"turn_snow_on_off\"), &(Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),

#endregion

};

public ScanPreset[] GetChars=>null;


public ScanPreset[] GetInts=> null;


}}