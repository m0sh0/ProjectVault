using System;
using System.IO;
using System.Text.Json;

namespace GroqAiChatbot;

public static class ConnectionLoader
{
    public static string LoadUrl()
    {
        string connectionsPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON", "Connections.json");
        
        string jsonContent =
            File.ReadAllText(connectionsPath);
        
        Connections? connection = JsonSerializer.Deserialize<Connections>(jsonContent);

        return connection?.Url ?? string.Empty;
        

    }
}