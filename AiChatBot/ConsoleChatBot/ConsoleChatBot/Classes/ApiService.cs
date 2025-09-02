using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//if ou want you can switch the lm in the model property ig the requestData variable

//For chat completion
/*
 llama-3.3-70b-versatile
 openai/gpt-oss-120b
*/

//For code generation
/*
 openai/gpt-oss-20b
 compound-beta
 openai/gpt-oss-120b 
*/

// check out more on the docs "https://console.groq.com/docs/models"


// This is a static api service class that has methods for getting data grom the groq api. 
// It uses the http client and returns the content of the response as a string.
 
namespace ConsoleChatBot.Classes;
public static class ApiService
{
    private static readonly HttpClient Client = new() {Timeout = TimeSpan.FromSeconds(10)};
    private static readonly string ApiKey = ConnectionLoader.LoadApiKey();

    public static async Task<string> CallApiAsync(object requestData, string url)
    {
        // Serializing the request data (anonymous object) into a JSON string
        string jsonRequest = JsonConvert.SerializeObject(requestData);
        
        // Creating a http post content from the JSON
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        
        // Meaking the api key as a heder for auth
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        
        try
        {
            // Sending POST request
            var response = await Client.PostAsync(url, content);
            
            // Reading the reposnse from the api as a stirng
            string responseString = await response.Content.ReadAsStringAsync();
            
            // If the response has a different code from 2xx we return an error
            if (!response.IsSuccessStatusCode)
                return $"API Error: {response.StatusCode} - {responseString}";
            
            // Deserializing the JSON answer as a dynamic object
            var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
            
            // Checking if we have a valid choices array
            if (jsonResponse == null || jsonResponse.choices == null || jsonResponse.choices.Count == 0)
                return "Error no valid response from API.";
            
            // Return the content of the message
            return jsonResponse.choices[0].message.content;
        }
        catch (Exception e)
        {
            return $"Error {e.Message}";
        }
    }
    public static async Task<string> GetChat(string url, string input)
    {
        // Making an object for the request data for normal chat
        var requestData = new
        {
            // Which model the api should use
            model = "openai/gpt-oss-120b",
            
            // Array with one user message
            messages = new[] { new { role = "user", content = input } },
            
            // Parameters for randomness an variety in the response
            temperature = 1,
            max_tokens = 150
        };
        
        return await CallApiAsync(requestData, url);
        
    }

    public static async Task<string> GetCode(string url, string input)
    {
        // Making an object for the code generation
        var requestData = new
        {
            // You can change the parameters depending on the responses you want
            model = "compound-beta-mini",
            
            messages = new[]
            {
                new
                {
                    role = "user",
                    content = input
                }
            },
        };
        
        return await CallApiAsync(requestData, url);
    }
}