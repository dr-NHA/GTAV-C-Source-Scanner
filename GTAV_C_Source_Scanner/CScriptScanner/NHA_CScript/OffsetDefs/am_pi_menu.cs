using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class am_pi_menu : C_ScriptFile{
public string FileName=> ("am_pi_menu" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{
#region BallisticEquipmentCost
new ScanPreset("BallisticEquipmentCost",new[]{
"PIM_TBALLI",
"PIM_BALLIS_D_2",
"PIM_CASH",
"PIM_BALLIS_D_3",
"case 0",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"BallisticEquipmentCost", ("Global_", ExtractSplitType.Second) ,(",", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

};

public ScanPreset[] GetChars=>null;


public ScanPreset[] GetInts=> null;

}}