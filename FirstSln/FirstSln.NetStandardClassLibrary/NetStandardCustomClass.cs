namespace FirstSln.NetStandardClassLibrary
{
	public class NetStandardCustomClass
	{
		public string GetRegistryValue(string withKeyPath, string withValueName) 
			=> Microsoft.Win32.Registry.GetValue(withKeyPath, withValueName, null)?.ToString() ?? "";
	}
}
