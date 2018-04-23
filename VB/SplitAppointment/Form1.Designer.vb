Imports Microsoft.VisualBasic
Imports System
Namespace SplitAppointment
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.viewSelectorBar1 = New DevExpress.XtraScheduler.UI.ViewSelectorBar()
			Me.viewSelectorItem1 = New DevExpress.XtraScheduler.UI.ViewSelectorItem()
			Me.viewSelectorItem2 = New DevExpress.XtraScheduler.UI.ViewSelectorItem()
			Me.viewSelectorItem3 = New DevExpress.XtraScheduler.UI.ViewSelectorItem()
			Me.viewSelectorItem4 = New DevExpress.XtraScheduler.UI.ViewSelectorItem()
			Me.viewSelectorItem5 = New DevExpress.XtraScheduler.UI.ViewSelectorItem()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barBtnGroupByNone = New DevExpress.XtraBars.BarButtonItem()
			Me.barBtnGroupByDate = New DevExpress.XtraBars.BarButtonItem()
			Me.barBtnGroupByResource = New DevExpress.XtraBars.BarButtonItem()
			Me.viewNavigatorBar1 = New DevExpress.XtraScheduler.UI.ViewNavigatorBar()
			Me.viewNavigatorBackwardItem1 = New DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem()
			Me.viewNavigatorForwardItem1 = New DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem()
			Me.viewNavigatorTodayItem1 = New DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem()
			Me.viewNavigatorZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem()
			Me.viewNavigatorZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.xpCollectionAppointments = New DevExpress.Xpo.XPCollection()
			Me.xpCollectionResources = New DevExpress.Xpo.XPCollection()
			Me.viewSelector = New DevExpress.XtraScheduler.UI.ViewSelector(Me.components)
			Me.viewNavigator = New DevExpress.XtraScheduler.UI.ViewNavigator(Me.components)
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 26)
			Me.schedulerControl.MenuManager = Me.barManager
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(1067, 508)
			Me.schedulerControl.Start = New System.DateTime(2008, 8, 7, 0, 0, 0, 0)
			Me.schedulerControl.Storage = Me.schedulerStorage
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl.PreparePopupMenu += New DevExpress.XtraScheduler.PreparePopupMenuEventHandler(Me.SchedulerControlPreparePopupMenu);
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.viewSelectorBar1, Me.bar1, Me.viewNavigatorBar1})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.viewSelectorItem1, Me.viewSelectorItem2, Me.viewSelectorItem3, Me.viewSelectorItem4, Me.viewSelectorItem5, Me.viewNavigatorBackwardItem1, Me.viewNavigatorForwardItem1, Me.viewNavigatorTodayItem1, Me.viewNavigatorZoomInItem1, Me.viewNavigatorZoomOutItem1, Me.barBtnGroupByNone, Me.barBtnGroupByDate, Me.barBtnGroupByResource})
			Me.barManager.MaxItemId = 13
			' 
			' viewSelectorBar1
			' 
			Me.viewSelectorBar1.DockCol = 0
			Me.viewSelectorBar1.DockRow = 0
			Me.viewSelectorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.viewSelectorBar1.FloatLocation = New System.Drawing.Point(274, 207)
			Me.viewSelectorBar1.FloatSize = New System.Drawing.Size(358, 26)
			Me.viewSelectorBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.viewSelectorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewSelectorItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.viewSelectorItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.viewSelectorItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.viewSelectorItem5)})
			Me.viewSelectorBar1.Offset = 3
			' 
			' viewSelectorItem1
			' 
			Me.viewSelectorItem1.Checked = True
			Me.viewSelectorItem1.Glyph = (CType(resources.GetObject("viewSelectorItem1.Glyph"), System.Drawing.Image))
			Me.viewSelectorItem1.GroupIndex = 1
			Me.viewSelectorItem1.Id = 0
			Me.viewSelectorItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) Or System.Windows.Forms.Keys.D1))
			Me.viewSelectorItem1.LargeGlyph = (CType(resources.GetObject("viewSelectorItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewSelectorItem1.Name = "viewSelectorItem1"
			Me.viewSelectorItem1.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
			' 
			' viewSelectorItem2
			' 
			Me.viewSelectorItem2.Glyph = (CType(resources.GetObject("viewSelectorItem2.Glyph"), System.Drawing.Image))
			Me.viewSelectorItem2.GroupIndex = 1
			Me.viewSelectorItem2.Id = 1
			Me.viewSelectorItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) Or System.Windows.Forms.Keys.D2))
			Me.viewSelectorItem2.LargeGlyph = (CType(resources.GetObject("viewSelectorItem2.LargeGlyph"), System.Drawing.Image))
			Me.viewSelectorItem2.Name = "viewSelectorItem2"
			Me.viewSelectorItem2.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
			' 
			' viewSelectorItem3
			' 
			Me.viewSelectorItem3.Glyph = (CType(resources.GetObject("viewSelectorItem3.Glyph"), System.Drawing.Image))
			Me.viewSelectorItem3.GroupIndex = 1
			Me.viewSelectorItem3.Id = 2
			Me.viewSelectorItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) Or System.Windows.Forms.Keys.D3))
			Me.viewSelectorItem3.LargeGlyph = (CType(resources.GetObject("viewSelectorItem3.LargeGlyph"), System.Drawing.Image))
			Me.viewSelectorItem3.Name = "viewSelectorItem3"
			Me.viewSelectorItem3.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Week
			' 
			' viewSelectorItem4
			' 
			Me.viewSelectorItem4.Glyph = (CType(resources.GetObject("viewSelectorItem4.Glyph"), System.Drawing.Image))
			Me.viewSelectorItem4.GroupIndex = 1
			Me.viewSelectorItem4.Id = 3
			Me.viewSelectorItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) Or System.Windows.Forms.Keys.D4))
			Me.viewSelectorItem4.LargeGlyph = (CType(resources.GetObject("viewSelectorItem4.LargeGlyph"), System.Drawing.Image))
			Me.viewSelectorItem4.Name = "viewSelectorItem4"
			Me.viewSelectorItem4.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
			' 
			' viewSelectorItem5
			' 
			Me.viewSelectorItem5.Glyph = (CType(resources.GetObject("viewSelectorItem5.Glyph"), System.Drawing.Image))
			Me.viewSelectorItem5.GroupIndex = 1
			Me.viewSelectorItem5.Id = 4
			Me.viewSelectorItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) Or System.Windows.Forms.Keys.D5))
			Me.viewSelectorItem5.LargeGlyph = (CType(resources.GetObject("viewSelectorItem5.LargeGlyph"), System.Drawing.Image))
			Me.viewSelectorItem5.Name = "viewSelectorItem5"
			Me.viewSelectorItem5.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 2
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnGroupByNone), New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnGroupByDate), New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnGroupByResource)})
			Me.bar1.Text = "Tools"
			' 
			' barBtnGroupByNone
			' 
			Me.barBtnGroupByNone.Caption = "None"
			Me.barBtnGroupByNone.Id = 10
			Me.barBtnGroupByNone.Name = "barBtnGroupByNone"
