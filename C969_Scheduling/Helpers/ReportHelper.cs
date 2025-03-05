using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Helpers
{
    public class ReportHelper
    {
        public Dictionary<string, Dictionary<string,int>> GetAppointmentTypesByMonth(List<Appointment> appointments)
        {
            return appointments
                .GroupBy(appt => new { Month = appt.Start.ToString("MMMM yyyy"), appt.Type })
                .GroupBy(g => g.Key.Month)
                .ToDictionary(
                    monthGroup => monthGroup.Key,
                    monthGroup => monthGroup.ToDictionary(
                        typeGroup => typeGroup.Key.Type,
                        typeGroup => typeGroup.Count()
                    )
                );
        }

        public Dictionary<string, List<Appointment>> GetSchedlueForEachUser(List<Appointment> appointments, List<User> users)
        {
            return appointments
                .GroupBy(appt => appt.CreatedBy)
                .ToDictionary(
                    userGroup => users.FirstOrDefault(user => user.Username == userGroup.Key)?.Username ?? "Unknown User",
                    userGroup => userGroup.ToList()
                );
        }

        public Dictionary<string, List<Appointment>> GetAppointmentesByContact(List<Appointment> appointments)
        {
            return appointments
                .GroupBy(appt => appt.Contact)
                .ToDictionary(
                    customerGroup => customerGroup.Key,
                    customerGroup => customerGroup.ToList()
                );
        }
    }
}
