using C969_Scheduling.Helpers;
using C969_Scheduling.ProcessModels;
using System.Data;
using static C969_Scheduling.Constants;

namespace C969_Scheduling.Forms
{
    public partial class DisplayReport : Form
    {
        private int _reportType;
        private object _reportData;
        public DisplayReport(int ReportType)
        {
            _reportType = ReportType;

            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            switch (_reportType)
            {
                case 0:
                    BuildReportNumberOfAppointmentTypesByMonth();
                    break;
                case 1:
                    BuildReportScheduleForEachUser();
                    break;
                case 2:
                    BuildReportAppointmentesByContact();
                    break;
            }
        }

        private void BuildReportNumberOfAppointmentTypesByMonth()
        {
            lblReport.Text = "Number of Appointment Types by Month";
            //build dataset
            _reportData = GlobalHelpers.ReportHelper.GetAppointmentTypesByMonth(GlobalHelpers.DbHelper.GetAppointments());
            //build datatable
            var reportNumberOfAppointmentTypesByMonthDataTable = NumberOfAppointmentTypesByMonthDataTable((Dictionary<string, Dictionary<string, int>>)_reportData);
            //display
            dgvReport.DataSource = reportNumberOfAppointmentTypesByMonthDataTable;
        }

        private void BuildReportScheduleForEachUser()
        {
            lblReport.Text = "Schedule for Each User";
            //build dataset
            _reportData = GlobalHelpers.ReportHelper.GetSchedlueForEachUser(GlobalHelpers.DbHelper.GetAppointments(), GlobalHelpers.DbHelper.GetUsers());
            //build datatable
            var reportScheduleForEachUserDataTable = ScheduleForEachUserDataTable((Dictionary<string, List<Appointment>>)_reportData);
            //display
            dgvReport.DataSource = reportScheduleForEachUserDataTable;
        }

        private void BuildReportAppointmentesByContact()
        {
            lblReport.Text = "Appointments by Contact";
            //build dataset
            _reportData = GlobalHelpers.ReportHelper.GetAppointmentesByContact(GlobalHelpers.DbHelper.GetAppointments());
            //build datatable
            var reportAppointmentesByContactDataTable = AppointmentesByContactDataTable((Dictionary<string, List<Appointment>>)_reportData);
            //display
            dgvReport.DataSource = reportAppointmentesByContactDataTable;
        }

        private DataTable NumberOfAppointmentTypesByMonthDataTable(Dictionary<string, Dictionary<string, int>> data)
        {
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add(NumberOfAppointmentsDatatable.Month, typeof(string));
            dataTable.Columns.Add(NumberOfAppointmentsDatatable.AppointmentType, typeof(string));
            dataTable.Columns.Add(NumberOfAppointmentsDatatable.AppointmentCount, typeof(int));

            // Iterate through the dictionary and add rows
            foreach (var monthEntry in data)
            {
                string month = monthEntry.Key;
                foreach (var typeEntry in monthEntry.Value)
                {
                    string appointmentType = typeEntry.Key;
                    int appointmentCount = typeEntry.Value;

                    DataRow row = dataTable.NewRow();
                    row[NumberOfAppointmentsDatatable.Month] = month;
                    row[NumberOfAppointmentsDatatable.AppointmentType] = appointmentType;
                    row[NumberOfAppointmentsDatatable.AppointmentCount] = appointmentCount;
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        private DataTable ScheduleForEachUserDataTable(Dictionary<string, List<Appointment>> data)
        {
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Username, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Title, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Description, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Location, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Contact, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Type, typeof(string));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Start, typeof(DateTime));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.End, typeof(DateTime));
            dataTable.Columns.Add(ScheduleForEachUserDatatable.Url, typeof(string));

            // Iterate through the dictionary and add rows
            foreach (var userEntry in data)
            {
                string username = userEntry.Key;
                foreach (var appointment in userEntry.Value)
                {
                    DataRow row = dataTable.NewRow();
                    row[ScheduleForEachUserDatatable.Username] = username;
                    row[ScheduleForEachUserDatatable.Title] = appointment.Title;
                    row[ScheduleForEachUserDatatable.Description] = appointment.Description;
                    row[ScheduleForEachUserDatatable.Location] = appointment.Location;
                    row[ScheduleForEachUserDatatable.Contact] = appointment.Contact;
                    row[ScheduleForEachUserDatatable.Type] = appointment.Type;
                    row[ScheduleForEachUserDatatable.Start] = appointment.Start;
                    row[ScheduleForEachUserDatatable.End] = appointment.End;
                    row[ScheduleForEachUserDatatable.Url] = appointment.Url;
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        private DataTable AppointmentesByContactDataTable(Dictionary<string, List<Appointment>> data)
        {
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add(AppointmentByContactDatatable.Contact, typeof(string));
            dataTable.Columns.Add(AppointmentByContactDatatable.Title, typeof(string));
            dataTable.Columns.Add(AppointmentByContactDatatable.Description, typeof(string));
            dataTable.Columns.Add(AppointmentByContactDatatable.Location, typeof(string));
            dataTable.Columns.Add(AppointmentByContactDatatable.Type, typeof(string));
            dataTable.Columns.Add(AppointmentByContactDatatable.Start, typeof(DateTime));
            dataTable.Columns.Add(AppointmentByContactDatatable.End, typeof(DateTime));
            dataTable.Columns.Add(AppointmentByContactDatatable.Url, typeof(string));

            // Iterate through the dictionary and add rows
            foreach (var contactEntry in data)
            {
                string contact = contactEntry.Key;
                foreach (var appointment in contactEntry.Value)
                {
                    DataRow row = dataTable.NewRow();
                    row[AppointmentByContactDatatable.Contact] = contact;
                    row[AppointmentByContactDatatable.Title] = appointment.Title;
                    row[AppointmentByContactDatatable.Description] = appointment.Description;
                    row[AppointmentByContactDatatable.Location] = appointment.Location;
                    row[AppointmentByContactDatatable.Type] = appointment.Type;
                    row[AppointmentByContactDatatable.Start] = appointment.Start;
                    row[AppointmentByContactDatatable.End] = appointment.End;
                    row[AppointmentByContactDatatable.Url] = appointment.Url;
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Export the DataGridView data to a CSV file
            GlobalHelpers.FileHelper.ExportReportToFile(dgvReport);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
