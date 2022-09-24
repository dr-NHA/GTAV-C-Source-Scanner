using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class casino_slots : C_ScriptFile{
public string FileName=> ("casino_slots" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{

#region RigSlots
new ScanPreset("RigSlots",new[]{
"(iVar0, &Var2, &",
"iVar1 < 3",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"RigSlots", ("&Local_", ExtractSplitType.Second) ,(",", ExtractSplitType.First), AddOffset,ExtractAs.Local,false);
}),
#endregion

};

public ScanPreset[] GetChars=>null;


public ScanPreset[] GetInts=> null;


}}