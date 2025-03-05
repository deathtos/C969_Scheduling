using C969_Scheduling.ProcessModels;
using C969_Scheduling.Helpers;

namespace C969_Scheduling.Forms
{
    public partial class AddCustomer : Form
    {
        private int _formType;
        private DataGridViewRow _selectedRow;
        private int _customerId;
        private int _cityId;
        private int _addressId;
        private int _countryId;


        public AddCustomer(int formType, DataGridViewRow selectedRow)
        {
            _formType = formType;
            _selectedRow = selectedRow;

            InitializeComponent();
            ConfigureForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = !string.IsNullOrEmpty(tbName.Text.Trim()) ? tbName.Text.Trim() : string.Empty,
                Address = !string.IsNullOrEmpty(tbAddress.Text.Trim()) ? tbAddress.Text.Trim() : string.Empty,
                Address2 = !string.IsNullOrEmpty(tbAddress2.Text.Trim()) ? tbAddress2.Text.Trim() : string.Empty,
                PostalCode = !string.IsNullOrEmpty(tbPostalCode.Text.Trim()) ? tbPostalCode.Text.Trim() : string.Empty,
                PhoneNumber = !string.IsNullOrEmpty(tbPhone.Text.Trim()) ? tbPhone.Text.Trim() : string.Empty,
                City = !string.IsNullOrEmpty(tbCity.Text.Trim()) ? tbCity.Text.Trim() : string.Empty,
                Country = !string.IsNullOrEmpty(tbCountry.Text.Trim()) ? tbCountry.Text.Trim() : string.Empty,
                Id = _customerId,
                CityId = _cityId,
                AddressId = _addressId,
                CountryId = _countryId
            };

            if (GlobalHelpers.ValidationHelper.ValidateCustomer(customer))
            {
                if (_formType == 1)
                {
                    addCustomer(customer);
                }
                else
                {
                    updateCustomer(customer);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        private void ConfigureForm()
        {
            if (_formType == 1)
            {
                lblCustomerForm.Text = "Add Customer";
            }
            else
            {
                lblCustomerForm.Text = "Update Customer";
                _customerId = Convert.ToInt32(_selectedRow.Cells[0].Value);
                tbName.Text = _selectedRow.Cells[1].Value.ToString();
                tbAddress.Text = _selectedRow.Cells[2].Value.ToString();
                tbAddress2.Text = _selectedRow.Cells[3].Value.ToString();
                tbPostalCode.Text = _selectedRow.Cells[4].Value.ToString();
                tbCity.Text = _selectedRow.Cells[5].Value.ToString();
                tbCountry.Text = _selectedRow.Cells[6].Value.ToString();
                tbPhone.Text = _selectedRow.Cells[7].Value.ToString();
                _cityId = Convert.ToInt32(_selectedRow.Cells[8].Value);
                _countryId = Convert.ToInt32(_selectedRow.Cells[9].Value);
                _addressId = Convert.ToInt32(_selectedRow.Cells[10].Value);
            }
        }        
        private void addCustomer(Customer customer)
        {
            //Add Country
            customer.CountryId = GetCountryId(customer);
            //Add City
            customer.CityId = GetCityId(customer);
            //Add Address
            customer.AddressId = GetAddressId(customer);
            //Add Customer
            GlobalHelpers.DbHelper.AddCustomer(customer);
        }
        private void updateCustomer(Customer customer)
        {
            bool updateCountry = false, updateCity = false, updateAddress = false;
            //Country
            //is the orrigianl value different?
            if (_selectedRow.Cells[6].Value.ToString() != customer.Country)
            {
                customer.CountryId = GetCountryId(customer);
                updateCountry = true;
            }

            if (_selectedRow.Cells[5].Value.ToString() != customer.City || updateCountry)
            {
                customer.CityId = UpdateCity(customer);
                updateCity = true;
            }

            if (_selectedRow.Cells[2].Value.ToString() != customer.Address || _selectedRow.Cells[3].Value.ToString() != customer.Address2 || _selectedRow.Cells[4].Value.ToString() != customer.PostalCode || _selectedRow.Cells[7].Value.ToString() != customer.PhoneNumber || updateCity)
            {
                customer.AddressId = UpdateAddress(customer);
                updateAddress = true;
            }

            if(_selectedRow.Cells[1].Value.ToString() != customer.Name || updateAddress)
            {
                customer.Id = _customerId;
                GlobalHelpers.DbHelper.UpdateCustomer(customer);
            }
        }
        private int GetCountryId(Customer customer)
        {
            //Check if country exists
            int foundId = GlobalHelpers.DbHelper.GetCountryId(customer);
            return foundId = foundId > 0 ? foundId : GlobalHelpers.DbHelper.AddCountry(customer);

        }
        private int GetCityId(Customer customer)
        {
            //Check if city exists
            int foundId = GlobalHelpers.DbHelper.GetCityId(customer);
            return foundId = foundId > 0 ? foundId : GlobalHelpers.DbHelper.AddCity(customer);
        }
        private int GetAddressId(Customer customer)
        {
            //Check if address exists
            int foundId = GlobalHelpers.DbHelper.GetAddressId(customer);
            return foundId = foundId > 0 ? foundId : GlobalHelpers.DbHelper.AddAddress(customer);
        }
        private int UpdateCity(Customer customer)
        {
            return GlobalHelpers.DbHelper.UpdateCity(customer);
        }
        private int UpdateAddress(Customer customer)
        {
            return GlobalHelpers.DbHelper.UpdateAddress(customer);
        }
    }
}
