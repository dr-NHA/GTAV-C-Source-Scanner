using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class three_card_poker : C_ScriptFile{
public string FileName=> ("three_card_poker" + ".c").ToLower();
public void PreScan(){

} 

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>null;

public ScanPreset[] GetChars=>null;


public ScanPreset[] GetInts=> new[]{

#region TCP_StraightFlush TCP_Current_Table TCP_Current_Table_Data
new ScanPreset("ThreeCardPokerResult_Function",new[]{
"STATS::_PLAYSTATS_CASINO_THREECARDPOKER(&Local_",
">=52",
"return 0;",
"return 1;",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"TCP_StraightFlush", ("] !=Local_", ExtractSplitType.Last) ,("[", ExtractSplitType.First), AddOffset,ExtractAs.Local,false);
await ExtractOffsetFromString(XFunction,"TCP_Current_Table", ("!MISC::IS_BIT_SET(Local_", ExtractSplitType.Last) ,("]", ExtractSplitType.First), AddOffset,ExtractAs.Local,false,"]");
await ExtractOffsetFromString(XFunction,"TCP_Current_Table_Data", ("].f_2[iLocal_", ExtractSplitType.First) ,("Local_", ExtractSplitType.Last), I =>AddOffset.Invoke(I.Replace("iParam0","TCP_Current_Table")),ExtractAs.Local,false,"].f_2");
}),
#endregion

};


}}