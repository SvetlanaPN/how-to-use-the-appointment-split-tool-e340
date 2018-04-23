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
                    resources.Add(storage.CreateResource(Usernames[i - 1], Users[i - 1]));
                }
            }
            finally {
                storage.EndUpdate();
            }
        }
    }
}
