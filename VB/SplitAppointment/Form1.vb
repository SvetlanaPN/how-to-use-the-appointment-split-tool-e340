#Region "#usings"
Imports DevExpress.Utils.Menu
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports System
#End Region ' #usings

Namespace SplitAppointment
    Partial Public Class MainForm
        Inherits XtraForm

        Public Sub New()
            XpoDefault.DataLayer = New SimpleDataLayer(New InMemoryDataStore())

            InitializeComponent()

            schedulerControl.Start = Date.Now.Date
            schedulerControl.ActiveViewType = SchedulerViewType.Day
            schedulerControl.Views.DayView.DayCount = 3
            schedulerControl.DayView.TopRowTime = schedulerControl.DayView.WorkTime.Start
        End Sub
        #Region "#SchedulerControlPopupMenuShowing"
        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
                Dim command As New SplitAppointmentOperationCommand(schedulerControl)
                Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(command)
                Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
                menuItem.BeginGroup = True
                e.Menu.Items.Add(menuItem)
            End If
        End Sub
        #End Region ' #SchedulerControlPopupMenuShowing
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
                resources.Add(Me.schedulerStorage.CreateResource(0, "Andrew Fuller"))
                resources.Add(Me.schedulerStorage.CreateResource(1, "Nancy Davolio"))
                resources.Add(Me.schedulerStorage.CreateResource(2, "Janet Leverling"))
                resources.Add(Me.schedulerStorage.CreateResource(3, "Margaret Peacock"))
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
                aptPattern.StatusKey = CInt((AppointmentStatusType.Busy))
                aptPattern.LabelKey = 1
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