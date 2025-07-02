using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Classes.Models;
using WeatherApp.Properties;

namespace WeatherApp.Classes.Config
{
    public static class ConfigLoader
    {
        //Load the connections strings from the config file
        public static string LoadConnection()
        {
            string jsonContent =
                File.ReadAllText("C:\\Users\\misho\\source\\repos\\m0sh0\\ProjectVault\\WeatherApp\\WeatherApp\\Resources\\Connections.json");

            Connections? connections = System.Text.Json.JsonSerializer.Deserialize<Connections>(jsonContent);

            if (connections != null)
            {
                return connections.GetTemp;
            }

            throw new Exception("Failed to load connections from JSON file.");
        }
    }
}
