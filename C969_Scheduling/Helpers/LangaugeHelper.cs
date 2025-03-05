using C969_Scheduling.ProcessModels;
using System.Text.Json;

namespace C969_Scheduling.Helpers
{
    public class LangaugeHelper
    {
        private string _userCulture;

        public async Task<string> GetUserCultureAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Call the ipinfo.io API to get the user's location
                    HttpResponseMessage response = await client.GetAsync("https://ipinfo.io/json");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    GlobalHelpers.SetUserLocationInfo(JsonSerializer.Deserialize<IpInfo>(responseBody));

                    _userCulture = GlobalHelpers.UserLocationInfo.Country;

                    // Map the country code to a culture
                    switch (_userCulture)
                    {
                        case "ES":
                            return "es-ES";
                        case "US":
                            return "en-US";
                        // Add more mappings as needed
                        default:
                            return "en-US";
                    }
                }
                catch (Exception)
                {
                    // Default to English if there is an error
                    return "en-US";
                }
            }
        }

        public string SwitchUserCulture()
        {
            switch(_userCulture)
            {
                case "US":
                    _userCulture = "ES";
                    break;
                case "ES":
                    _userCulture = "US";
                    break;
                default:
                    _userCulture = "US";
                    break;
            }

            return _userCulture switch
            {
                "ES" => "es-ES",
                "US" => "en-US",
                _ => "en-US"
            };
        }
    }
}
