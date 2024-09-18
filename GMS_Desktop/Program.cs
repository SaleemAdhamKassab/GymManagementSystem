using GMS_Desktop.Login;

namespace GMS_Desktop
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			frmLoginScreen frmLogin = new frmLoginScreen();
			frmLogin.Show();
			Application.Run();
		}
	}
}