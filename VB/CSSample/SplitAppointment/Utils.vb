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
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler

Namespace SplitAppointment
    Public Class ResourceFiller
        Public Shared Users() As String = { "Sarah Brighton", "Ryan Fischer", "Andrew Miller" }
        Public Shared Usernames() As String = { "sbrighton", "rfischer", "amiller" }

        Public Shared Sub FillResources(ByVal storage As SchedulerStorage, ByVal count As Integer)
            Dim resources As ResourceCollection = storage.Resources.Items
            storage.BeginUpdate()
            Try
                Dim cnt As Integer = Math.Min(count, Users.Length)
                For i As Integer = 1 To cnt
                    resources.Add(New Resource(Usernames(i - 1), Users(i - 1)))
                Next i
            Finally
                storage.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
