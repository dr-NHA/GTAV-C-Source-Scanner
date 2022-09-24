using System.Linq;
using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class fm_mission_controller : C_ScriptFile{
public string FileName=> ("fm_mission_controller" + ".c").ToLower();
public void PreScan(){

}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});

public ScanPreset[] GetVoids=>new[]{

#region NightclubCargo
new ScanPreset("NightclubCargo",new[]{
"=iParam1;\n}else{\nMISC::SET_RANDOM_SEED(NETWORK::GET_NETWORK_TIME());",
"=MISC::GET_RANDOM_INT_IN_RANGE(true, 14);\n}",
"\"Hit_Mirror\", \"dlc_xm_silo_laser_hack_sounds\",",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"NightclubCargo", ("Local_", ExtractSplitType.Second) ,("!", ExtractSplitType.First), AddOffset,ExtractAs.Local,false);
}),
    #endregion

#region CasinoHeistKeypadCrack
new ScanPreset("CasinoHeistKeypadCrack",new[]{
"STREAMING::REMOVE_ANIM_DICT(",
"mp_common_miss",
"TASK::CLEAR_PED_TASKS(bLocal_",
"GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(4);",
"heist",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction,"CasinoHeistKeypadCrack", ("(&Local_", ExtractSplitType.Last) ,(",", ExtractSplitType.First), AddOffset,ExtractAs.Local,false);
}),
    #endregion

#region FleecaHeist_VLSI_CircuitBreaker
new ScanPreset("FleecaHeist_VLSI_CircuitBreaker",new[]{
"!NETWORK::NETWORK_IS_PLAYER_A_PARTICIPANT(func_",
"Cheers",
"DLC_TG_Running_Back_Sounds",
"Whistle",
"if(PED::IS_PED_IN_ANY_VEHICLE(bLocal_",
"NETWORK::NETWORK_HAS_CONTROL_OF_ENTITY(PED::GET_VEHICLE_PED_IS_IN(bLocal_",
"VEHICLE::SET_VEHICLE_ENGINE_ON(PED::GET_VEHICLE_PED_IS_IN(bLocal_",
"GRAPHICS::DOES_PARTICLE_FX_LOOPED_EXIST(iLocal_",
"GRAPHICS::STOP_PARTICLE_FX_LOOPED(iLocal_",
"HUD::IS_SOCIAL_CLUB_ACTIVE()",
"HUD::CLOSE_SOCIAL_CLUB_MENU()",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction.Replace("@","").Replace("HUD::CLOSE_SOCIAL_CLUB_MENU()","@").Split('@').Last().Replace("MISC::IS_BIT_SET(","@").Split('@').First(),
"FleecaHeist_VLSI_CircuitBreaker", ("Local_", ExtractSplitType.Last) ,(",", ExtractSplitType.First),X=> AddOffset(X+".f_24"),ExtractAs.Local,false);
}),
#endregion

};

public ScanPreset[] GetChars=>null;


public ScanPreset[] GetInts=> null;


}}