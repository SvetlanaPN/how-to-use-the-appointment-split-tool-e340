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
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu

Namespace SplitAppointment
    Partial Public Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            schedulerControl.Start = Date.Now.Date
            schedulerControl.ActiveViewType = SchedulerViewType.Day
            schedulerControl.Views.DayView.DayCount = 3
            schedulerControl.DayView.TopRowTime = schedulerControl.DayView.WorkTime.Start
        End Sub
        #Region "SchedulerControlPreparePopupMenu"
        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
                Dim command As New SplitAppointmentOperationCommand(schedulerControl)
                Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(command)
                Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
                menuItem.BeginGroup = True
                e.Menu.Items.Add(menuItem)
            End If
        End Sub
        #End Region
        #Region "barBtnGroupByNone_ItemClick"
        Private Sub barBtnGroupByNone_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            schedulerControl.GroupType = SchedulerGroupType.None
        End Sub
        #End Region
        #Region "barBtnGroupByDate_ItemClick"
        Private Sub barBtnGroupByDate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            schedulerControl.GroupType = SchedulerGroupType.Date
        End Sub
        #End Region
        #Region "barBtnGroupByResource_ItemClick"
        Private Sub barBtnGroupByResource_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            schedulerControl.GroupType = SchedulerGroupType.Resource
        End Sub
        #End Region
        #Region "MainForm_Load"
        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitData()
        End Sub
        #End Region
        #Region "InitData"
        Private Sub InitData()
            Dim resources As ResourceBaseCollection = schedulerStorage.Resources.Items
            If resources.Count <= 0 Then
                resources.Add(New Resource(0, "Andrew Fuller"))
                resources.Add(New Resource(1, "Nancy Davolio"))
                resources.Add(New Resource(2, "Janet Leverling"))
                resources.Add(New Resource(3, "Margaret Peacock"))
                Dim count As Integer = xpCollectionResources.Count
                For i As Integer = 0 To count - 1
                    Dim o As XPObject = CType(xpCollectionResources(i), XPObject)
                    o.Save()
                Next i
            End If

            If schedulerStorage.Appointments.Count = 0 Then

                schedulerStorage.BeginUpdate()

                Dim aptPattern As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Pattern)
                Dim curHour As Date = Date.Now.Date.AddHours(Date.Now.Hour)
                aptPattern.Start = curHour.AddDays(-2)
                aptPattern.End = aptPattern.Start.AddHours(2)
                aptPattern.RecurrenceInfo.Start = aptPattern.Start
                aptPattern.Subject = "Test Appointment To Split"
                aptPattern.Description = "Again and again..."
                aptPattern.ResourceId = schedulerStorage.Resources(0).Id
                aptPattern.StatusId = CInt((AppointmentStatusType.Busy))
                aptPattern.LabelId = 1
                aptPattern.RecurrenceInfo.Type = RecurrenceType.Daily
                aptPattern.RecurrenceInfo.Periodicity = 2
                aptPattern.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
                aptPattern.RecurrenceInfo.OccurrenceCount = 10
                schedulerControl.Storage.Appointments.Add(aptPattern)

                schedulerStorage.EndUpdate()

            End If



        End Sub
        #End Region
        #Region "OnAppointmentCollectionChanged"
        Private Sub OnAppointmentCollectionChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsChanged
            For Each apt As Appointment In e.Objects
                Dim o As XPBaseObject = TryCast(apt.GetSourceObject(schedulerStorage), XPBaseObject)
                If o IsNot Nothing Then
                    o.Save()
                End If
            Next apt
        End Sub
        #End Region
    End Class
End Namespace