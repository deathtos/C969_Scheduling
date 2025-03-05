using System;

namespace C969_Scheduling.Helpers
{
    public class TimezoneHelper
    {
        public DateTime ConvertToLocal(DateTime dtConvert)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            return TimeZoneInfo.ConvertTimeFromUtc(dtConvert, localZone);
        }

        public DateTime ConvertToUTC(DateTime dtConvert)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            return TimeZoneInfo.ConvertTimeToUtc(dtConvert, localZone);
        }

        public DateTime ConvertToEST(DateTime dtConvert)
        {
            // Define the Eastern Standard Time (EST) time zone
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            // Convert the given dateTime to EST
            return TimeZoneInfo.ConvertTimeFromUtc(dtConvert.ToUniversalTime(), estTimeZone);
        }
    }
}
