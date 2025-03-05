using C969_Scheduling.ProcessModels;
namespace C969_Scheduling.Helpers
{
    public class ValidationHelper
    {
        public bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is empty");
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty");
                return false;
            }

            User invalidatedUser = new User(username, password);

            if(GlobalHelpers.DbHelper.VerifyLogin(invalidatedUser))
            {
                GlobalHelpers.SetCurrentUser(invalidatedUser);

                GlobalHelpers.FileHelper.WriteToLoginHistoryFile($"User {username} logged in at {DateTime.UtcNow} UTC");
                return true;
            }
            else
            {
                MessageBox.Show(Properties.Resources.errorLogin);
                return false;
            }
        }

        public bool ValidateCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name))
            {
                MessageBox.Show("Customer name is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.Address))
            {
                MessageBox.Show("Customer address is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.Address2))
            {
                MessageBox.Show("Customer address2 is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.PostalCode))
            {
                MessageBox.Show("Customer postal code is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.City))
            {
                MessageBox.Show("Customer city is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.Country))
            {
                MessageBox.Show("Customer country is empty");
                return false;
            }

            if (string.IsNullOrEmpty(customer.PhoneNumber))
            {
                MessageBox.Show("Customer phone number is empty");
                return false;
            }

            // Validate phone number for digits and dashes only
            if (!System.Text.RegularExpressions.Regex.IsMatch(customer.PhoneNumber, @"^[0-9-]+$"))
            {
                MessageBox.Show("Customer phone number is invalid. It should contain only digits and dashes.");
                return false;
            }

            return true;
        }

        public bool ValidateAppointment(Appointment appointment)
        {
            if (ValidateAppointmentFields(appointment))
            {
                if (GlobalHelpers.DbHelper.CheckForAppointmentOverlap(appointment) > 0)
                {
                    MessageBox.Show("Appointment overlaps with another appointment");
                    return false;
                }
            }
            else
            {
                return false;
            }

                return true;
        }

        public bool ValidateAppointmentFields(Appointment appointment)
        {

            if (string.IsNullOrEmpty(appointment.Title))
            {
                MessageBox.Show("Appointment title is empty");
                return false;
            }
            if (string.IsNullOrEmpty(appointment.Description))
            {
                MessageBox.Show("Appointment description is empty");
                return false;
            }
            if (string.IsNullOrEmpty(appointment.Contact))
            {
                MessageBox.Show("Appointment contact is empty");
                return false;
            }
            if (string.IsNullOrEmpty(appointment.Type))
            {
                MessageBox.Show("Appointment type is empty");
                return false;
            }
            if (appointment.Start == DateTime.MinValue)
            {
                MessageBox.Show("Appointment start date is empty");
                return false;
            }
            if (appointment.End == DateTime.MinValue)
            {
                MessageBox.Show("Appointment end date is empty");
                return false;
            }
            if (appointment.Start < DateTime.Now)
            {
                MessageBox.Show("Appointment start date cannot be in the past");
                return false;
            }
            if (appointment.End < DateTime.Now)
            {
                MessageBox.Show("Appointment end date cannot be in the past");
                return false;
            }
            if (appointment.Start >= appointment.End)
            {
                MessageBox.Show("Appointment start date must be before end date");
                return false;
            }
            if (string.IsNullOrEmpty(appointment.Url))
            {
                MessageBox.Show("Appointment URL is empty");
                return false;
            }
            if (!IsWithinWorkingHours(appointment.Start) || !IsWithinWorkingHours(appointment.End))
            {
                MessageBox.Show("Appointment must be within working hours (9 AM to 5 PM) and not on weekends");
                return false;
            }

            return true;
        }

        private bool IsWithinWorkingHours(DateTime dateTime)
        {
            // Check if the date is on a weekend
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            // Define working hours
            TimeSpan startOfWorkDay = new TimeSpan(9, 0, 0); // 9 AM
            TimeSpan endOfWorkDay = new TimeSpan(17, 0, 0); // 5 PM

            // Check if the time is within working hours
            if (dateTime.TimeOfDay < startOfWorkDay || dateTime.TimeOfDay > endOfWorkDay)
            {
                return false;
            }

            return true;
        }

        public bool ValidateDeleteCustomer(DataGridViewRow selectedCustomer)
        {
            return true;
        }

        public bool ValidateDeleteAppointment(Appointment appointment)
        {
            return true;
        }
    }
}
