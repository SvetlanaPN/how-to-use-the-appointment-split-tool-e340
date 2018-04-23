using System;
namespace SplitAppointment {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.viewSelectorBar1 = new DevExpress.XtraScheduler.UI.ViewSelectorBar();
            this.viewSelectorItem1 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem2 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem3 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem4 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem5 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnGroupByNone = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGroupByDate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGroupByResource = new DevExpress.XtraBars.BarButtonItem();
            this.viewNavigatorBar1 = new DevExpress.XtraScheduler.UI.ViewNavigatorBar();
            this.viewNavigatorBackwardItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem();
            this.viewNavigatorForwardItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem();
            this.viewNavigatorTodayItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem();
            this.viewNavigatorZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem();
            this.viewNavigatorZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.xpCollectionAppointments = new DevExpress.Xpo.XPCollection();
            this.xpCollectionResources = new DevExpress.Xpo.XPCollection();
            this.viewSelector = new DevExpress.XtraScheduler.UI.ViewSelector(this.components);
            this.viewNavigator = new DevExpress.XtraScheduler.UI.ViewNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 26);
            this.schedulerControl.MenuManager = this.barManager;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(1067, 508);
            this.schedulerControl.Start = new System.DateTime(2008, 8, 7, 0, 0, 0, 0);
            this.schedulerControl.Storage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.PreparePopupMenu += new DevExpress.XtraScheduler.PreparePopupMenuEventHandler(this.SchedulerControlPreparePopupMenu);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.viewSelectorBar1,
            this.bar1,
            this.viewNavigatorBar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.viewSelectorItem1,
            this.viewSelectorItem2,
            this.viewSelectorItem3,
            this.viewSelectorItem4,
            this.viewSelectorItem5,
            this.viewNavigatorBackwardItem1,
            this.viewNavigatorForwardItem1,
            this.viewNavigatorTodayItem1,
            this.viewNavigatorZoomInItem1,
            this.viewNavigatorZoomOutItem1,
            this.barBtnGroupByNone,
            this.barBtnGroupByDate,
            this.barBtnGroupByResource});
            this.barManager.MaxItemId = 13;
            // 
            // viewSelectorBar1
            // 
            this.viewSelectorBar1.DockCol = 0;
            this.viewSelectorBar1.DockRow = 0;
            this.viewSelectorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.viewSelectorBar1.FloatLocation = new System.Drawing.Point(274, 207);
            this.viewSelectorBar1.FloatSize = new System.Drawing.Size(358, 26);
            this.viewSelectorBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSelectorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSelectorItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSelectorItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSelectorItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSelectorItem5)});
            this.viewSelectorBar1.Offset = 3;
            // 
            // viewSelectorItem1
            // 
            this.viewSelectorItem1.Checked = true;
            this.viewSelectorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem1.Glyph")));
            this.viewSelectorItem1.GroupIndex = 1;
            this.viewSelectorItem1.Id = 0;
            this.viewSelectorItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D1));
            this.viewSelectorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem1.LargeGlyph")));
            this.viewSelectorItem1.Name = "viewSelectorItem1";
            this.viewSelectorItem1.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
            // 
            // viewSelectorItem2
            // 
            this.viewSelectorItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem2.Glyph")));
            this.viewSelectorItem2.GroupIndex = 1;
            this.viewSelectorItem2.Id = 1;
            this.viewSelectorItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D2));
            this.viewSelectorItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem2.LargeGlyph")));
            this.viewSelectorItem2.Name = "viewSelectorItem2";
            this.viewSelectorItem2.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            // 
            // viewSelectorItem3
            // 
            this.viewSelectorItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem3.Glyph")));
            this.viewSelectorItem3.GroupIndex = 1;
            this.viewSelectorItem3.Id = 2;
            this.viewSelectorItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D3));
            this.viewSelectorItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem3.LargeGlyph")));
            this.viewSelectorItem3.Name = "viewSelectorItem3";
            this.viewSelectorItem3.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Week;
            // 
            // viewSelectorItem4
            // 
            this.viewSelectorItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem4.Glyph")));
            this.viewSelectorItem4.GroupIndex = 1;
            this.viewSelectorItem4.Id = 3;
            this.viewSelectorItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D4));
            this.viewSelectorItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem4.LargeGlyph")));
            this.viewSelectorItem4.Name = "viewSelectorItem4";
            this.viewSelectorItem4.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            // 
            // viewSelectorItem5
            // 
            this.viewSelectorItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem5.Glyph")));
            this.viewSelectorItem5.GroupIndex = 1;
            this.viewSelectorItem5.Id = 4;
            this.viewSelectorItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D5));
            this.viewSelectorItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem5.LargeGlyph")));
            this.viewSelectorItem5.Name = "viewSelectorItem5";
            this.viewSelectorItem5.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 2;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGroupByNone),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGroupByDate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGroupByResource)});
            this.bar1.Text = "Tools";
            // 
            // barBtnGroupByNone
            // 
            this.barBtnGroupByNone.Caption = "None";
            this.barBtnGroupByNone.Id = 10;
            this.barBtnGroupByNone.Name = "barBtnGroupByNone";
            this.barBtnGroupByNone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGroupByNone_ItemClick);
            // 
            // barBtnGroupByDate
            // 
            this.barBtnGroupByDate.Caption = "Date";
            this.barBtnGroupByDate.Id = 11;
            this.barBtnGroupByDate.Name = "barBtnGroupByDate";
            this.barBtnGroupByDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGroupByDate_ItemClick);
            // 
            // barBtnGroupByResource
            // 
            this.barBtnGroupByResource.Caption = "Resource";
            this.barBtnGroupByResource.Id = 12;
            this.barBtnGroupByResource.Name = "barBtnGroupByResource";
            this.barBtnGroupByResource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGroupByResource_ItemClick);
            // 
            // viewNavigatorBar1
            // 
            this.viewNavigatorBar1.DockCol = 1;
            this.viewNavigatorBar1.DockRow = 0;
            this.viewNavigatorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.viewNavigatorBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.viewNavigatorBackwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewNavigatorForwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewNavigatorTodayItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewNavigatorZoomInItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewNavigatorZoomOutItem1)});
            this.viewNavigatorBar1.Offset = 309;
            // 
            // viewNavigatorBackwardItem1
            // 
            this.viewNavigatorBackwardItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorBackwardItem1.Glyph")));
            this.viewNavigatorBackwardItem1.GroupIndex = 1;
            this.viewNavigatorBackwardItem1.Id = 5;
            this.viewNavigatorBackwardItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorBackwardItem1.LargeGlyph")));
            this.viewNavigatorBackwardItem1.Name = "viewNavigatorBackwardItem1";
            // 
            // viewNavigatorForwardItem1
            // 
            this.viewNavigatorForwardItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorForwardItem1.Glyph")));
            this.viewNavigatorForwardItem1.GroupIndex = 1;
            this.viewNavigatorForwardItem1.Id = 6;
            this.viewNavigatorForwardItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorForwardItem1.LargeGlyph")));
            this.viewNavigatorForwardItem1.Name = "viewNavigatorForwardItem1";
            // 
            // viewNavigatorTodayItem1
            // 
            this.viewNavigatorTodayItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorTodayItem1.Glyph")));
            this.viewNavigatorTodayItem1.GroupIndex = 1;
            this.viewNavigatorTodayItem1.Id = 7;
            this.viewNavigatorTodayItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorTodayItem1.LargeGlyph")));
            this.viewNavigatorTodayItem1.Name = "viewNavigatorTodayItem1";
            // 
            // viewNavigatorZoomInItem1
            // 
            this.viewNavigatorZoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomInItem1.Glyph")));
            this.viewNavigatorZoomInItem1.GroupIndex = 1;
            this.viewNavigatorZoomInItem1.Id = 8;
            this.viewNavigatorZoomInItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            this.viewNavigatorZoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomInItem1.LargeGlyph")));
            this.viewNavigatorZoomInItem1.Name = "viewNavigatorZoomInItem1";
            // 
            // viewNavigatorZoomOutItem1
            // 
            this.viewNavigatorZoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomOutItem1.Glyph")));
            this.viewNavigatorZoomOutItem1.GroupIndex = 1;
            this.viewNavigatorZoomOutItem1.Id = 9;
            this.viewNavigatorZoomOutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract));
            this.viewNavigatorZoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomOutItem1.LargeGlyph")));
            this.viewNavigatorZoomOutItem1.Name = "viewNavigatorZoomOutItem1";
            // 
            // schedulerStorage
            // 
            this.schedulerStorage.Appointments.DataSource = this.xpCollectionAppointments;
            this.schedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage.Appointments.Mappings.Description = "Description";
            this.schedulerStorage.Appointments.Mappings.End = "Finish";
            this.schedulerStorage.Appointments.Mappings.Label = "Label";
            this.schedulerStorage.Appointments.Mappings.Location = "Location";
            this.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "Recurrence";
            this.schedulerStorage.Appointments.Mappings.ReminderInfo = "Reminder";
            this.schedulerStorage.Appointments.Mappings.ResourceId = "Resource!Key";
            this.schedulerStorage.Appointments.Mappings.Start = "Start";
            this.schedulerStorage.Appointments.Mappings.Status = "Status";
            this.schedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage.Appointments.Mappings.Type = "AppointmentType";
            this.schedulerStorage.Resources.DataSource = this.xpCollectionResources;
            this.schedulerStorage.Resources.Mappings.Caption = "Name";
            this.schedulerStorage.Resources.Mappings.Id = "Oid";
            this.schedulerStorage.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnAppointmentCollectionChanged);
            this.schedulerStorage.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnAppointmentCollectionChanged);
            // 
            // xpCollectionAppointments
            // 
            this.xpCollectionAppointments.DeleteObjectOnRemove = true;
            this.xpCollectionAppointments.DisplayableProperties = "This;Oid;AllDay;Description;Start;Finish;Label;Location;Recurrence;Reminder;Statu" +
                "s;Subject;AppointmentType;Resource!;Resource!Key;Resource";
            this.xpCollectionAppointments.ObjectType = typeof(DevExpress.XtraScheduler.Examples.XPAppointment);
            // 
            // xpCollectionResources
            // 
            this.xpCollectionResources.DisplayableProperties = "This;Oid;Name";
            this.xpCollectionResources.ObjectType = typeof(DevExpress.XtraScheduler.Examples.XPResource);
            // 
            // viewSelector
            // 
            this.viewSelector.BarManager = this.barManager;
            this.viewSelector.SchedulerControl = this.schedulerControl;
            // 
            // viewNavigator
            // 
            this.viewNavigator.BarManager = this.barManager;
            this.viewNavigator.SchedulerControl = this.schedulerControl;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 534);
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNavigator)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
				
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
		private DevExpress.XtraScheduler.UI.ViewSelector viewSelector;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraScheduler.UI.ViewSelectorBar viewSelectorBar1;
		private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem1;
		private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem2;
		private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem3;
		private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem4;
		private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem5;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorBar viewNavigatorBar1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem viewNavigatorBackwardItem1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem viewNavigatorForwardItem1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem viewNavigatorTodayItem1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem viewNavigatorZoomInItem1;
		private DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem viewNavigatorZoomOutItem1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraScheduler.UI.ViewNavigator viewNavigator;
		private DevExpress.XtraBars.BarButtonItem barBtnGroupByNone;
		private DevExpress.XtraBars.BarButtonItem barBtnGroupByDate;
		private DevExpress.XtraBars.BarButtonItem barBtnGroupByResource;
		private DevExpress.Xpo.XPCollection xpCollectionAppointments;
		private DevExpress.Xpo.XPCollection xpCollectionResources;
	}
}

