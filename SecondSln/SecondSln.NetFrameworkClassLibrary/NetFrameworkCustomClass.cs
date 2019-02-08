namespace SecondSln.NetFrameworkClassLibrary
{
	public class NetFrameworkCustomClass
    {
		public string GetRegistryValue(string withKeyPath, string withValueName)
			=> new FirstSln.NetStandardClassLibrary.NetStandardCustomClass()
			.GetRegistryValue(withKeyPath, withValueName);
	}
}
