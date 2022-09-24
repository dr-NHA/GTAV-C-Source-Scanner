using System.Threading.Tasks;

namespace GlobalOffsetTester.NetworkGlobalOffsets{
public class GlobalOffsets { 
public GlobalOffset ShowAllOnMinimap= null;
public GlobalOffset LocalPlayerGameOffsets = null;
public GlobalOffset oVMCreate = null;
public GlobalOffset oVMYCar = null;
public GlobalOffset MainPickupOffset = null;
public GlobalOffset PickupSpawnOffset= null;
public GlobalOffset oVGETIn= null;
public GlobalOffset PickupiParamOffset= null;
public GlobalOffset AFKOffset5= null;
public GlobalOffset AFKOffset6= null;
public GlobalOffset AFKOffset7= null;
public GlobalOffset AFKOffset8= null;
public GlobalOffset AFKOffset1= null;
public GlobalOffset AFKOffset2= null;
public GlobalOffset AFKOffset3= null;
public GlobalOffset AFKOffset4= null;
public GlobalOffset MaximumMoneyPickupValue= null;
public GlobalOffset MaximumMoneyTransactionValue= null;
public GlobalOffset oVMSlots= null;
public GlobalOffset IsTransactionErrorShown= null;
public GlobalOffset SetSelfModelTrigger= null;
public GlobalOffset SetSelfModelHash= null;
public GlobalOffset BluePhoneType= null;
public GlobalOffset NG_filmnoir_BW= null;
public GlobalOffset TimeBetweenGoodSport= null;
public GlobalOffset GoodSportPayout= null;
public GlobalOffset IsPhoneOpen= null;
public GlobalOffset PlayerSessionNew = null;
public async Task Setup(NetworkGlobalOffsetList NGI) { 
ShowAllOnMinimap=await NGI.GetGlobalOffset("ShowAllOnMinimap");
LocalPlayerGameOffsets= await NGI.GetGlobalOffset("LocalPlayerGameOffsets");
oVMCreate= await NGI.GetGlobalOffset("oVMCreate");
oVMYCar= await NGI.GetGlobalOffset("oVMYCar");
MainPickupOffset= await NGI.GetGlobalOffset("MainPickupOffset");
PickupSpawnOffset= await NGI.GetGlobalOffset("PickupSpawnOffset");
oVGETIn= await NGI.GetGlobalOffset("oVGETIn");
PickupiParamOffset= await NGI.GetGlobalOffset("PickupiParamOffset");
AFKOffset5= await NGI.GetGlobalOffset("AFKOffset5");
AFKOffset6= await NGI.GetGlobalOffset("AFKOffset6");
AFKOffset7= await NGI.GetGlobalOffset("AFKOffset7");
AFKOffset8= await NGI.GetGlobalOffset("AFKOffset8");
AFKOffset1= await NGI.GetGlobalOffset("AFKOffset1");
AFKOffset2= await NGI.GetGlobalOffset("AFKOffset2");
AFKOffset3= await NGI.GetGlobalOffset("AFKOffset3");
AFKOffset4= await NGI.GetGlobalOffset("AFKOffset4");
MaximumMoneyPickupValue= await NGI.GetGlobalOffset("MaximumMoneyPickupValue");
MaximumMoneyTransactionValue= await NGI.GetGlobalOffset("MaximumMoneyTransactionValue");
oVMSlots= await NGI.GetGlobalOffset("oVMSlots");
IsTransactionErrorShown= await NGI.GetGlobalOffset("IsTransactionErrorShown");
SetSelfModelTrigger= await NGI.GetGlobalOffset("SetSelfModelTrigger");
SetSelfModelHash= await NGI.GetGlobalOffset("SetSelfModelHash");
BluePhoneType= await NGI.GetGlobalOffset("BluePhoneType");
NG_filmnoir_BW= await NGI.GetGlobalOffset("NG_filmnoir_BW");
TimeBetweenGoodSport= await NGI.GetGlobalOffset("TimeBetweenGoodSport");
GoodSportPayout= await NGI.GetGlobalOffset("GoodSportPayout");
IsPhoneOpen= await NGI.GetGlobalOffset("IsPhoneOpen");
PlayerSessionNew = await NGI.GetGlobalOffset("PlayerSessionNew");
}

}}