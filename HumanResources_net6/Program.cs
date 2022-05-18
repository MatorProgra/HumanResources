using HumanResources_net6.Forms;
using HumanResources_net6.Properties;

namespace HumanResources_net6
{
	internal static class Program
	{
		public static readonly FileSerializer<List<Employee>> SerializeToFile = new(SerializeMode.JSON, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileJson));

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Main());
		}
	}
}