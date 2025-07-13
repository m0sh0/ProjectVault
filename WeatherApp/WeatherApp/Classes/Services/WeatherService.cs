using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Classes.Config;
using WeatherApp.Classes.Models;
using System.Net.Http;
using System.Text.Json;
using System.Diagnostics;

namespace WeatherApp.Classes.Services
{
    internal class WeatherService
    {
        public static bool Fahrenheit { get; set; }
        public static async Task<Response?> GetWeatherAsync(string city)
        {
            string baseUrl = ConfigLoader.LoadConnection();

            // Replace "cityName" in the URL with the actual city name
            string url = baseUrl.Replace("cityName", city);

            // Replace "FOrC" with "imperial" or "metric" based on the Fahrenheit setting
            if (Fahrenheit)
                url = url.Replace("FOrC", "imperial");
            else
                url = url.Replace("FOrC", "metric");
            
            HttpClient client = new();

            // Set a timeout for the request
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Ensure the request was successful

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Response?>(jsonResponse);
            }
            // Catch any exceptions that occur during the request
            catch (HttpRequestException e)
            {
                Debug.WriteLine($"Request error: {e.Message}");
                throw;
            }
            
        }
    }
}
