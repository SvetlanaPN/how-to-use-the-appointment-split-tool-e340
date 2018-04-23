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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SplitAppointment")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SplitAppointment")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("28729e6f-048b-4a67-8b96-313d15cdee1b")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
