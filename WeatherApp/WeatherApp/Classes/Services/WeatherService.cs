using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Classes.Config;
using WeatherApp.Classes.Models;
using System.Net.Http;
using System.Text.Json;

namespace WeatherApp.Classes.Services
{
    internal class WeatherService
    {
        public static bool Fahrenheit { get; set; }
        public static async Task<Response?> GetWeatherAsync(string city, string units)
        {
            string baseUrl = ConfigLoader.LoadConnection();

            string url = baseUrl.Replace("cityName", city);

            if (Fahrenheit)
            {
                url = url.Replace("metric", units);
            }

            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(url);

            string jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Response?>(jsonResponse);
        }
    }
}
