using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void GetWeather()
        {
            //Configuration

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string apiKey = configuration.GetSection("AppSettings")["ApiKey"];


            var client = new HttpClient();

            Console.WriteLine("Enter name of city:");
            var cityName = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={"2b512a815297e83d00ff62ea5375e295"}&units=imperial";


            var weatherResponse = client.GetStringAsync(weatherURL).Result;

            var weatherQuote = JObject.Parse(weatherResponse);

            Console.WriteLine($"The weather in {cityName} is {weatherQuote["main"]["temp"]} degrees Fahrenheit");
        }
    }
}
