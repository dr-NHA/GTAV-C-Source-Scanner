using System;

namespace NHA_Github{
public static class Downloading{
        
/// <summary>
/// The Base Url For Github User Content (RAW)
/// </summary>
public static string RawGithubUserContentUrl { get; } ="https://raw.githubusercontent.com";

/// <summary>
/// Generate A URL For Raw Github User Content Based On The Inputs
/// </summary>
/// <param name="UserName"></param>
/// <param name="Repository"></param>
/// <param name="Branch"></param>
/// <param name="FileName"></param>
/// <returns></returns>
public static string RawGithubUserContent(string UserName,string Repository,string Branch,string FileName) =>
$"{RawGithubUserContentUrl}/{UserName}/{Repository}/{Branch}/{FileName}";

/// <summary>
/// Download (String) From A Github Raw User Content Address
/// </summary>
/// <param name="ContentAddress"></param>
/// <param name="OnCompleted"></param>
public static void DownloadStringGithubUserContent((string UserName, string Repository, string Branch, string FileName) ContentAddress, Action<string> OnCompleted)=>NHA_WebClient.
DownloadStringFromAddress(RawGithubUserContent(ContentAddress.UserName, ContentAddress.Repository, ContentAddress.Branch, ContentAddress.FileName), OnCompleted);

/// <summary>
/// Download (String[]) From A Github Raw User Content Address
/// </summary>
/// <param name="ContentAddress"></param>
/// <param name="OnCompleted"></param>
public static void DownloadStringArrayGithubUserContent((string UserName, string Repository, string Branch, string FileName) ContentAddress, Action<string[]> OnCompleted)=>NHA_WebClient.
DownloadStringArrayFromAddress(RawGithubUserContent(ContentAddress.UserName, ContentAddress.Repository, ContentAddress.Branch, ContentAddress.FileName), OnCompleted);

/// <summary>
/// Download (String[]) From A Github Raw User Content Address
/// </summary>
/// <param name="ContentAddress"></param>
/// <param name="OnCompleted"></param>
public static void DownloadByteArrayGithubUserContent((string UserName, string Repository, string Branch, string FileName) ContentAddress, Action<byte[]> OnCompleted)=>NHA_WebClient.
DownloadByteArrayFromAddress(RawGithubUserContent(ContentAddress.UserName, ContentAddress.Repository, ContentAddress.Branch, ContentAddress.FileName), OnCompleted);


}
}
