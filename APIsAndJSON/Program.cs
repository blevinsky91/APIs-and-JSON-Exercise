using System;
using Microsoft.Extensions.Configuration;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string apiKey = configuration.GetSection("AppSettings")["ApiKey"];




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {RonVSKanyeAPI.Kanye()}");

                Console.WriteLine($"Ron Swanson: {RonVSKanyeAPI.Ron()}");

            }

            OpenWeatherMapAPI.GetWeather();
        }
        
    }
}
