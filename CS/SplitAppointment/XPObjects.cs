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
