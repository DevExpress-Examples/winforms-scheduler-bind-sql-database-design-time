Imports DevExpress.XtraScheduler
Imports System
Imports System.Windows.Forms

Namespace SchedulerDbExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            resourcesTableAdapter.Fill(schedulerTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            appointmentsTableAdapter.Fill(schedulerTestDataSet.Appointments)
            schedulerControl1.Start = Date.Today
            schedulerControl1.ActiveViewType = SchedulerViewType.Day
            schedulerControl1.DayView.TopRowTime = New TimeSpan(10, 0, 0)
            schedulerControl1.GroupType = SchedulerGroupType.Resource
            schedulerControl1.DayView.ResourcesPerPage = 2
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = True
            AddHandler schedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted
        End Sub

        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(schedulerTestDataSet)
            schedulerTestDataSet.AcceptChanges()
        End Sub
    End Class
End Namespace
