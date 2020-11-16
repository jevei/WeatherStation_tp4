using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Services
{
    public class OpenWeatherService : ITemperatureService
    {
        private OpenWeatherProcessor owp;
        public TemperatureModel LastTemp;
        public OpenWeatherService(string apiKey)
        {
            owp = new OpenWeatherProcessor();
            owp.ApiKey = apiKey;
        }

        public async Task<TemperatureModel> GetTempAsync()
        {
            var weather = await owp.GetCurrentWeatherAsync();
            TemperatureModel temp = new TemperatureModel();
            DateTime t = DateTime.UnixEpoch;
            t = t.AddSeconds(weather.DateTime);
            t = t.ToLocalTime();
            temp.DateTime = t;
            temp.Temperature = weather.Main.Temperature;
            LastTemp = temp;
            return temp;
        }
    }
}
