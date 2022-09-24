using System;
using System.Linq;
using System.Threading.Tasks;
using static NHA_CScript.Utilities;

namespace NHA_CScript.OffsetDefs{
public class freemode:C_ScriptFile{
 public string FileName => ("Freemode" + ".c").ToLower();
public void PreScan(){
PlayerSessionBlank_Func="";
}

public ScanPreset GetEntryFunction => new ScanPreset("EntryFunction",new string[]{},async (XFunction) => {

});
        
private string PlayerSessionBlank_Func="";
        
Action<string> AddOffset_T=(I)=>{
if(I.Contains('=')){I=I.Split('=')[0]; }
AddOffset.Invoke(I.Replace("bVar0","PlayerID"));
};


public ScanPreset[] GetVoids=>new []{
    //new ScanPreset("THIS IS A FALSE MESSAGE",new[]{"EASY NHA SCRIPT SCANNER V1",},async (XFunction) => {}),

#region Stat_Set_Int
new ScanPreset("STAT_SET_INT",new[]{
"var uVar0;\nint iVar1;\nuVar0=Global_",
"[iParam0];\niVar1=uVar0;\nSTATS::STAT_SET_INT(iVar1, iParam1,"},
async (XFunction) => await ExtractOffsetFromString(XFunction, "STAT_SET_INT", ("Global_", ExtractSplitType.Last) ,("[", ExtractSplitType.First),AddOffset,ExtractAs.Global,false)),
#endregion

#region Stat_Set_Int_Hash
new ScanPreset("Stat_Set_Int_Hash",new[]{
"iVar1=9;\nif(!HUD::HAS_THIS_ADDITIONAL_TEXT_LOADED(\"MPAWD\",",
"HUD::REQUEST_ADDITIONAL_TEXT(\"MPAWD\",",
"if(HUD::HAS_THIS_ADDITIONAL_TEXT_LOADED(\"MPAWD\",",
"break;\ncase 3:\nif(Global_"},
async (XFunction) =>{
var PARAM=XFunction.Replace("break;\ncase 3:\nif(Global_","@").Split('@')[1].Replace("func_","@").Split('@')[1];
await ExtractOffsetFromString(XFunction, "Stat_Set_Int_Hash", ("break;\ncase 3:\nif(Global_", ExtractSplitType.Second) ,("!=", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(PARAM, "Stat_Set_Int_Param", ("(", ExtractSplitType.Second) ,(")", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion



    #region PlayerSessionBlank_Func
    ///Used For Finding The Base Function Index/Name That Handles The PlayerSessionBlank !
    new ScanPreset("PlayerSessionBlank_Func",new[]{"NETWORK::NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID(bVar3)",},
async (XFunction) => {
await ExtractOffsetFromString(XFunction, "PlayerSessionBlank_Func", ("func_", ExtractSplitType.Last) ,("(", ExtractSplitType.First),(X)=>{
AddOffset(X.Replace("Global_","func_"));
PlayerSessionBlank_Func="func_"+(X.Split('_').Last().Trim());
//MessageBox.Show(PlayerSessionBlank_Func,"PlayerSessionBlank_Func");
},ExtractAs.Global,false);
}),
#endregion

#region Pickup Spawn
new ScanPreset("MainPickupSpawnFunction",new[]{
"MISC::IS_BIT_SET",
"MISC::CLEAR_BIT",
"MONEY::NETWORK_SPENT_CASH_DROP",
"DECORATOR::DECOR_IS_REGISTERED_AS_TYPE",
"cashondeadbody"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction, "MainPickupOffset", (")==2){", ExtractSplitType.First) ,("(", ExtractSplitType.Last), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "PickupSpawnOffset", ("MISC::CLEAR_BIT(&", ExtractSplitType.Last) ,(",", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
new ScanPreset("PickupiParamFunction",new[]{
"MONEY::_NETWORK_EARN_FROM_ARENA_CAREER_PROGRESSION(iVar0, iParam0)",
"iVar0=func_",
"int iVar0;",
"int iVar1;",
"=iParam0;"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction, "PickupiParamOffset", ("Global_", ExtractSplitType.Second) ,("[", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region oVMCreate oVMYCar
new ScanPreset("VehicleCreateFunction",new[]{
"if(!STREAMING::HAS_MODEL_LOADED(Global_",
"STREAMING::REQUEST_MODEL(Global_",
"struct<31> Var1;",
"struct<3> Var37;",
"var uVar40;",
"STREAMING::SET_MODEL_AS_NO_LONGER_NEEDED(Global_",
"SYSTEM::VDIST(Var37, Global_",
"NETWORK::NETWORK_HAS_CONTROL_OF_ENTITY(NETWORK::NET_TO_VEH(Global_",
"VEHICLE::SET_VEHICLE_DOORS_LOCKED(NETWORK::NET_TO_VEH(Global_"
},async (XFunction) => {
await ExtractOffsetFromString(XFunction, "oVMCreate", ("STREAMING::REQUEST_MODEL(Global_", ExtractSplitType.Last) ,(".", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "oVMYCar", ("\n};\nGlobal_", ExtractSplitType.Last) ,(".", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region oVGETIn
new ScanPreset("VehicleGetInFunction",new[]{
"=iParam0;\nif(NETWORK::NETWORK_IS_GAME_IN_PROGRESS()){\nGlobal_",
"==iParam0){",
"if(!Global_",
"=NETWORK::GET_NETWORK_TIME();"
},async(XFunction) => {
await ExtractOffsetFromString(XFunction, "oVGETIn", ("if(!Global_", ExtractSplitType.Second) ,("==", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region Afk Script
new ScanPreset("AFK_Function",new[]{
"AUDIO::PLAY_SOUND_FRONTEND",
"MP_IDLE_TIMER",
"HUD_FRONTEND_DEFAULT_SOUNDSET",
"HUD::THEFEED_FORCE_RENDER_ON()",
"HUD::THEFEED_RESUME()"
},async(XFunction) => {
int Offset=1+(!XFunction.Contains("STATS::PLAYSTATS_IDLE_KICK") ? 4:0);
await ExtractOffsetFromString(XFunction, "AFKOffset"+Offset, ("iVar1=(Global_", ExtractSplitType.Second) ,("*", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
Offset++;
await ExtractOffsetFromString(XFunction, "AFKOffset"+Offset, ("iVar2=(Global_", ExtractSplitType.Second) ,("*", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
Offset++;
await ExtractOffsetFromString(XFunction, "AFKOffset"+Offset, ("iVar3=(Global_", ExtractSplitType.Second) ,("*", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
Offset++;
await ExtractOffsetFromString(XFunction, "AFKOffset"+Offset, ("iVar4=(Global_", ExtractSplitType.Second) ,("*", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region GetPlayerXP GetPlayerLevel
new ScanPreset("GetPlayerLevelAndXP_Function",new[]{
"STATS::PLAYSTATS_AWARD_XP(iParam0, -523908350, iParam1);",
"STATS::PLAYSTATS_AWARD_XP(bParam0, -1158693853, -1345423847);",
"STATS::PLAYSTATS_AWARD_XP(bParam0, -1586921397, iParam1);",
"(-1)]=bParam0;",
"(-1109644434, 7, ",
"(PLAYER::PLAYER_ID())",
},async (XFunction) => {
var REGION=XFunction.Replace("@","").Replace("(PLAYER::PLAYER_ID())","@").Split('@')[1];
await ExtractOffsetFromString(REGION, "GetPlayerLevel", ("(bParam0,", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last),X=>AddOffset(X.Split('=')[0]),ExtractAs.Global,true);
await ExtractOffsetFromString(REGION, "GetPlayerXP", ("=bParam0;", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last),X=>AddOffset(X.Split('=')[0]),ExtractAs.Global,true);
}),
#endregion

#region CASINO: Casino_Chips_Purchased Casino_Chips_Won Trigger_Casino_Member_Bonus
new ScanPreset("FreemodeCasino_Function",new[]{
"joaat(\"mpply_casino_chips_purtim\")",
"joaat(\"mpply_casino_chips_pur_gd\")",
"joaat(\"mpply_casino_chips_wontim\")",
"joaat(\"mpply_casino_chips_won_gd\")",
"joaat(\"mpply_casino_mem_bonus\")",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction.Replace("@","").Replace("joaat(\"mpply_casino_chips_purtim\")","@").Split('@')[0].Split('>').Last(),
"Casino_Chips_Purchased", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await
ExtractOffsetFromString(XFunction.Replace("@","").Replace("joaat(\"mpply_casino_chips_wontim\")","@").Split('@')[0].Split('>').Last(),
"Casino_Chips_Won", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await
ExtractOffsetFromString(XFunction.Replace("@","").Replace("joaat(\"mpply_casino_mem_bonus\")","@").Split('@')[1],
"Trigger_Casino_Member_Bonus", ("Global_", ExtractSplitType.Second) ,("=", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region Spawn Mini RC's
new ScanPreset("SpawnMiniRcs_Function",new[]{
", joaat(\"rcbandito\"),",
", joaat(\"minitank\"),",
},
async (XFunction) => {await
ExtractOffsetFromString(XFunction, "spawn_rcbandito", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction.Replace("@","").Replace("joaat(\"rcbandito\"),","@").Split('@')[1], 
"spawn_minitank", ("Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region LocalPlayerGameOffsets
new ScanPreset("LocalPlayerGame_Function",new[]{
"(int iParam0, int iParam1){",
"iParam0, iParam1, joaat(",
"), &(Global_",
"=100;",
"CASH_REWARD_BET_STAKE_GIFT",
"toggle_on_bet_stake_gift_DM",
"toggle_on_bet_stake_gift_RACES_CAR",
"toggle_on_bet_stake_gift_RACES_CYCLE",
"toggle_on_bet_stake_gift_RACES_AIR",
"toggle_on_bet_stake_gift_RACES_SEA",
"PLAYLIST_EVENT_GIFT_ACTIVE"},
async (XFunction) => {await
ExtractOffsetFromString(XFunction, "LocalPlayerGameOffsets", ("Global_", ExtractSplitType.Second) ,(".", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region MaxTransaction_Main
new ScanPreset("MaxTransaction_Main_Function",new[]{
"struct<14> Var27;",
"struct<14> Var41;",
"int iVar55;",
"if(uParam1->f_1 !=123){\nif(((((MISC::IS_BIT_SET(Global_",
"PLAYER::GET_PLAYER_MAX_ARMOUR(PLAYER::PLAYER_ID()), 100) * 20f)",
"iVar8=iVar7;\nPED::SET_PED_ARMOUR(PLAYER::PLAYER_PED_ID(), iVar8);",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "MaximumMoneyPickupValue", ("iVar18=uParam1->f_2;\nif(iVar18 > Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "MaximumMoneyTransactionValue", ("uParam1->f_2;\n}\nif(iVar16 > Global_", ExtractSplitType.Second) ,(")", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region MAX_NUM_NETWORK_STUFF & IsCurrentWorldNetworked
new ScanPreset("MainNetwork_Function",new[]{
"NETWORK::GET_NUM_RESERVED_MISSION_PEDS(true, 0)",
"NETWORK::GET_NUM_RESERVED_MISSION_VEHICLES(true, 0)",
"NETWORK::GET_NUM_RESERVED_MISSION_OBJECTS(true, 0)",
"if(MISC::IS_BIT_SET(Global_",
"MISC::CLEAR_BIT(&Global_",
"NETWORK::GET_MAX_NUM_NETWORK_PEDS()",
"NETWORK::GET_MAX_NUM_NETWORK_VEHICLES()",
"NETWORK::GET_MAX_NUM_NETWORK_OBJECTS()",
"NETWORK::GET_MAX_NUM_NETWORK_PICKUPS()",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "IsCurrentWorldNetworked", ("if(MISC::IS_BIT_SET(Global_", ExtractSplitType.Second) ,(",", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "MAX_NUM_NETWORK_PEDS", ("=NETWORK::GET_MAX_NUM_NETWORK_PEDS()", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "MAX_NUM_NETWORK_VEHICLES", ("=NETWORK::GET_MAX_NUM_NETWORK_VEHICLES()", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "MAX_NUM_NETWORK_OBJECTS", ("=NETWORK::GET_MAX_NUM_NETWORK_OBJECTS()", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last), AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "MAX_NUM_NETWORK_PICKUPS", ("=NETWORK::GET_MAX_NUM_NETWORK_PICKUPS()", ExtractSplitType.First) ,("Global_", ExtractSplitType.Last), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region PlayerIndex
new ScanPreset("PlayerIndex_Function",new[]{
"while",
"iVar0 <=1",
"[iVar0]=func_",
"mpply_last_mp_char",
"bVar1=Global_",
"STATS::PLAYSTATS_AWARD_XP",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "PlayerIndex", ("}\nGlobal_", ExtractSplitType.Second) ,("=func_", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region GetPlayerOrganizationName
new ScanPreset("GetPlayerOrganizationName_Function",new[]{
"FM_BOSSINTROH",
"FMBOSSINTROHC",
"FM_GB_INTRO_MC",
"Player_Goon",
"Player_Boss",
"HUD::CLEAR_HELP",
"PLAYER::SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(PLAYER::PLAYER_ID(), 1f);",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "GetPlayerOrganizationName", ("StringCopy(&(Global_", ExtractSplitType.Last) ,("),", ExtractSplitType.First),AddOffset,ExtractAs.Global,true);
}),
#endregion

#region GetPlayerOrganizationColour
new ScanPreset("GetPlayerOrganizationColour_Function",new[]{
"(PLAYER::PLAYER_ID());\nif(!iVar0==-1){\niVar1=func_",
},async (XFunction) => {
await ExtractOffsetFromString(XFunction.Replace("@","").Replace("iVar1;","@").Split('@').Last(), "GetPlayerOrganizationColour", ("Global_", ExtractSplitType.Second) ,("=", ExtractSplitType.First),AddOffset,ExtractAs.Global,true);
}),
#endregion

#region GetPlayerData
new ScanPreset("GetPlayerData_Function",new[]{
"mpply_kill_death_ratio",
"mpply_kills_players",
"mpply_deaths_player",
"mpply_deaths_player_suicide",
"mpply_total_races_won",
"mpply_total_deathmatch_lost",
"mpply_most_favorite_station",
"mpply_can_spectate",
"mpply_crhorde",
},async (XFunction) => {
var CASE=XFunction.Replace("@","").Replace("*uParam0++;\nbreak;\ncase","@").Split('@');
if(CASE.Length>=9){
async Task EXT(string Case,string E)=>await ExtractOffsetFromString(Case, E, ("\nGlobal_", ExtractSplitType.Second) ,("=func_", ExtractSplitType.First),AddOffset_T,ExtractAs.Global,true);
var DB2=CASE[1];
await EXT(DB2,"GetPlayerKillDeathRatio");DB2=DB2.Replace("-1, 0);","@").Split('@').Last();
await EXT(DB2, "GetPlayerKillsCount");DB2=DB2.Replace("mpply_kills_players","@").Split('@').Last();
await EXT(DB2, "GetPlayerDeathsCount");

DB2=CASE[2];
await EXT(DB2, "GetPlayerTotalRacesWon");DB2=DB2.Replace("mpply_total_races_won","@").Split('@').Last();
await EXT(DB2, "GetPlayerTotalRacesLost");DB2=DB2.Replace("mpply_total_races_lost","@").Split('@').Last();
await EXT(DB2, "GetPlayerTimesFinishRaceTop3");DB2=DB2.Replace("mpply_times_finish_race_top_3","@").Split('@').Last();
await EXT(DB2, "GetPlayerTimesFinishRaceLast");DB2=DB2.Replace("mpply_times_finish_race_last","@").Split('@').Last();
await EXT(DB2, "GetPlayerTimesRaceBestLap");DB2=DB2.Replace("mpply_times_race_best_lap","@").Split('@').Last();

DB2=CASE[3];
await EXT(DB2, "GetPlayerTotalDeathmatchWon");DB2=DB2.Replace("mpply_total_deathmatch_won","@").Split('@').Last();
await EXT(DB2, "GetPlayerTotalDeathmatchLost");DB2=DB2.Replace("mpply_total_deathmatch_lost","@").Split('@').Last();
await EXT(DB2, "GetPlayerTotalTeamDeathmatchWon");DB2=DB2.Replace("mpply_total_tdeathmatch_won","@").Split('@').Last();
await EXT(DB2, "GetPlayerTotalTeamDeathmatchLost");DB2=DB2.Replace("mpply_total_tdeathmatch_lost","@").Split('@').Last();
await EXT(DB2, "GetPlayerTimesFinishDmTop3");DB2=DB2.Replace("mpply_times_finish_dm_top_3","@").Split('@').Last();
await EXT(DB2, "GetPlayerTimesFinishDmLast");DB2=DB2.Replace("mpply_times_finish_dm_last","@").Split('@').Last();

DB2=CASE[4];
await EXT(DB2, "GetPlayerDartsTotalWon");DB2=DB2.Replace("mpply_darts_total_wins","@").Split('@').Last();
await EXT(DB2, "GetPlayerDartsTotalMatches");DB2=DB2.Replace("mpply_darts_total_matches","@").Split('@').Last();
await EXT(DB2, "GetPlayerArmWrestlingTotalWins");DB2=DB2.Replace("mpply_armwrestling_total_wins","@").Split('@').Last();
await EXT(DB2, "GetPlayerArmWrestlingTotalMatches");DB2=DB2.Replace("mpply_armwrestling_total_match","@").Split('@').Last();
await EXT(DB2, "GetPlayerTennisMatchesWon");DB2=DB2.Replace("mpply_tennis_matches_won","@").Split('@').Last();
await EXT(DB2, "GetPlayerTennisMatchesLost");DB2=DB2.Replace("mpply_tennis_matches_lost","@").Split('@').Last();
await EXT(DB2, "GetPlayerBjWins");DB2=DB2.Replace("mpply_bj_wins","@").Split('@').Last();
await EXT(DB2, "GetPlayerBjLost");DB2=DB2.Replace("mpply_bj_lost","@").Split('@').Last();

DB2=CASE[5];
await EXT(DB2, "GetPlayerGolfWins");DB2=DB2.Replace("mpply_golf_wins","@").Split('@').Last();
await EXT(DB2, "GetPlayerGolfLosses");DB2=DB2.Replace("mpply_golf_losses","@").Split('@').Last();
await EXT(DB2, "GetPlayerShootingRangeWins");DB2=DB2.Replace("mpply_shootingrange_wins","@").Split('@').Last();
await EXT(DB2, "GetPlayerShootingRangeLosses");DB2=DB2.Replace("mpply_shootingrange_losses","@").Split('@').Last();
DB2=DB2.Replace("(70, -1, 0)","@").Split('@').Last();
await EXT(DB2, "GetPlayerHordeWins");DB2=DB2.Replace("mpply_hordewins","@").Split('@').Last();
await EXT(DB2, "GetPlayerCrHorde");DB2=DB2.Replace("mpply_crhorde","@").Split('@').Last();
await EXT(DB2, "GetPlayerMcmWin");DB2=DB2.Replace("mpply_mcmwin","@").Split('@').Last();
await EXT(DB2, "GetPlayerCrMission");DB2=DB2.Replace("mpply_crmission","@").Split('@').Last();

DB2=CASE[7];
await EXT(DB2, "GetPlayerMissionsCreated");DB2=DB2.Replace("mpply_missions_created","@").Split('@').Last();
await EXT(DB2, "GetPlayerDropOutRate");DB2=DB2.Replace("StringCopy","@").Split('@').Last();
await EXT(DB2, "GetPlayerCanSpectate");DB2=DB2.Replace("mpply_can_spectate","@").Split('@').Last();

//DB2=CASE[9];
//await EXT(DB2, "GetPlayerMostFavoriteStation");
    }
}),
#endregion
};



public ScanPreset[] GetChars=>null;

public ScanPreset[] GetInts => new []{

#region PlayerSessionBlank
new ScanPreset("PlayerSessionBlank_Function",new[]{
"{\nreturn Global_",
";\n}",
},async (XFunction) => {
//Wait For The PlayerSessionBlank To Be Found!
for(; ; ){
if(PlayerSessionBlank_Func!=""){
if((XFunction).StartsWith("int "+PlayerSessionBlank_Func)){
//MessageBox.Show(XFunction,"PlayerSessionBlank_Func");
await ExtractOffsetFromString(XFunction, "PlayerSessionBlank", ("return Global_", ExtractSplitType.Second) ,(";", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}break; }else
await Task.Delay(50); 
}

}),
#endregion

#region oPlayerGA
new ScanPreset("oPlayerGA_Function",new[]{
"MISC::GET_DISTANCE_BETWEEN_COORDS(ENTITY::GET_ENTITY_COORDS(PLAYER::GET_PLAYER_PED(Global_",
"if(PED::IS_PED_IN_ANY_VEHICLE(PLAYER::GET_PLAYER_PED(Global_",
"if(PED::IS_PED_IN_ANY_VEHICLE(PLAYER::GET_PLAYER_PED(bParam0),",
"if(ENTITY::GET_ENTITY_SPEED(PLAYER::GET_PLAYER_PED(bParam0)) > 5f",
"if(!ENTITY::IS_ENTITY_DEAD(PLAYER::GET_PLAYER_PED(Global_",
"VEHICLE::IS_THIS_MODEL_A_PLANE(iVar2) || VEHICLE::IS_THIS_MODEL_A_HELI(iVar2)",
"PLAYER::IS_PLAYER_TARGETTING_ENTITY(PLAYER::PLAYER_ID(), PLAYER::GET_PLAYER_PED(bParam0)) || PLAYER::IS_PLAYER_FREE_AIMING_AT_ENTITY(PLAYER::PLAYER_ID(), PLAYER::GET_PLAYER_PED(bParam0))",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction.Replace("@","").Replace("VEHICLE::IS_THIS_MODEL_A_PLANE","@").Split('@')[1],
"oPlayerGA", ("if(Global_", ExtractSplitType.Second) ,("=", ExtractSplitType.First), AddOffset,ExtractAs.Global,false);
}),
#endregion

#region Set Self Model
new ScanPreset("SetSelfModel_Function",new[]{
"< MISC::GET_FRAME_COUNT())",
"!PED::HAS_PED_HEAD_BLEND_FINISHED(PLAYER::PLAYER_PED_ID()) || !PED::HAVE_ALL_STREAMING_REQUESTS_COMPLETED(PLAYER::PLAYER_PED_ID())",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "SetSelfModelTrigger", ("if(Global_", ExtractSplitType.Second) ,("!=0", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
await ExtractOffsetFromString(XFunction, "SetSelfModelHash", ("if(Global_", ExtractSplitType.Third) ,("!=0", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region IsHostPlayer
new ScanPreset("IsHostPlayer_Function",new[]{
"bool bParam0, bool bParam1, bool bParam2)",
"if(bParam1 !=",
"if(!bParam2){",
"(bParam0, bParam1)){",
"return bParam1==Global_",
"return 0;",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "IsHostPlayer", ("Global_", ExtractSplitType.Second) ,("!=func_", ExtractSplitType.First),X=>{ AddOffset.Invoke(X.Replace("bParam0","PlayerID")); },ExtractAs.Global,true);
}),
#endregion

#region GetPlayerWalletBalance
new ScanPreset("GetPlayerWalletBalance_Function",new[]{
"return MONEY::NETWORK_GET_VC_WALLET_BALANCE(-1);",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "GetPlayerWalletBalance", ("Global_", ExtractSplitType.Second) ,(";", ExtractSplitType.First),X=>{ AddOffset.Invoke(X.Replace("bParam0","PlayerID")); },ExtractAs.Global,false);
}),
#endregion

#region GetBusinessIndex
new ScanPreset("GetBusinessIndex_Function",new[]{
"bool bParam0, int iParam1)",
"if(NETWORK::NETWORK_IS_ACTIVITY_SESSION()){",
"return 1;",
"if(bParam0==",
"iVar0 <=5)",
"iVar0++;",
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "GetBusinessIndex", ("Global_", ExtractSplitType.Second) ,("!=0", ExtractSplitType.First),X=>{ AddOffset.Invoke(X.Replace("bParam0","PlayerID").Replace("iVar0","BusinessID")); },ExtractAs.Global,false);
}),
#endregion

#region IsTransactionErrorShown
new ScanPreset("IsTransactionErrorShown_Function",new[]{
"!NETSHOPPING::NET_GAMESERVER_IS_SESSION_VALID(func_",
"bool bVar0;",
"iParam7 & 4 !=0",
"iParam7 & 8 !=0",
"iParam7 & 2 !=0",
"NETSHOPPING::NET_GAMESERVER_BEGIN_SERVICE(&iVar4, iParam3, iParam4, iParam2, iParam5, iParam6)"
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "IsTransactionErrorShown", ("Global_", ExtractSplitType.Last) ,("=", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

#region oVMSlots
new ScanPreset("oVMSlots_Function",new[]{
"(PLAYER::PLAYER_ID()) || (CAM::IS_SCREEN_FADED_OUT() || STREAMING::IS_PLAYER_SWITCH_IN_PROGRESS())){",
"if(NETWORK::GET_TIME_DIFFERENCE(NETWORK::GET_NETWORK_TIME_ACCURATE(), Global_",
"if((NETWORK::GET_CLOUD_TIME_AS_INT() - Global_",
"if(NETWORK::CAN_REGISTER_MISSION_VEHICLES(1)){",
"if(!NETWORK::NETWORK_DOES_NETWORK_ID_EXIST("
},async (XFunction) => {await
ExtractOffsetFromString(XFunction, "oVMSlots", ("if(MISC::IS_BIT_SET(Global_", ExtractSplitType.Second) ,("[", ExtractSplitType.First),AddOffset,ExtractAs.Global,false);
}),
#endregion

};

}}