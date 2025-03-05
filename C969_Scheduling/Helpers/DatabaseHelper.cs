using MySql.Data.MySqlClient;
using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Helpers
{

    public class DatabaseHelper
    {
        private string _connectionstring;

        private MySqlConnection _connection;

        public DatabaseHelper(string connectionString)
        {
            _connectionstring = connectionString;
            _connection = new MySqlConnection(_connectionstring);
        }

        public bool VerifyLogin(User user)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.VerifyUserLogin;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.UserParameters.UserName, user.Username);
                cmd.Parameters.AddWithValue(Constants.UserParameters.Password, user.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.ErrorMessages.InvalidCredentials + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int GetUserId(User user)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetUserId;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.UserParameters.UserName, user.Username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetAllUsers;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = reader.GetInt32(0),
                        Username = reader.GetString(1)
                    };
                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return users;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetCustomerData;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Address2 = reader.GetString(3),
                        PostalCode = reader.GetString(4),
                        City = reader.GetString(5),
                        Country = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        CityId = reader.GetInt32(8),
                        CountryId = reader.GetInt32(9),
                        AddressId = reader.GetInt32(10)
                    };
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return customers;

        }

        public int AddCustomer(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.AddCustomer;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CustomerName, customer.Name);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.AddressId, customer.AddressId);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.Active, 1);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CreateDate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CreatedBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.LastUpdateBy, customer.PhoneNumber);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.UpdateCustomer;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CustomerName, customer.Name);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.AddressId, customer.AddressId);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.Active, 1);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CustomerId, customer.Id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            try
            {
                _connection.Open();
                string queryDelCus = Constants.SQLQueries.DeleteCustomer;
                MySqlCommand cmd = new MySqlCommand(queryDelCus, _connection);
                cmd.Parameters.AddWithValue(Constants.CustomerParameters.CustomerId, customer.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int AddCountry(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.AddCountry;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.CountryName, customer.Country);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.CreateDate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.CreatedBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int GetCountryId(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetCountryId;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CountryParameters.CountryName, customer.Country);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int AddCity(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.AddCity;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CityName, customer.City);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CountryId, customer.CountryId);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CreateDate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CityParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CreatedBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.CityParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int UpdateCity(Customer customer)
        {
            try
            {
                _connection.Open();
                using (var transation = _connection.BeginTransaction())
                {
                    try
                    {
                        string query = Constants.SQLQueries.UpdateCity;
                        MySqlCommand cmd = new MySqlCommand(query, _connection);
                        cmd.Parameters.AddWithValue(Constants.CityParameters.CityName, customer.City);
                        cmd.Parameters.AddWithValue(Constants.CityParameters.CountryId, customer.CountryId);
                        cmd.Parameters.AddWithValue(Constants.CityParameters.CityId, customer.CityId);
                        cmd.Parameters.AddWithValue(Constants.CityParameters.LastUpdate, DateTime.UtcNow);
                        cmd.Parameters.AddWithValue(Constants.CityParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                        cmd.ExecuteScalar();
                        transation.Commit();
                        return customer.CityId;
                    }
                    catch (Exception ex)
                    {
                        transation.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int GetCityId(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetCityId;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CityName, customer.City);
                cmd.Parameters.AddWithValue(Constants.CityParameters.CountryId, customer.CountryId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int AddAddress(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.AddAddress;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Address1, customer.Address);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Address2, customer.Address2);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.PostalCode, customer.PostalCode);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.CityId, customer.CityId);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Phone, customer.PhoneNumber);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.CreateDate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.CreatedBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int UpdateAddress(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.UpdateAddress;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Address1, customer.Address);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Address2, customer.Address2);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.PostalCode, customer.PostalCode);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.CityId, customer.CityId);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Phone, customer.PhoneNumber);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.AddressId, customer.AddressId);
                cmd.ExecuteScalar();
                return customer.AddressId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void DeleteAddress(Customer customer)
        {
            try
            {
                _connection.Open();
                using (var transation = _connection.BeginTransaction())
                {
                    try
                    {
                        string queryDelAddr = Constants.SQLQueries.DeleteAddress;
                        MySqlCommand cmdAddr = new MySqlCommand(queryDelAddr, _connection);
                        cmdAddr.Parameters.AddWithValue(Constants.CustomerParameters.CustomerId, customer.Id);
                        cmdAddr.ExecuteNonQuery();
                        transation.Commit();
                    }
                    catch (Exception ex)
                    {
                        transation.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int GetAddressId(Customer customer)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetAddressId;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.Address1, customer.Address);
                cmd.Parameters.AddWithValue(Constants.AddressParameters.CityId, customer.CityId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetAllAppointments;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        AppointmentId = reader.GetInt32(0),
                        CustomerId = reader.GetInt32(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        Location = reader.GetString(4),
                        Contact = reader.GetString(5),
                        Type = reader.GetString(6),
                        Start = GlobalHelpers.TimezoneHelper.ConvertToLocal(reader.GetDateTime(7)),
                        End = GlobalHelpers.TimezoneHelper.ConvertToLocal(reader.GetDateTime(8)),
                        Url = reader.GetString(9),
                        CreatedBy = reader.GetString(10)
                    };
                    appointments.Add(appointment);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return appointments;
        }
        public List<Appointment> GetAppointmentsByDateRange(DateTime start, DateTime end)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.GetAllAppointmentsByDateRange;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Start, GlobalHelpers.TimezoneHelper.ConvertToUTC(start));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.End, GlobalHelpers.TimezoneHelper.ConvertToUTC(end));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        AppointmentId = reader.GetInt32(0),
                        CustomerId = reader.GetInt32(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        Location = reader.GetString(4),
                        Contact = reader.GetString(5),
                        Type = reader.GetString(6),
                        Start = GlobalHelpers.TimezoneHelper.ConvertToLocal(reader.GetDateTime(7)),
                        End = GlobalHelpers.TimezoneHelper.ConvertToLocal(reader.GetDateTime(8)),
                        Url = reader.GetString(9)
                    };
                    appointments.Add(appointment);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return appointments;
        }
        public int AddAppointment(Appointment appointment)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.AddAppointment;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Title, appointment.Title);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Description, appointment.Description);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Location, GlobalHelpers.UserLocationInfo.Region);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Contact, appointment.Contact);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Type, appointment.Type);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Start, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.Start));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.End, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.End));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.CustomerId, appointment.CustomerId);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Url, appointment.Url);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.CreateDate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.CreatedBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public int UpdateAppointment(Appointment appointment)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.UpdateAppointment;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Title, appointment.Title);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Description, appointment.Description);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Location, GlobalHelpers.UserLocationInfo.Region);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Contact, appointment.Contact);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Type, appointment.Type);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Start, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.Start));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.End, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.End));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.CustomerId, appointment.CustomerId);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Url, appointment.Url);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.LastUpdate, DateTime.UtcNow);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.LastUpdateBy, GlobalHelpers.CurrentUser.Username);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.AppointmentId, appointment.AppointmentId);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public void DeleteAppointment(Appointment appointment)
        {
            try
            {
                _connection.Open();
                string queryDelApp = Constants.SQLQueries.DeleteAppointment;
                MySqlCommand cmd = new MySqlCommand(queryDelApp, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.AppointmentId, appointment.AppointmentId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public int CheckForAppointmentOverlap(Appointment appointment)
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.ValidateTimeblock;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.Start, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.Start));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.End, GlobalHelpers.TimezoneHelper.ConvertToUTC(appointment.End));
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.AppointmentId, appointment.AppointmentId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        public int CheckForUpcommingAppointment()
        {
            try
            {
                _connection.Open();
                string query = Constants.SQLQueries.CheckForAppointmentInNext15Minutes;
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue(Constants.AppointmentParameters.User, GlobalHelpers.CurrentUser.Username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
