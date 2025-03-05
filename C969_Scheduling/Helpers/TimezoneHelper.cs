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
    }
}
