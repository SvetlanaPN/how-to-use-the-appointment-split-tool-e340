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
using DevExpress.Xpo;

namespace DevExpress.XtraScheduler.Examples {
	// XP object
	public class XPAppointment : XPObject {
		public XPAppointment(Session session) : base(session) { }
		public bool AllDay;              // Appointment.AllDay

		[Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
		public string Description;       // Appointment.Description

		public DateTime Finish;          // Appointment.End
		public int Label;                // Appointment.Label
		public string Location;          // Appointment.Location

		[Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
		public string Recurrence;        // Appointment.RecurrenceInfo

		[Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
		public string Reminder;          // Appointment.ReminderInfo

		public DateTime Start;         // Appointment.Start
		public int Status;               // Appointment.Status
		[Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
		public string Subject;           // Appointment.Subject
		public int AppointmentType;      // Appointment.Type

		public XPResource Resource;
	}

	// XP object
	public class XPResource : XPObject {
		public XPResource(Session session) : base(session) { }

		[Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
		public string Name;              // Resource.Caption

		//int Color;
		//Color Color;

		//[Size(SizeAttribute.Unlimited)]
		//Image Picture;
	}
}
