' Developer Express Code Central Example:
' How to use the Appointment Split tool
' 
' This example illustrates the use of a new tool allowing end-users to split an
' appointment in two by simply dragging a splitter line. To accomplish this, use
' the DevExpress.XtraScheduler.Commands.SplitAppointmentOperationCommand class.
' Associate this command with the popup menu item in the PreparePopupMenu
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_PreparePopupMenutopic)
' event handler using the SchedulerMenuItemCommandWinAdapter. After that all you
' have to do is select the Split command from the appointment's context menu, drag
' the splitter to the required time and click the left mouse button. You can use
' the mouse wheel to adjust the splitter precision.
' See
' Also:
' http://www.devexpress.com/scid=K18126
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E340

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
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
            Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
            Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
            Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
            Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
            Me.newAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
            Me.newRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
            Me.navigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
            Me.navigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
            Me.gotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
            Me.viewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
            Me.viewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
            Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
            Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
            Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
            Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
            Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
            Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
            Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
            Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
            Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
            Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
            Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
            Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
            Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
            Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
            Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
            Me.editAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
            Me.editOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
            Me.editSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
            Me.deleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
            Me.deleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
            Me.deleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
            Me.splitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
            Me.changeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
            Me.changeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.toggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
            Me.changeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
            Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
            Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
            Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
            Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
            Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
            Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
            Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
            Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
            Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
            Me.groupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
            Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.xpCollectionAppointments = New DevExpress.Xpo.XPCollection(Me.components)
            Me.xpCollectionResources = New DevExpress.Xpo.XPCollection(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 142)
            Me.schedulerControl.MenuManager = Me.ribbonControl1
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(831, 530)
            Me.schedulerControl.Start = New Date(2008, 8, 7, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            timeRuler1.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00")
            timeRuler1.TimeZone.DaylightZoneName = "Russian Daylight Time"
            timeRuler1.TimeZone.DisplayName = "(UTC+04:00) Moscow, St. Petersburg, Volgograd"
            timeRuler1.TimeZone.StandardZoneName = "Russian Standard Time"
            timeRuler1.TimeZone.UtcOffset = System.TimeSpan.Parse("04:00:00")
            timeRuler1.UseClientTimeZone = False
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            timeRuler2.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00")
            timeRuler2.TimeZone.DaylightZoneName = "Russian Daylight Time"
            timeRuler2.TimeZone.DisplayName = "(UTC+04:00) Moscow, St. Petersburg, Volgograd"
            timeRuler2.TimeZone.StandardZoneName = "Russian Standard Time"
            timeRuler2.TimeZone.UtcOffset = System.TimeSpan.Parse("04:00:00")
            timeRuler2.UseClientTimeZone = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 40
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.calendarToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.viewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
            Me.ribbonControl1.Size = New System.Drawing.Size(831, 142)
            ' 
            ' openScheduleItem1
            ' 
            Me.openScheduleItem1.Id = 1
            Me.openScheduleItem1.Name = "openScheduleItem1"
            ' 
            ' saveScheduleItem1
            ' 
            Me.saveScheduleItem1.Id = 2
            Me.saveScheduleItem1.Name = "saveScheduleItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 3
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 4
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPageSetupItem1
            ' 
            Me.printPageSetupItem1.Id = 5
            Me.printPageSetupItem1.Name = "printPageSetupItem1"
            ' 
            ' newAppointmentItem1
            ' 
            Me.newAppointmentItem1.Id = 6
            Me.newAppointmentItem1.Name = "newAppointmentItem1"
            ' 
            ' newRecurringAppointmentItem1
            ' 
            Me.newRecurringAppointmentItem1.Id = 7
            Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
            ' 
            ' navigateViewBackwardItem1
            ' 
            Me.navigateViewBackwardItem1.Id = 8
            Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
            ' 
            ' navigateViewForwardItem1
            ' 
            Me.navigateViewForwardItem1.Id = 9
            Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
            ' 
            ' gotoTodayItem1
            ' 
            Me.gotoTodayItem1.Id = 10
            Me.gotoTodayItem1.Name = "gotoTodayItem1"
            ' 
            ' viewZoomInItem1
            ' 
            Me.viewZoomInItem1.Id = 11
            Me.viewZoomInItem1.Name = "viewZoomInItem1"
            ' 
            ' viewZoomOutItem1
            ' 
            Me.viewZoomOutItem1.Id = 12
            Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
            ' 
            ' switchToDayViewItem1
            ' 
            Me.switchToDayViewItem1.Id = 13
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            Me.switchToWorkWeekViewItem1.Id = 14
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            Me.switchToWeekViewItem1.Id = 15
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            Me.switchToMonthViewItem1.Id = 16
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            Me.switchToTimelineViewItem1.Id = 17
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' switchToGanttViewItem1
            ' 
            Me.switchToGanttViewItem1.Id = 18
            Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
            ' 
            ' groupByNoneItem1
            ' 
            Me.groupByNoneItem1.Id = 19
            Me.groupByNoneItem1.Name = "groupByNoneItem1"
            ' 
            ' groupByDateItem1
            ' 
            Me.groupByDateItem1.Id = 20
            Me.groupByDateItem1.Name = "groupByDateItem1"
            ' 
            ' groupByResourceItem1
            ' 
            Me.groupByResourceItem1.Id = 21
            Me.groupByResourceItem1.Name = "groupByResourceItem1"
            ' 
            ' switchTimeScalesItem1
            ' 
            Me.switchTimeScalesItem1.Id = 22
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' changeScaleWidthItem1
            ' 
            Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
            Me.changeScaleWidthItem1.Id = 23
            Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
            Me.changeScaleWidthItem1.UseCommandCaption = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' switchTimeScalesCaptionItem1
            ' 
            Me.switchTimeScalesCaptionItem1.Id = 24
            Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
            ' 
            ' switchCompressWeekendItem1
            ' 
            Me.switchCompressWeekendItem1.Id = 25
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            Me.switchShowWorkTimeOnlyItem1.Id = 26
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' switchCellsAutoHeightItem1
            ' 
            Me.switchCellsAutoHeightItem1.Id = 27
            Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
            ' 
            ' changeSnapToCellsUIItem1
            ' 
            Me.changeSnapToCellsUIItem1.Id = 28
            Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
            ' 
            ' editAppointmentQueryItem1
            ' 
            Me.editAppointmentQueryItem1.Id = 29
            Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1) _
            })
            Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
            Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' editOccurrenceUICommandItem1
            ' 
            Me.editOccurrenceUICommandItem1.Id = 30
            Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
            ' 
            ' editSeriesUICommandItem1
            ' 
            Me.editSeriesUICommandItem1.Id = 31
            Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
            ' 
            ' deleteAppointmentsItem1
            ' 
            Me.deleteAppointmentsItem1.Id = 32
            Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1) _
            })
            Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
            Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' deleteOccurrenceItem1
            ' 
            Me.deleteOccurrenceItem1.Id = 33
            Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
            ' 
            ' deleteSeriesItem1
            ' 
            Me.deleteSeriesItem1.Id = 34
            Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
            ' 
            ' splitAppointmentItem1
            ' 
            Me.splitAppointmentItem1.Id = 35
            Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
            ' 
            ' changeAppointmentStatusItem1
            ' 
            Me.changeAppointmentStatusItem1.Id = 36
            Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
            ' 
            ' changeAppointmentLabelItem1
            ' 
            Me.changeAppointmentLabelItem1.Id = 37
            Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
            ' 
            ' toggleRecurrenceItem1
            ' 
            Me.toggleRecurrenceItem1.Id = 38
            Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
            ' 
            ' changeAppointmentReminderItem1
            ' 
            Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
            Me.changeAppointmentReminderItem1.Id = 39
            Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
            ' 
            ' repositoryItemDuration1
            ' 
            Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.repositoryItemDuration1.AutoHeight = False
            Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
            Me.repositoryItemDuration1.NullValuePromptShowForEmptyValue = True
            Me.repositoryItemDuration1.ShowEmptyItem = True
            Me.repositoryItemDuration1.ValidateOnEnterKey = True
            ' 
            ' calendarToolsRibbonPageCategory1
            ' 
            Me.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1"
            Me.calendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.appointmentRibbonPage1})
            ' 
            ' appointmentRibbonPage1
            ' 
            Me.appointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.actionsRibbonPageGroup1, Me.optionsRibbonPageGroup1})
            Me.appointmentRibbonPage1.Name = "appointmentRibbonPage1"
            ' 
            ' actionsRibbonPageGroup1
            ' 
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.editAppointmentQueryItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.deleteAppointmentsItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.splitAppointmentItem1)
            Me.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1"
            ' 
            ' optionsRibbonPageGroup1
            ' 
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentStatusItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentLabelItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.toggleRecurrenceItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentReminderItem1)
            Me.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.printRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.openScheduleItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.saveScheduleItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' printRibbonPageGroup1
            ' 
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPageSetupItem1)
            Me.printRibbonPageGroup1.Name = "printRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1, Me.groupByRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            ' 
            ' appointmentRibbonPageGroup1
            ' 
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newAppointmentItem1)
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newRecurringAppointmentItem1)
            Me.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1"
            ' 
            ' navigatorRibbonPageGroup1
            ' 
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewBackwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewForwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.gotoTodayItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomInItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomOutItem1)
            Me.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1"
            ' 
            ' arrangeRibbonPageGroup1
            ' 
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
            ' 
            ' groupByRibbonPageGroup1
            ' 
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByNoneItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByDateItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByResourceItem1)
            Me.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1, Me.layoutRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' activeViewRibbonPageGroup1
            ' 
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            ' 
            ' timeScaleRibbonPageGroup1
            ' 
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.changeScaleWidthItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesCaptionItem1)
            Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
            ' 
            ' layoutRibbonPageGroup1
            ' 
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCellsAutoHeightItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.changeSnapToCellsUIItem1)
            Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
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
            ' 
            ' xpCollectionAppointments
            ' 
            Me.xpCollectionAppointments.DeleteObjectOnRemove = True
            Me.xpCollectionAppointments.DisplayableProperties = "This;Oid;AllDay;Description;Start;Finish;Label;Location;Recurrence;Reminder;Statu" & "s;Subject;AppointmentType;Resource!;Resource!Key;Resource"
            Me.xpCollectionAppointments.ObjectType = GetType(DevExpress.XtraScheduler.Examples.XPAppointment)
            ' 
            ' xpCollectionResources
            ' 
            Me.xpCollectionResources.ObjectType = GetType(DevExpress.XtraScheduler.Examples.XPResource)
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.openScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.saveScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPageSetupItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newRecurringAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewBackwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewForwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.gotoTodayItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomInItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomOutItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToDayViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWorkWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToGanttViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByNoneItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByDateItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByResourceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeScaleWidthItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesCaptionItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCellsAutoHeightItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeSnapToCellsUIItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editAppointmentQueryItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editOccurrenceUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editSeriesUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteAppointmentsItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteOccurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteSeriesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.splitAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentStatusItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentLabelItem1)
            Me.schedulerBarController1.BarItems.Add(Me.toggleRecurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentReminderItem1)
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(831, 672)
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MainForm"
            Me.Text = "Form1"
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private xpCollectionAppointments As DevExpress.Xpo.XPCollection
        Private xpCollectionResources As DevExpress.Xpo.XPCollection
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private openScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
        Private saveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
        Private printPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
        Private printItem1 As DevExpress.XtraScheduler.UI.PrintItem
        Private printPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
        Private newAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
        Private newRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
        Private navigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
        Private navigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
        Private gotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
        Private viewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
        Private viewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
        Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
        Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
        Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
        Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
        Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
        Private switchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
        Private groupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
        Private groupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
        Private groupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
        Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
        Private changeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private switchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
        Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
        Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
        Private switchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
        Private changeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
        Private editAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
        Private editOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
        Private editSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
        Private deleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
        Private deleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
        Private deleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
        Private splitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
        Private changeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
        Private changeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
        Private toggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
        Private changeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
        Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
        Private calendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
        Private appointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
        Private actionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
        Private optionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
        Private fileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
        Private printRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
        Private homeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage
        Private appointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
        Private navigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
        Private arrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
        Private groupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
        Private viewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage
        Private activeViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup
        Private timeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup
        Private layoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    End Class
End Namespace

