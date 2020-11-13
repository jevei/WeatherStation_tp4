using Microsoft.Extensions.Configuration;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WeatherApp
{
    static class AppConfiguration
    {
        private static IConfiguration configuration;
        public static string GetValue(string key)
        {
            if(configuration==null)
            {
                initConfig();
                return configuration[key];
            }
            else
            {
                return configuration[key];
            }
        }
        private static void initConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.AddUserSecrets<OpenWeatherProcessor>();
            configuration = builder.Build();
            Console.WriteLine($"La chaîne de connexion est : " + $"{configuration["ConnectionString"]}");
            Debug.WriteLine("The open weather key is : " + $"{configuration["OWApiKey"]}");
        }
    }
}
