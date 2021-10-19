using HumanResources.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResources
{
	static class Program
	{
		//public static readonly FileSerializer<List<Employee>> SerializeToFile = new FileSerializer<List<Employee>>(SerializeMode.XML, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileXml));
		public static readonly FileSerializer<List<Employee>> SerializeToFile = new FileSerializer<List<Employee>>(SerializeMode.JSON, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileJson));

		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
