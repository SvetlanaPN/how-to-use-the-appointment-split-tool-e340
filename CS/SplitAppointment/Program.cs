using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;

namespace SplitAppointment {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			SkinManager.EnableFormSkins();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}