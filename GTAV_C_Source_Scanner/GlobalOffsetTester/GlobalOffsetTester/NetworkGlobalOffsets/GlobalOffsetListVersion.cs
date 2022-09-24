namespace GlobalOffsetTester.NetworkGlobalOffsets{
public class GlobalOffsetListVersion { 
private (string,string) DATA;
public string Version => DATA.Item1;
public string Build => DATA.Item2;
public GlobalOffsetListVersion(string Version,string Build) =>
DATA=(Version, Build);        
}}