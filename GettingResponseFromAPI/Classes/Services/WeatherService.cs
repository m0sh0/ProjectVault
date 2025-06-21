using GettingResponseFromAPI.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GettingResponseFromAPI.GettingData;
using GettingResponseFromAPI.Classes.Config;

namespace GettingResponseFromAPI.Classes.Services
{
    public static class WeatherService
    {
        // Deserializes the JSON response from the weather API into a Response object.
        public static async Task<Response?> GetInfoAsync(string city)
        {
            string baseUrl = ConfigLoader.LoadConnection();

            string url = baseUrl.Replace("cityName", city);

            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(url);

            string json = await response.Content.ReadAsStringAsync();

            return System.Text.Json.JsonSerializer.Deserialize<Response?>(json);
        }
    }
}