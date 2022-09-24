using System.Windows.Forms;
using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class gb_casino_heist_planning : C_ScriptFile{
public string FileName=> ("gb_casino_heist_planning" + ".c").ToLower();
public void PreScan(){
            CasinoCutBase = "";
} 

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {
//MessageBox.Show(XFunction,FileName+ " EntryFunction:");
#region Entry_CasinoCutBase
await ExtractOffsetFromString(XFunction, "CasinoCutBase", ("Global_", ExtractSplitType.Last), (")", ExtractSplitType.First), (X)=> { CasinoCutBase = X; AddOffset(X); }, ExtractAs.Global,false);   
//MessageBox.Show(CasinoCutBase, FileName + " CasinoCutBase:");
#endregion

});

private string CasinoCutBase = "";

public ScanPreset[] GetVoids=>new[] {

#region CasinoCut
new ScanPreset("CasinoCut_Function",new string[]{
"var uParam0){\nint iVar0;\nint iVar1;\nswitch (uParam0->",
"){\ncase 1:\nif(uParam0->f_"
 },async (XFunction) => {
if(CasinoCutBase=="")
for(; ; )
if(CasinoCutBase!="")
break;
else
await System.Threading.Tasks.Task.Delay(100);  
await ExtractOffsetFromString(XFunction, "CasinoCut", ("=uParam0->", ExtractSplitType.Last), ("[", ExtractSplitType.First),
(X)=>AddOffset(X.Split(':')[0].Trim()+": "+(CasinoCutBase.Split(':')[1].Trim())+"."+(X.Split(':')[1].Trim())+"[1+iVar0*1]"), ExtractAs.Offset,false);
}),
#endregion

};

public ScanPreset[] GetChars=>null;

public ScanPreset[] GetInts=> null;


}}