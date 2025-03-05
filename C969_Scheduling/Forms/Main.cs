using C969_Scheduling.Helpers;
using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            // Load data into the DataGridView and other controls here
            lblWelcome.Text = $"Welcome, {GlobalHelpers.CurrentUser.Username}";
            lblLocation.Text = $"Location: {GlobalHelpers.UserLocationInfo.Region}, {GlobalHelpers.UserLocationInfo.Country}";
            SetupCustomerGrid();
            SetupAppointmentGrid();
        }

        #region Customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (AddCustomer addCustomerForm = new AddCustomer(Constants.FormTypes.Create, null))
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    SetupCustomerGrid();
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            using (AddCustomer addCustomerForm = new AddCustomer(Constants.FormTypes.Update, dgvCustomers.CurrentRow))
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    SetupCustomerGrid();
                }
            }

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            if (GlobalHelpers.ValidationHelper.ValidateDeleteCustomer(dgvCustomers.CurrentRow))
            {
                DeleteCustomer(dgvCustomers.CurrentRow);
                SetupCustomerGrid();
            }
        }

        private void DeleteCustomer(DataGridViewRow selectedCustomer)
        {
            Customer customer = new Customer(selectedCustomer);
            GlobalHelpers.DbHelper.DeleteCustomer(customer);
            GlobalHelpers.DbHelper.DeleteAddress(customer);
        }

        private void SetupCustomerGrid()
        {
            List<Customer> customers = GlobalHelpers.DbHelper.GetCustomers();

            if (customers != null)
            {
                prepDVGCustomers();
                foreach (var customer in customers)
                {
                    dgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Address2, customer.PostalCode, customer.City, customer.Country, customer.PhoneNumber, customer.CityId, customer.CountryId, customer.AddressId);
                }
            }

        }

        private void prepDVGCustomers()
        {
            dgvCustomers.Columns.Clear();
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.CustomerId, "Customer ID");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.CustomerName, "Customer Name");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.Address, "Address");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.Address2, "Address 2");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.PostalCode, "Postal Code");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.City, "City");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.Country, "Country");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.Phone, "Phone");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.CityId, "City ID");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.CountryId, "Country ID");
            dgvCustomers.Columns.Add(Constants.CustomerDataGridColumns.AddressId, "Address ID");

            //dgvCustomers.Columns[Constants.CustomerDataGridColumns.CustomerId].Visible = false;
            dgvCustomers.Columns[Constants.CustomerDataGridColumns.CityId].Visible = false;
            dgvCustomers.Columns[Constants.CustomerDataGridColumns.CountryId].Visible = false;
            dgvCustomers.Columns[Constants.CustomerDataGridColumns.AddressId].Visible = false;

        }

        #endregion

        #region Appointment
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            using (AddAppointment addAppointmentForm = new AddAppointment(Constants.FormTypes.Create, null, selectedDate))
            {
                if (addAppointmentForm.ShowDialog() == DialogResult.OK)
                {
                    SetupAppointmentGrid();
                }
            }
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            using (AddAppointment addAppointmentForm = new AddAppointment(Constants.FormTypes.Update, dgvAppointments.CurrentRow, null))
            {
                if (addAppointmentForm.ShowDialog() == DialogResult.OK)
                {
                    SetupAppointmentGrid();
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            List<Appointment> appointments = GlobalHelpers.DbHelper.GetAppointmentsByDateRange(selectedDate, selectedDate.AddDays(1).Date);
            LoadAppointmentDataGrid(appointments);
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (GlobalHelpers.ValidationHelper.ValidateDeleteCustomer(dgvAppointments.CurrentRow))
            {
                DeleteAppointment(dgvAppointments.CurrentRow);
                SetupCustomerGrid();
            }
        }

        private void DeleteAppointment(DataGridViewRow selectedAppointment)
        {
            Appointment appointment = new Appointment(selectedAppointment);
            GlobalHelpers.DbHelper.DeleteAppointment(appointment);
            SetupAppointmentGrid();
        }

        private void btnShowAllAppointments_Click(object sender, EventArgs e)
        {
            SetupAppointmentGrid();
        }

        private void SetupAppointmentGrid()
        {
            List<Appointment> appointments = GlobalHelpers.DbHelper.GetAppointments();
            LoadAppointmentDataGrid(appointments);
        }

        private void LoadAppointmentDataGrid(List<Appointment> appointments)
        {
            if (appointments != null)
            {
                prepDVGAppointments();
                foreach (var appointment in appointments)
                {
                    dgvAppointments.Rows.Add(appointment.AppointmentId, appointment.Title, appointment.Description, appointment.Contact, appointment.Type, appointment.Start, appointment.End, appointment.Location, appointment.CustomerId, appointment.Url);
                }
            }
        }

        private void prepDVGAppointments()
        {
            dgvAppointments.Columns.Clear();
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.AppointmentId, "Appointment Id");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.Title, "Title");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.Description, "Description");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.CustomerName, "CustomerName");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.Type, "Type");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.StartTime, "Start Time");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.EndTime, "End Time");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.Location, "Location");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.CustomerId, "Customer Id");
            dgvAppointments.Columns.Add(Constants.AppointmentDataGridColumns.Url, "Url");

            dgvAppointments.Columns[Constants.AppointmentDataGridColumns.AppointmentId].Visible = false;
            dgvAppointments.Columns[Constants.AppointmentDataGridColumns.CustomerId].Visible = false;

        }
        #endregion

        #region Reports
        private void btnReportSubmit_Click(object sender, EventArgs e)
        {
            var report = cbReport.Checked;
            var report1 = cbReport1.Checked;
            var report2 = cbReport2.Checked;

            if (report)
            {
                DisplayReport displayReport = new DisplayReport(0);
                displayReport.Show();
            }

            if (report1)
            {
                DisplayReport displayReport1 = new DisplayReport(1);
                displayReport1.Show();
            }

            if (report2)
            {
                DisplayReport displayReport2 = new DisplayReport(2);
                displayReport2.Show();
            }

        }

        #endregion

    }
}
