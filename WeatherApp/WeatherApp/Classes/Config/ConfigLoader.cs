using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Classes.Models;
using WeatherApp.Properties;
using System.Diagnostics;

namespace WeatherApp.Classes.Config
{
    public static class ConfigLoader
    {
        //Load the connections strings from the config file
        public static string LoadConnection()
        {
            // Get the path to the JSON file containing the connections
            try
            {
                string connectionsPath =
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Connections.json");

                string jsonContent =
                    File.ReadAllText(connectionsPath);

                Connections? connections = System.Text.Json.JsonSerializer.Deserialize<Connections>(jsonContent);

                if (connections != null)
                {
                    return connections.GetTemp;
                }
            }
            // Catch any exceptions that occur while reading the file or deserializing the JSON
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
            
            throw new Exception("Failed to load connections from JSON file.");
        }
    }
}
