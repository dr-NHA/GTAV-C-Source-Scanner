using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class main:C_ScriptFile{
public string FileName=> ("main" + ".c").ToLower();
public void PreScan(){

} 
        
public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{

#region BluePhoneType
new ScanPreset("BluePhoneType_Function",new[]{
"while (!bVar1 && iVar2 <",
"int iVar0;\nbool bVar1;\nint iVar2;",
"iVar2++;",
"bVar1=true;",
"bVar1=false;",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"BluePhoneType", ("if(Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};

public ScanPreset[] GetChars=>new []{

#region NG_filmnoir_BW
new ScanPreset("NG_filmnoir_BW_Function",new[]{
"NG_filmnoir_BW02",
"NG_filmnoir_BW01",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"NG_filmnoir_BW", ("(Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};


public ScanPreset[] GetInts=> null;


}}