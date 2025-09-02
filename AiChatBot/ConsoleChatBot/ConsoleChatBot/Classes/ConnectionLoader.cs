using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ConsoleChatBot.Classes
{
    public static class ConnectionLoader
    {
        // Loads the URL grom the ConnectionsUrl.json file, located in the JSON folder in the project
        public static string LoadUrl()
        {
            try
            {
                string connectionPath = 
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "ConnectionsUrl.json");

                string jsonContent = File.ReadAllText(connectionPath);

                Connections? connection = 
                    JsonConvert.DeserializeObject<Connections>(jsonContent);
                
                // Check if connection is not null
                if (connection != null)
                    // Return url
                    return connection.Url;

            }
            // Catch any exceptions and write to debug
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            // If we reach here, something went wrong
            throw new Exception("Failed to load url from json");
        }

        //  Reads the api key grom the environment varible GROQ_API_KEY
        public static string LoadApiKey()
        {
            string? apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");
            
            if (!string.IsNullOrEmpty(apiKey))
                return apiKey;

            return "Wrong variable name or no variable assigned.";
            
        }
    }
}
