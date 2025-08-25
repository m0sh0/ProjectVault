using System.Text.Json.Serialization;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleChatBot.Classes;

public static class ApiService
{
    public static async Task<string> Get(string url, string input)
    {
        HttpClient client = new();
        string apiKey = ConnectionLoader.LoadConnection(1);
        
        var requestData = new
        {
            model = "llama3-8b-8192",
            messages = new[] { new { role = "user", content = input } },
            temperature = 1,
            max_tokens = 1
        };
        
        string jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        try
        {
            var response = await client.PostAsync(url, content);
            string responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return $"API Error: {response.StatusCode} - {responseString}";
            
            
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        return null;
    }
}