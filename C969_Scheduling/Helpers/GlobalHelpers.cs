using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Helpers
{
    public static class GlobalHelpers
    {
        private static DatabaseHelper _dbHelper;
        private static FileHelper _fileHelper;
        private static TimezoneHelper _timezoneHelper;
        private static ValidationHelper _validationHelper;
        private static LangaugeHelper _languageHelper;
        private static User _currentUser;
        private static IpInfo _userLocationInfo;
        private static ReportHelper _reportHelper;

        public static void Initialize(AppSettings config)
        {
            if (_dbHelper == null)
            {
                _dbHelper = new DatabaseHelper(config.DBConnectionString);
            }
            if (_fileHelper == null)
            {
                _fileHelper = new FileHelper(config);
            }
            if (_timezoneHelper == null)
            {
                _timezoneHelper = new TimezoneHelper();
            }
            if (_validationHelper == null)
            {
                _validationHelper = new ValidationHelper();
            }
            if(_languageHelper == null)
            {
                _languageHelper = new LangaugeHelper();
            }
            if (_userLocationInfo == null)
            {
                _userLocationInfo = new IpInfo();
            }
            if (_reportHelper == null)
            {
                _reportHelper = new ReportHelper();
            }
        }
        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }
        public static void SetUserLocationInfo(IpInfo userLocationInfo)
        {
            _userLocationInfo = userLocationInfo;
        }

        public static DatabaseHelper DbHelper => _dbHelper;
        public static FileHelper FileHelper => _fileHelper;
        public static TimezoneHelper TimezoneHelper => _timezoneHelper;
        public static ValidationHelper ValidationHelper => _validationHelper;
        public static User CurrentUser => _currentUser;
        public static LangaugeHelper LanguageHelper => _languageHelper;
        public static IpInfo UserLocationInfo => _userLocationInfo;
        public static ReportHelper ReportHelper => _reportHelper;
    }
}
