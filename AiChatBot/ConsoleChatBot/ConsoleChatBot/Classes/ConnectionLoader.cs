using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChatBot.Classes
{
    public static class ConnectionLoader
    {
        public static string LoadConnection(int connectionNumber)
        {
            try
            {
                string connectionPath = 
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "Connections.json");

                string jsonContent = File.ReadAllText(connectionPath);

                Connections? connection = 
                    System.Text.Json.JsonSerializer.Deserialize<Connections>(jsonContent);
                // Check if connection is not null
                if (connection != null)
                    // Return url or key based on connectionNumber
                    switch (connectionNumber)
                    {
                        case 0: return connection.Url;
                        case 1: return connection.Key;
                    }
            }
            // Catch any exceptions and write to debug
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            // If we reach here, something went wrong
            throw new Exception("Failed to load url from json");
        }
    }
}
