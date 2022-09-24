using System.Collections.Generic;
using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
    
public interface C_ScriptFile {
/// <summary>
/// The File Name
/// </summary>
string FileName { get; }
/// <summary>
/// The Entry Function Scan Preset
/// </summary>
ScanPreset GetEntryFunction { get; }
/// <summary>
/// The Void Function Scan Presets
/// </summary>
ScanPreset[] GetVoids { get; }
/// <summary>
/// The Int Function Scan Presets
/// </summary>
ScanPreset[] GetInts { get; }
/// <summary>
/// The Char Function Scan Presets
/// </summary>
ScanPreset[] GetChars { get; }
/// <summary>
/// Do Something Before Scans Are Started
/// </summary>
void PreScan();
}

public static class ALL{
private static (string Key,C_ScriptFile Value) New_C_ScriptFile(C_ScriptFile Input) =>
(Input.FileName,Input);  


/// <summary>
/// The List Of CScripts
/// </summary>
public static Dictionary<string,C_ScriptFile> CScripts= null;
public static void FillDCScripts() {
if (CScripts == null) {
CScripts=new Dictionary<string, C_ScriptFile>();
(string Key,C_ScriptFile Value) X;
foreach (var C in new C_ScriptFile[] { 
new am_hold_up(),
new am_launcher(),
new am_pi_menu(),
new casino_slots(),
new fm_mission_controller(),
new fmmc_launcher(),
new freemode(),
new gb_casino_heist_planning(),
new heist_island_planning(),
new main(),
new maintransition(),
new pausemenu_multiplayer(),
new three_card_poker(),
new tuneables_processing(),
}){
X = New_C_ScriptFile(C);
CScripts.Add(X.Key,X.Value);
}
}
}

/// <summary>
/// Get A C_ScriptFile By Its Name (Null If Not Existant!)
/// </summary>
/// <param name="ScriptName"></param>
/// <returns></returns>
public static C_ScriptFile GetCScriptFromName(string ScriptName) {
if( CScripts.TryGetValue(ScriptName, out C_ScriptFile ScriptFile))
return ScriptFile;
return null;
}


}
    }
