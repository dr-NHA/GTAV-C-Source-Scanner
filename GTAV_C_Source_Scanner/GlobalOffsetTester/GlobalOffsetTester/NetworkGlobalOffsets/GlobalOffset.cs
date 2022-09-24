namespace GlobalOffsetTester.NetworkGlobalOffsets{
public class GlobalOffset { 
private (string,string) DATA;
public string Name=>DATA.Item1;
public string Value=>DATA.Item2;
public GlobalOffset(string Name,string Value) =>
DATA=(Name,Value);        
}}