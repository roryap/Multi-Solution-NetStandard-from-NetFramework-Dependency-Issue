namespace FirstSln.NetFrameworkClassLibrary
{
	public class NetFramworkCustomClass
	{
		public string GetRegistryValue(string withKeyPath, string withValueName)
			=> new FirstSln.NetStandardClassLibrary.NetStandardCustomClass().GetRegistryValue(withKeyPath, withValueName);
	}
}
