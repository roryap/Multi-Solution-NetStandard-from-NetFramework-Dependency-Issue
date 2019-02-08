namespace FirstSln.NetFrameworkConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var c1 = new NetStandardClassLibrary.NetStandardCustomClass();
			var c2 = new NetFrameworkClassLibrary.NetFramworkCustomClass();
			string c1RegValue = c1.GetRegistryValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework", "InstallRoot");
			string c2RegValue = c2.GetRegistryValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework", "InstallRoot");
		}
	}
}