'			Me.barBtnGroupByNone.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barBtnGroupByNone_ItemClick);
			' 
			' barBtnGroupByDate
			' 
			Me.barBtnGroupByDate.Caption = "Date"
			Me.barBtnGroupByDate.Id = 11
			Me.barBtnGroupByDate.Name = "barBtnGroupByDate"
'			Me.barBtnGroupByDate.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barBtnGroupByDate_ItemClick);
			' 
			' barBtnGroupByResource
			' 
			Me.barBtnGroupByResource.Caption = "Resource"
			Me.barBtnGroupByResource.Id = 12
			Me.barBtnGroupByResource.Name = "barBtnGroupByResource"
'			Me.barBtnGroupByResource.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barBtnGroupByResource_ItemClick);
			' 
			' viewNavigatorBar1
			' 
			Me.viewNavigatorBar1.DockCol = 1
			Me.viewNavigatorBar1.DockRow = 0
			Me.viewNavigatorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.viewNavigatorBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.viewNavigatorBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewNavigatorForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewNavigatorTodayItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewNavigatorZoomInItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewNavigatorZoomOutItem1)})
			Me.viewNavigatorBar1.Offset = 309
			' 
			' viewNavigatorBackwardItem1
			' 
			Me.viewNavigatorBackwardItem1.Glyph = (CType(resources.GetObject("viewNavigatorBackwardItem1.Glyph"), System.Drawing.Image))
			Me.viewNavigatorBackwardItem1.GroupIndex = 1
			Me.viewNavigatorBackwardItem1.Id = 5
			Me.viewNavigatorBackwardItem1.LargeGlyph = (CType(resources.GetObject("viewNavigatorBackwardItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewNavigatorBackwardItem1.Name = "viewNavigatorBackwardItem1"
			' 
			' viewNavigatorForwardItem1
			' 
			Me.viewNavigatorForwardItem1.Glyph = (CType(resources.GetObject("viewNavigatorForwardItem1.Glyph"), System.Drawing.Image))
			Me.viewNavigatorForwardItem1.GroupIndex = 1
			Me.viewNavigatorForwardItem1.Id = 6
			Me.viewNavigatorForwardItem1.LargeGlyph = (CType(resources.GetObject("viewNavigatorForwardItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewNavigatorForwardItem1.Name = "viewNavigatorForwardItem1"
			' 
			' viewNavigatorTodayItem1
			' 
			Me.viewNavigatorTodayItem1.Glyph = (CType(resources.GetObject("viewNavigatorTodayItem1.Glyph"), System.Drawing.Image))
			Me.viewNavigatorTodayItem1.GroupIndex = 1
			Me.viewNavigatorTodayItem1.Id = 7
			Me.viewNavigatorTodayItem1.LargeGlyph = (CType(resources.GetObject("viewNavigatorTodayItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewNavigatorTodayItem1.Name = "viewNavigatorTodayItem1"
			' 
			' viewNavigatorZoomInItem1
			' 
			Me.viewNavigatorZoomInItem1.Glyph = (CType(resources.GetObject("viewNavigatorZoomInItem1.Glyph"), System.Drawing.Image))
			Me.viewNavigatorZoomInItem1.GroupIndex = 1
			Me.viewNavigatorZoomInItem1.Id = 8
			Me.viewNavigatorZoomInItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Add))
			Me.viewNavigatorZoomInItem1.LargeGlyph = (CType(resources.GetObject("viewNavigatorZoomInItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewNavigatorZoomInItem1.Name = "viewNavigatorZoomInItem1"
			' 
			' viewNavigatorZoomOutItem1
			' 
			Me.viewNavigatorZoomOutItem1.Glyph = (CType(resources.GetObject("viewNavigatorZoomOutItem1.Glyph"), System.Drawing.Image))
			Me.viewNavigatorZoomOutItem1.GroupIndex = 1
			Me.viewNavigatorZoomOutItem1.Id = 9
			Me.viewNavigatorZoomOutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Subtract))
			Me.viewNavigatorZoomOutItem1.LargeGlyph = (CType(resources.GetObject("viewNavigatorZoomOutItem1.LargeGlyph"), System.Drawing.Image))
			Me.viewNavigatorZoomOutItem1.Name = "viewNavigatorZoomOutItem1"
			' 
			' schedulerStorage
			' 
			Me.schedulerStorage.Appointments.DataSource = Me.xpCollectionAppointments
			Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage.Appointments.Mappings.End = "Finish"
			Me.schedulerStorage.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "Recurrence"
			Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "Reminder"
			Me.schedulerStorage.Appointments.Mappings.ResourceId = "Resource!Key"
			Me.schedulerStorage.Appointments.Mappings.Start = "Start"
			Me.schedulerStorage.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage.Appointments.Mappings.Type = "AppointmentType"
			Me.schedulerStorage.Resources.DataSource = Me.xpCollectionResources
			Me.schedulerStorage.Resources.Mappings.Caption = "Name"
			Me.schedulerStorage.Resources.Mappings.Id = "Oid"
'			Me.schedulerStorage.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnAppointmentCollectionChanged);
'			Me.schedulerStorage.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnAppointmentCollectionChanged);
			' 
			' xpCollectionAppointments
			' 
			Me.xpCollectionAppointments.DeleteObjectOnRemove = True
			Me.xpCollectionAppointments.DisplayableProperties = "This;Oid;AllDay;Description;Start;Finish;Label;Location;Recurrence;Reminder;Statu" & "s;Subject;AppointmentType;Resource!;Resource!Key;Resource"
			Me.xpCollectionAppointments.ObjectType = GetType(DevExpress.XtraScheduler.Examples.XPAppointment)
			' 
			' xpCollectionResources
			' 
			Me.xpCollectionResources.DisplayableProperties = "This;Oid;Name"
			Me.xpCollectionResources.ObjectType = GetType(DevExpress.XtraScheduler.Examples.XPResource)
			' 
			' viewSelector
			' 
			Me.viewSelector.BarManager = Me.barManager
			Me.viewSelector.SchedulerControl = Me.schedulerControl
			' 
			' viewNavigator
			' 
			Me.viewNavigator.BarManager = Me.barManager
			Me.viewNavigator.SchedulerControl = Me.schedulerControl
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1067, 534)
			Me.Controls.Add(Me.schedulerControl)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "MainForm"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewSelector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private viewSelector As DevExpress.XtraScheduler.UI.ViewSelector
		Private barManager As DevExpress.XtraBars.BarManager
		Private viewSelectorBar1 As DevExpress.XtraScheduler.UI.ViewSelectorBar
		Private viewSelectorItem1 As DevExpress.XtraScheduler.UI.ViewSelectorItem
		Private viewSelectorItem2 As DevExpress.XtraScheduler.UI.ViewSelectorItem
		Private viewSelectorItem3 As DevExpress.XtraScheduler.UI.ViewSelectorItem
		Private viewSelectorItem4 As DevExpress.XtraScheduler.UI.ViewSelectorItem
		Private viewSelectorItem5 As DevExpress.XtraScheduler.UI.ViewSelectorItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private viewNavigatorBar1 As DevExpress.XtraScheduler.UI.ViewNavigatorBar
		Private viewNavigatorBackwardItem1 As DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem
		Private viewNavigatorForwardItem1 As DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem
		Private viewNavigatorTodayItem1 As DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem
		Private viewNavigatorZoomInItem1 As DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem
		Private viewNavigatorZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private viewNavigator As DevExpress.XtraScheduler.UI.ViewNavigator
		Private WithEvents barBtnGroupByNone As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barBtnGroupByDate As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barBtnGroupByResource As DevExpress.XtraBars.BarButtonItem
		Private xpCollectionAppointments As DevExpress.Xpo.XPCollection
		Private xpCollectionResources As DevExpress.Xpo.XPCollection
	End Class
End Namespace

