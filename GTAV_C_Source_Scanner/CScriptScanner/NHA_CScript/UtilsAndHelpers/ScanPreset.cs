using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHA_CScript{
public class ScanPreset { 
private string _Name = "";
public string Name => _Name;
private string[] _Identifiers = { };
public string[] Identifiers =>  _Identifiers;
private Action<string> _OnIdentifiedFunction = null;
public Action<string> OnIdentifiedFunction =>  _OnIdentifiedFunction;
public static async Task<bool> CheckForScript(ScanPreset Preset,string Void_Func)=>await Utilities.CheckForScript(Void_Func, Preset.Identifiers, Preset.OnIdentifiedFunction);
public async Task<bool> CheckForScript(string Void_Func)=>await Utilities.CheckForScript(Void_Func, this.Identifiers, this.OnIdentifiedFunction);
public ScanPreset(string Name,string[] Identifiers,Action<string> OnIdentifiedFunction) {
_Name=Name;
_Identifiers = Identifiers;
_OnIdentifiedFunction = OnIdentifiedFunction;
}    
}
}
