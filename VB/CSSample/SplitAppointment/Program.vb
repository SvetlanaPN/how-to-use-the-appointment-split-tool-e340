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
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace SplitAppointment
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            SkinManager.EnableFormSkins()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace