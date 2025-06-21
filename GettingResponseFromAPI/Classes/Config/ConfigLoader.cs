using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingResponseFromAPI.Classes.Models;
using static GettingResponseFromAPI.GettingData;

namespace GettingResponseFromAPI.Classes.Config
{
    public static class ConfigLoader
    {
        // Loads the connection string from a JSON file and returns the URL for fetching weather data.
        public static string LoadConnection()
        {
            string jsonContent =
                File.ReadAllText("D:\\CSharpLearning\\CSharpLearning\\GettingResponseFromAPI\\Connections.json");
            Conections? connections = JsonConvert.DeserializeObject<Conections>(jsonContent);

            if (connections != null)
            {
                return connections.GetTemp;
            }

            throw new Exception("Failed to load connections from JSON file.");
        }
    }
}