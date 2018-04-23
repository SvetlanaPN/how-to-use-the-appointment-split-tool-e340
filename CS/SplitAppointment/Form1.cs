using System;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;

namespace SplitAppointment {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();

            schedulerControl.Start = DateTime.Now.Date;
            schedulerControl.ActiveViewType = SchedulerViewType.Day;
            schedulerControl.Views.DayView.DayCount = 3;
            schedulerControl.DayView.TopRowTime = schedulerControl.DayView.WorkTime.Start;
        }
        #region SchedulerControlPreparePopupMenu
        void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu) {
                SplitAppointmentOperationCommand command = new SplitAppointmentOperationCommand(schedulerControl);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter = new SchedulerMenuItemCommandWinAdapter(command);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem();
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);
        }
        }
        #endregion
        #region barBtnGroupByNone_ItemClick
        void barBtnGroupByNone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            schedulerControl.GroupType = SchedulerGroupType.None;
        }
        #endregion
        #region barBtnGroupByDate_ItemClick
        void barBtnGroupByDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            schedulerControl.GroupType = SchedulerGroupType.Date;
        }
        #endregion
        #region barBtnGroupByResource_ItemClick
        void barBtnGroupByResource_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            schedulerControl.GroupType = SchedulerGroupType.Resource;
        }
        #endregion
        #region MainForm_Load
        private void MainForm_Load(object sender, EventArgs e) {
            InitData();
        }
        #endregion
        #region InitData
        void InitData() {
            ResourceBaseCollection resources = schedulerStorage.Resources.Items;
            if (resources.Count <= 0) {
                resources.Add(new Resource(0, "Andrew Fuller"));
                resources.Add(new Resource(1, "Nancy Davolio"));
                resources.Add(new Resource(2, "Janet Leverling"));
                resources.Add(new Resource(3, "Margaret Peacock"));
                int count = xpCollectionResources.Count;
                for (int i = 0; i < count; i++) {
                    XPObject o = (XPObject)xpCollectionResources[i];
                    o.Save();
                }
            }

            if (schedulerStorage.Appointments.Count == 0) {

                schedulerStorage.BeginUpdate();

                Appointment aptPattern = schedulerStorage.CreateAppointment(AppointmentType.Pattern);
                DateTime curHour = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
                aptPattern.Start = curHour.AddDays(-2);
                aptPattern.End = aptPattern.Start.AddHours(2);
                aptPattern.RecurrenceInfo.Start = aptPattern.Start;
                aptPattern.Subject = "Test Appointment To Split";
                aptPattern.Description = "Again and again...";
                aptPattern.ResourceId = schedulerStorage.Resources[0].Id;
                aptPattern.StatusId = (int)AppointmentStatusType.Busy;
                aptPattern.LabelId = 1;
                aptPattern.RecurrenceInfo.Type = RecurrenceType.Daily;
                aptPattern.RecurrenceInfo.Periodicity = 2;
                aptPattern.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
                aptPattern.RecurrenceInfo.OccurrenceCount = 10;
                schedulerControl.Storage.Appointments.Add(aptPattern);

                schedulerStorage.EndUpdate();

            }



        }
        #endregion
        #region OnAppointmentCollectionChanged
        private void OnAppointmentCollectionChanged(object sender, PersistentObjectsEventArgs e) {
            foreach (Appointment apt in e.Objects) {
                XPBaseObject o = apt.GetSourceObject(schedulerStorage) as XPBaseObject;
                if (o != null)
                    o.Save();
            }
        }
        #endregion
    }
}