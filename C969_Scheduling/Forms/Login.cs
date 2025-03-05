
using C969_Scheduling.Helpers;
using C969_Scheduling.Forms;
using System.Globalization;

namespace C969_Scheduling
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblLocation.Text = $"{Properties.Resources.lblLocation}: {GlobalHelpers.UserLocationInfo.Region}, {GlobalHelpers.UserLocationInfo.Country}";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = !string.IsNullOrEmpty(txtUsername.Text.Trim()) ? txtUsername.Text.Trim() : string.Empty;
            string password = !string.IsNullOrEmpty(txtPassword.Text.Trim()) ? txtPassword.Text.Trim() : string.Empty;

            if (GlobalHelpers.ValidationHelper.ValidateUser(username, password))
            {
                CheckForUpcommingAppointments();
                // If Valid, show the main form
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();
            }

        }

        private void CheckForUpcommingAppointments()
        {

            if (GlobalHelpers.DbHelper.CheckForUpcommingAppointment() > 0)
            {
                MessageBox.Show("You have upcoming appointments in the next 15 minutes.");
            }
        }

        private void llblLanguage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userCulture = GlobalHelpers.LanguageHelper.SwitchUserCulture();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(userCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(userCulture);

            lblPassword.Text = Properties.Resources.lblPassword;
            lblUsername.Text = Properties.Resources.lblUsername;
            btnSignIn.Text = Properties.Resources.btnLogin;
            lblLocation.Text = $"{Properties.Resources.lblLocation}: {GlobalHelpers.UserLocationInfo.Region}, {GlobalHelpers.UserLocationInfo.Country}";
            lblWelcome.Text = Properties.Resources.lblWelcome;
            llblLanguage.Text = Properties.Resources.lblLanguage;
        }
    }
}
