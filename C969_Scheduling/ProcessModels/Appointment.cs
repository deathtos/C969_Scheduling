namespace C969_Scheduling.ProcessModels
{
    public class Appointment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Customer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int AppointmentId { get; set; }
        public string Url { get; set; }
        public int CustomerId { get; set; }
        public string CreatedBy { get; set; }

        public Appointment() { }
        public Appointment(string title, string description, string location, string contact, string type, string customer, DateTime start, DateTime end, int appointmentId, string url, int customerId)
        {
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Customer = customer;
            Start = start;
            End = end;
            AppointmentId = appointmentId;
            Url = url;
            CustomerId = customerId;
        }

        public Appointment(DataGridViewRow selectedRow)
        {
            AppointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
            Title = selectedRow.Cells[1].Value.ToString();
            Description = selectedRow.Cells[2].Value.ToString();
            Contact = selectedRow.Cells[3].Value.ToString();
            Type = selectedRow.Cells[4].Value.ToString();
            Start = Convert.ToDateTime(selectedRow.Cells[5].Value);
            End = Convert.ToDateTime(selectedRow.Cells[6].Value);
            Location = selectedRow.Cells[7].Value.ToString();
            CustomerId = Convert.ToInt32(selectedRow.Cells[8].Value);
            Url = selectedRow.Cells[9].Value.ToString();
        }

    }
}
