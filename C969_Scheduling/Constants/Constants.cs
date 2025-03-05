namespace C969_Scheduling
{
    internal class Constants
    {
        public class SQLQueries
        {
            //User
            public const string VerifyUserLogin = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password";
            public const string GetUserId = "SELECT userId FROM user WHERE username = @username";
            public const string GetAllUsers = "SELECT userId, username FROM user";
            //Customer
            public const string GetCustomerData = "SELECT a.CustomerId, a.CustomerName AS Name, b.address AS Address, b.address2 AS Address2, b.postalCode AS PostalCode, c.city AS city, d.country AS Country, b.phone AS PhoneNumber, c.cityId, d.countryId, b.addressId FROM customer a JOIN address b ON a.addressId = b.addressId JOIN city c ON b.cityId = c.cityId JOIN country d ON c.countryId = d.countryId;";
            public const string GetCustomersAndColumnsById = "SELECT * FROM customer WHERE customerId = @customerId";
            public const string GetCustomerIdsAndNames = "SELECT customerId, customerName FROM customer";
            public const string AddCustomer = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
            public const string UpdateCustomer = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE customerId = @customerId";
            public const string DeleteCustomer = "DELETE FROM customer WHERE customerId = @customerId";
            //Appointment
            public const string GetAllUpcommingAppointments = "SELECT a.appointmentId, a.customerId, a.title, a.description, a.location, a.contact, a.type, a.start, a.end, a.url FROM appointment a WHERE a.start > now()";
            public const string GetAllAppointments = "SELECT a.appointmentId, a.customerId, a.title, a.description, a.location, a.contact, a.type, a.start, a.end, a.url, a.createdBy FROM appointment a ";
            public const string GetAllAppointmentsByDateRange = "SELECT a.appointmentId, a.customerId, a.title, a.description, a.location, a.contact, a.type, a.start, a.end, a.url FROM appointment a WHERE ((a.start >= @start) AND (a.end <= @end))";
            public const string AddAppointment = "INSERT INTO appointment (title, description, location, contact, type, url, start, end, customerId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@title, @description, @location, @contact, @type, @url, @start, @end, @customerId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
            public const string UpdateAppointment = "UPDATE appointment SET title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, customerId = @customerId, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId";
            public const string DeleteAppointment = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
            public const string ValidateTimeblock = "SELECT COUNT(*) FROM appointment WHERE ((start BETWEEN @start AND @end) OR (end BETWEEN @start AND @end) OR (@start BETWEEN start AND end) OR (@end BETWEEN start AND end)) AND appointmentid != @appointmentid";
            public const string CheckForAppointmentInNext15Minutes = "SELECT * FROM appointment WHERE start BETWEEN UTC_TIMESTAMP() AND DATE_ADD(UTC_TIMESTAMP(), INTERVAL 15 MINUTE) AND createdby = @User";
            //Country
            public const string AddCountry = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@Country, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); SELECT LAST_INSERT_ID();";
            public const string GetCountryId = "SELECT countryid from country where country = @Country ORDER BY createDate DESC LIMIT 1;";
            //City
            public const string AddCity = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@City, @CountryId, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); SELECT LAST_INSERT_ID();";
            public const string UpdateCity = "UPDATE city SET countryId = @CountryId, city = @City, lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy WHERE cityid = @CityId";
            public const string GetCityId = "SELECT cityid FROM city WHERE city = @City AND countryid = @CountryId ORDER BY createDate DESC LIMIT 1;";
            //Address
            public const string AddAddress = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@Address, @Address2, @CityId, @postalCode, @Phone, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); SELECT LAST_INSERT_ID();";
            public const string UpdateAddress = "UPDATE address SET address = @Address, address2 = @Address2, cityId = @CityId, postalCode = @PostalCode, phone = @Phone, lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy WHERE addressId = @AddressId;";
            public const string GetAddressId = "SELECT addressId from address where cityId = @CityId and address LIKE @Address ORDER BY createDate DESC LIMIT 1;";
            public const string DeleteAddress = "DELETE FROM address WHERE addressID IN ( SELECT addressID FROM customer WHERE customerID = @CustomerID );";
        }

        public class ErrorMessages
        {
            public const string EmptyUsername = "Username is empty";
            public const string EmptyPassword = "Password is empty";
            public const string InvalidCredentials = "Invalid username or password.";
        }

        public class FormTypes
        {
            public const int Create = 1;
            public const int Update = 0;
        }

        public class CityParameters
        {
            public const string CityId = "@cityId";
            public const string CityName = "@city";
            public const string CountryId = "@countryId";
            public const string CreateDate = "@createDate";
            public const string CreatedBy = "@createdBy";
            public const string LastUpdate = "@lastUpdate";
            public const string LastUpdateBy = "@lastUpdateBy";
        }

        public class CountryParameters
        {
            public const string CountryId = "@countryId";
            public const string CountryName = "@country";
            public const string CreateDate = "@createDate";
            public const string CreatedBy = "@createdBy";
            public const string LastUpdate = "@lastUpdate";
            public const string LastUpdateBy = "@lastUpdateBy";

        }

        public class CustomerParameters
        {
            public const string CustomerId = "@customerId";
            public const string CustomerName = "@customerName";
            public const string AddressId = "@addressId";
            public const string Active = "@active";
            public const string CreateDate = "@createDate";
            public const string CreatedBy = "@createdBy";
            public const string LastUpdate = "@lastUpdate";
            public const string LastUpdateBy = "@lastUpdateBy";
        }

        public class UserParameters
        {
            public const string UserId = "@userId";
            public const string UserName = "@userName";
            public const string Password = "@password";
        }

        public class AppointmentParameters
        {
            public const string AppointmentId = "@appointmentId";
            public const string CustomerId = "@customerId";
            public const string User = "@user";
            public const string Title = "@title";
            public const string Description = "@description";
            public const string Location = "@location";
            public const string Contact = "@contact";
            public const string Type = "@type";
            public const string Url = "@url";
            public const string Start = "@start";
            public const string End = "@end";
            public const string CreateDate = "@createDate";
            public const string CreatedBy = "@createdBy";
            public const string LastUpdate = "@lastUpdate";
            public const string LastUpdateBy = "@lastUpdateBy";
        }

        public class AddressParameters
        {
            public const string AddressId = "@addressId";
            public const string Address1 = "@address";
            public const string Address2 = "@address2";
            public const string CityId = "@cityId";
            public const string PostalCode = "@postalCode";
            public const string Phone = "@phone";
            public const string CreateDate = "@createDate";
            public const string CreatedBy = "@createdBy";
            public const string LastUpdate = "@lastUpdate";
            public const string LastUpdateBy = "@lastUpdateBy";
        }

        public class CustomerDataGridColumns
        {
            public const string CustomerId = "CustomerId";
            public const string CustomerName = "CustomerName";
            public const string Address = "Address";
            public const string Address2 = "Address2";
            public const string PostalCode = "PostalCode";
            public const string City = "City";
            public const string Country = "Country";
            public const string Phone = "Phone";
            public const string CityId = "CityId";
            public const string CountryId = "CountryId";
            public const string AddressId = "AddressId";
        }
        public class AppointmentDataGridColumns
        {
            public const string AppointmentId = "AppointmentId";
            public const string CustomerId = "CustomerId";
            public const string CustomerName = "CustomerName";
            public const string StartTime = "StartTime";
            public const string EndTime = "EndTime";
            public const string Type = "Type";
            public const string Title = "Title";
            public const string Description = "Description";
            public const string Location = "Location";
            public const string Contact = "Contact";
            public const string User = "User";
            public const string Url = "Url";
        }
        public class NumberOfAppointmentsDatatable
        {
            public const string Month = "Month";
            public const string AppointmentType = "AppointmentType";
            public const string AppointmentCount = "AppointmentCount";
        }
        public class ScheduleForEachUserDatatable
        {
            public const string Username = "Username";
            public const string Title = "Title";
            public const string Description = "Description";
            public const string Location = "Location";
            public const string Contact = "Contact";
            public const string Type = "Type";
            public const string Start = "Start";
            public const string End = "End";
            public const string Url = "Url";
        }
        public class AppointmentByContactDatatable
        {
            public const string Contact = "Contact";
            public const string Title = "Title";
            public const string Description = "Description";
            public const string Location = "Location";
            public const string Type = "Type";
            public const string Start = "Start";
            public const string End = "End";
            public const string Url = "Url";
        }
    }
}
