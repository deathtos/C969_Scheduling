namespace C969_Scheduling.ProcessModels
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public Customer() { }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Customer(DataGridViewRow dataGridViewRow)
        {
            Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            if(dataGridViewRow.Cells[1].Value != null)
            {
                Name = dataGridViewRow.Cells[1].Value.ToString();
            }
            if(dataGridViewRow.Cells[2].Value != null)
            {
                Address = dataGridViewRow.Cells[2].Value.ToString();
            }
            if (dataGridViewRow.Cells[3].Value != null)
            {
                Address2 = dataGridViewRow.Cells[3].Value.ToString();
            }
            if (dataGridViewRow.Cells[4].Value != null)
            {
                PostalCode = dataGridViewRow.Cells[4].Value.ToString();
            }
            if (dataGridViewRow.Cells[5].Value != null)
            {
                City = dataGridViewRow.Cells[5].Value.ToString();
            }
            if (dataGridViewRow.Cells[6].Value != null)
            {
                Country = dataGridViewRow.Cells[6].Value.ToString();
            }
            if (dataGridViewRow.Cells[7].Value != null)
            {
                PhoneNumber = dataGridViewRow.Cells[7].Value.ToString();
            }
            if (dataGridViewRow.Cells[8].Value != null)
            {
                CityId = Convert.ToInt32(dataGridViewRow.Cells[8].Value);
            }
            if (dataGridViewRow.Cells[9].Value != null)
            {
                CountryId = Convert.ToInt32(dataGridViewRow.Cells[9].Value);
            }
            if (dataGridViewRow.Cells[10].Value != null)
            {
                AddressId = Convert.ToInt32(dataGridViewRow.Cells[10].Value);
            }
        }

        public Customer(string name, string address, string address2, string postalCode, string city, string country, string phonenumber)
        {
            Name = name;
            Address = address;
            Address2 = address2;
            PostalCode = postalCode;
            City = city;
            Country = country;
            PhoneNumber = phonenumber;
        }
    }
}
