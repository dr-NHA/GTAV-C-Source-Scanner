using System;
using System.Collections.Generic;
using System.Net;

namespace NHA_Github{

/// <summary>
/// Preset Webclient Setups To Make Your Other Code As Clean As Possible!
/// </summary>
public static class NHA_WebClient{
        
/// <summary>
/// Download String Data From A URL Within This Process!
/// </summary>
/// <param name="Address"></param>
/// <param name="OnCompleted"></param>
public static void DownloadStringFromAddress(string Address, Action<string> OnCompleted){
WebClient CLIENT = new WebClient();
CLIENT.DownloadStringCompleted += (X, E) => {
OnCompleted.Invoke(E.Result);
CLIENT.DisposeEX();
};
CLIENT.DownloadStringAsync(new Uri(Address));
}

        
/// <summary>
/// Download String Array Data From A URL Within This Process!
/// </summary>
/// <param name="Address"></param>
/// <param name="OnCompleted"></param>
public static void DownloadStringArrayFromAddress(string Address, Action<string[]> OnCompleted){
WebClient CLIENT = new WebClient();
CLIENT.DownloadStringCompleted += (X, E) => {
var RES=new List<string>();
foreach(string R in E.Result.Replace("\r","").Split('\n')) 
if(R.Trim().Length>0)
RES.Add(R.Trim());
OnCompleted.Invoke(RES.ToArray());
CLIENT.DisposeEX();
};
CLIENT.DownloadStringAsync(new Uri(Address));
}
        
/// <summary>
/// Download String Array Data From A URL Within This Process!
/// </summary>
/// <param name="Address"></param>
/// <param name="OnCompleted"></param>
public static void DownloadByteArrayFromAddress(string Address, Action<byte[]> OnCompleted){
WebClient CLIENT = new WebClient();
CLIENT.DownloadDataCompleted += (X, E) => {
OnCompleted.Invoke(E.Result);
CLIENT.DisposeEX();
};
CLIENT.DownloadDataAsync(new Uri(Address));
}


/// <summary>
/// Extended Dispose Function (Add Extra Data In Here If You Want)
/// </summary>
/// <param name="CLIENT"></param>
private static void DisposeEX(this WebClient CLIENT) {
CLIENT.Dispose();
GC.Collect(GC.GetGeneration(CLIENT));
CLIENT = null;
}


}}