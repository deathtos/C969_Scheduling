using C969_Scheduling.Helpers;
using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Forms
{
    public partial class AddAppointment : Form
    {
        private DataGridViewRow _selectedRow;
        private DateTime? _selectedDate;
        private int _formType;
        private int _appointmentId;

        public AddAppointment(int formType, DataGridViewRow dataGridViewRow, DateTime? selectedDate)
        {
            _formType = formType;
            _selectedRow = dataGridViewRow;
            _selectedDate = selectedDate;

            InitializeComponent();
            ConfigureForm();
        }
        private void ConfigureForm()
        {
            ConfigureCustomerComboBox();

            if (_formType == 1)
            {
                lblAppointmentForm.Text = "Add Appointment";
                dtpStart.Value = (DateTime)(_selectedDate != null ? _selectedDate : DateTime.Now);
                dtpEnd.Value = _selectedDate == null ? DateTime.Now.AddMinutes(30) : ((DateTime)_selectedDate).AddMinutes(30);
            }
            else
            {
                lblAppointmentForm.Text = "Update Appointment";
                _appointmentId = Convert.ToInt32(_selectedRow.Cells[0].Value);
                tbTitle.Text = _selectedRow.Cells[1].Value.ToString();
                tbDescription.Text = _selectedRow.Cells[2].Value.ToString();
                cbCustomers.Text = _selectedRow.Cells[3].Value.ToString();
                tbType.Text = _selectedRow.Cells[4].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(_selectedRow.Cells[5].Value);
                dtpEnd.Value = Convert.ToDateTime(_selectedRow.Cells[6].Value);
                cbCustomers.SelectedValue = Convert.ToInt32(_selectedRow.Cells[8].Value);
                tbUrl.Text = _selectedRow.Cells[9].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment()
            {
                Title = !string.IsNullOrEmpty(tbTitle.Text.Trim()) ? tbTitle.Text.Trim() : string.Empty,
                Type = !string.IsNullOrEmpty(tbType.Text.Trim()) ? tbType.Text.Trim() : string.Empty,
                Description = !string.IsNullOrEmpty(tbDescription.Text.Trim()) ? tbDescription.Text.Trim() : string.Empty,
                Url = !string.IsNullOrEmpty(tbUrl.Text.Trim()) ? tbUrl.Text.Trim() : string.Empty,
                Start = dtpStart.Value,
                End = dtpEnd.Value,
                CustomerId = Convert.ToInt32(cbCustomers.SelectedValue),
                Contact = cbCustomers.Text,
                AppointmentId = _appointmentId,
            };

            if (GlobalHelpers.ValidationHelper.ValidateAppointment(appointment))
            { 
                if (_formType == 1)
                {
                    addAppointment(appointment);
                } 
                else
                {
                    updateAppointment(appointment);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void ConfigureCustomerComboBox()
        {
            // Call the method to get the customers from the database
            List<Customer> customers = GlobalHelpers.DbHelper.GetCustomers();
            // Set the DataSource, DisplayMember, and ValueMember for the ComboBox
            cbCustomers.DataSource = customers;
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "Id";
        }
        private void addAppointment(Appointment appointment)
        {
            // Call the method to add the appointment to the database
            GlobalHelpers.DbHelper.AddAppointment(appointment);
        }
        private void updateAppointment(Appointment appointment)
        {
            // Call the method to update the appointment in the database
            GlobalHelpers.DbHelper.UpdateAppointment(appointment);
        }
    }
}
