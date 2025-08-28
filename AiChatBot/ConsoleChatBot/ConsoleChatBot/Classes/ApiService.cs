using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//if ou want you can switch the lm in the model property ig the requestData variable

/*
 llama-3.3-70b-versatile
 openai/gpt-oss-120b
*/

// check out more on the docs "https://console.groq.com/docs/models"
 
namespace ConsoleChatBot.Classes;
public static class ApiService
{
    private static readonly HttpClient Client = new() {Timeout = TimeSpan.FromSeconds(10)};
    private static readonly string ApiKey = ConnectionLoader.LoadApiKey();
    public static async Task<string> Get(string url, string input)
    {
        // Generate the request data 
        var requestData = new
        {
            model = "llama-3.1-8b-instant",
            messages = new[] { new { role = "user", content = input } },
            temperature = 1,
            max_tokens = 150
        };
        
        string jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        
        try
        {
            var response = await Client.PostAsync(url, content);
            string responseString = await response.Content.ReadAsStringAsync();
            

            if (!response.IsSuccessStatusCode)
                return $"API Error: {response.StatusCode} - {responseString}";
            
            var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
            
            if (jsonResponse == null || jsonResponse.choices == null || jsonResponse.choices.Count == 0)
                return "Error no valid response from API.";
            
            return jsonResponse.choices[0].message.content.ToString();
        }
        catch (Exception e)
        {
            return $"Error {e.Message}";
        }
        
    }

    public static async Task<string> GetCode(string url, string input)
    {
        
        var requestData = new
        {
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
        
        string jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        try
        {
            var response = await Client.PostAsync(url, content);
            
            string responseString = await response.Content.ReadAsStringAsync();
            
            if (!response.IsSuccessStatusCode)
                return $"API Error: {response.StatusCode} - {responseString}";

            
            var  jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
            
            if (jsonResponse == null || jsonResponse.choices == null || jsonResponse.choices.Count == 0)
                return "Error no valid response from API.";
            
            
            return jsonResponse.choices[0].message.content;

        }
        catch (Exception e)
        {
            return $"Error {e.Message}";
        }
        
    }

  //public static Task<string> GetObject(string url, string input)
  //{
  //    var requestData = new
  //    {
  //        model = "llama-3.1-8b-instant",
  //        messages = new[] { new { role = "user", content = input } },
  //        temperature = 1,
  //        max_tokens = 150
  //    };
  //    return SendRequestAsync(url, requestData);
  //}

  //public static Task<string> GetCodeObject(string url, string input)
  //{
  //    var requestData = new
  //    {
  //        model = "compound-beta-mini",
  //        messages = new[]
  //        {
  //            new
  //            {
  //                role = "user",
  //                content = input
  //            }
  //        },
  //    };
  //    
  //    return SendRequestAsync(url, requestData);
  //}
  //public static async Task<string> SendRequestAsync(string url, object requestData)
  //{
  //    // Generate the request data 

  //    
  //    string jsonRequest = JsonConvert.SerializeObject(requestData);
  //    var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
  //    
  //    Client.DefaultRequestHeaders.Clear();
  //    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
  //    
  //    try
  //    {
  //        var response = await Client.PostAsync(url, content);
  //        string responseString = await response.Content.ReadAsStringAsync();
  //        

  //        if (!response.IsSuccessStatusCode)
  //            return $"API Error: {response.StatusCode} - {responseString}";
  //        
  //        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
  //        
  //        if (jsonResponse == null || jsonResponse.choices == null || jsonResponse.choices.Count == 0)
  //            return "Error no valid response from API.";
  //        
  //        return jsonResponse.choices[0].message.content;
  //    }
  //    catch (Exception e)
  //    {
  //        return $"Error {e.Message}";
  //    }
  //    
  //}
}