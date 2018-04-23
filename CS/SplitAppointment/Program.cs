// Developer Express Code Central Example:
// How to use the Appointment Split tool
// 
// This example illustrates the use of a new tool allowing end-users to split an
// appointment in two by simply dragging a splitter line. To accomplish this, use
// the DevExpress.XtraScheduler.Commands.SplitAppointmentOperationCommand class.
// Associate this command with the popup menu item in the PreparePopupMenu
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_PreparePopupMenutopic)
// event handler using the SchedulerMenuItemCommandWinAdapter. After that all you
// have to do is select the Split command from the appointment's context menu, drag
// the splitter to the required time and click the left mouse button. You can use
// the mouse wheel to adjust the splitter precision.
// See
// Also:
// http://www.devexpress.com/scid=K18126
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E340

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