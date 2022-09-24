using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class maintransition:C_ScriptFile{
public string FileName=> ("maintransition" + ".c").ToLower();
public void PreScan(){

} 
        
public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction", new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new []{

#region TimeBetweenGoodSport GoodSportPayout
new ScanPreset("GoodSport_Function",new[]{
"if(NETWORK::NETWORK_IS_SIGNED_ONLINE()){",
"if((((!NETWORK::NETWORK_PLAYER_IS_BADSPORT() && !NETWORK::NETWORK_PLAYER_IS_CHEATER()) &&",
"mpply_totalplaytime_goodboy"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"TimeBetweenGoodSport", ("> Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction,"GoodSportPayout", ("(Global_", ExtractSplitType.Second) ,(",", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};
public ScanPreset[] GetChars=>null;

public ScanPreset[] GetInts=> new[] { 
    
#region IsPhoneOpen
new ScanPreset("IsPhoneOpen_Function",new[]{
"SCRIPT::_GET_NUMBER_OF_REFERENCES_OF_SCRIPT_WITH_NAME_HASH",
"cellphone_flashhand"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction,"IsPhoneOpen", ("Global_", ExtractSplitType.Second) ,(">", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};


}}