using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class heist_island_planning : C_ScriptFile{
public string FileName=> ("heist_island_planning" + ".c").ToLower();
public void PreScan(){
CayoCutBase = "";
} 

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {
#region Entry_CayoCutBase
var F = XFunction.Replace("@", "").Replace("func_", "@").Split('@');
await ExtractOffsetFromString(F[F.Length - 2], "CayoCutBase", ("Global_", ExtractSplitType.Second), (")", ExtractSplitType.First), (X)=> { CayoCutBase = X;AddOffset(X); 
}, ExtractAs.Global,false);
#endregion

});

private string CayoCutBase = "";

public ScanPreset[] GetVoids=>new[] {

#region CayoCut
new ScanPreset("CayoCut_Function",new string[]{
"var uParam0){\nint iVar0;\nuParam0->f_",
"(uParam0);\nswitch (uParam0->",
"){\ncase 1:\nuParam0->f_"
 },async (XFunction) => {
if(CayoCutBase=="")
for(; ; )
if(CayoCutBase!="")
break;
else
await System.Threading.Tasks.Task.Delay(100);  
await ExtractOffsetFromString(XFunction.Replace("@", "").Replace("){\ncase 1:", "@").Split('@')[1], "CayoCut", ("uParam0->", ExtractSplitType.Second), ("[", ExtractSplitType.First),
(X)=>AddOffset(X.Split(':')[0].Trim()+": "+(CayoCutBase.Split(':')[1].Trim())+"."+(X.Split(':')[1].Trim())+"[1+iVar0*1]"), ExtractAs.Offset,false);
}),
#endregion

};

public ScanPreset[] GetChars=>null;

public ScanPreset[] GetInts=> null;


}}