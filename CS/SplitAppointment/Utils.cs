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
using System.Text;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;
using DevExpress.XtraScheduler;

namespace SplitAppointment {
    public class ResourceFiller {
        public static string[] Users = new string[] { "Sarah Brighton", "Ryan Fischer", "Andrew Miller" };
        public static string[] Usernames = new string[] { "sbrighton", "rfischer", "amiller" };

        public static void FillResources(SchedulerStorage storage, int count) {
            ResourceCollection resources = storage.Resources.Items;
            storage.BeginUpdate();
            try {
                int cnt = Math.Min(count, Users.Length);
                for (int i = 1; i <= cnt; i++) {
                    resources.Add(new Resource(Usernames[i - 1], Users[i - 1]));
                }
            }
            finally {
                storage.EndUpdate();
            }
        }
    }
}
