using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class fmmc_launcher : C_ScriptFile{
public string FileName=> ("fmmc_launcher" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{
#region apartment_cut
new ScanPreset("apartment_cut",new[]{
"(1);\niVar3=iVar2;\nAUDIO::PLAY_SOUND_FRONTEND(-1, "+'"'.ToString()+"Highlight_Move"+'"'.ToString()+", "+'"'.ToString()+"DLC_HEIST_PLANNING_BOARD_SOUNDS"+'"'.ToString()+",",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"apartment_cut", ("&(Global_", ExtractSplitType.Forth) ,(")", ExtractSplitType.First), (X)=>AddOffset(X.Replace("[","[1+").Replace("]","*1]")),ExtractAs.Global,false);
}),
#endregion

};

public ScanPreset[] GetChars => null;

public ScanPreset[] GetInts=> null;

}}