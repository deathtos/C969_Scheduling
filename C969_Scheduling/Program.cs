using C969_Scheduling.Helpers;
using C969_Scheduling.ProcessModels;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Runtime;
using System.Text.Json;
using System.Threading;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace C969_Scheduling
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IConfigurationRoot initialSettings = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            AppSettings appsettings = initialSettings.GetRequiredSection("Settings").Get<AppSettings>();

            GlobalHelpers.Initialize(appsettings);

            string userCulture = GlobalHelpers.LanguageHelper.GetUserCultureAsync().Result;
            //string userCulture = GlobalHelpers.LanguageHelper.SetUserCulture();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(userCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(userCulture);

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        
    }
}