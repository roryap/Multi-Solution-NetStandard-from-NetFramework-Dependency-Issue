namespace SecondSln.NetFrameworkConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var c = new SecondSln.NetFrameworkClassLibrary.NetFrameworkCustomClass();
			string r = c.GetRegistryValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework", "InstallRoot");
		}
	}
}
