using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    private static readonly HttpClient client = new HttpClient();
    private const string apiKey = "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";
    private const string apiUrl = "https://api.groq.com/openai/v1/chat/completions";

    static async Task<string> GetAIResponse(string userInput)
    {
        var requestData = new
        {
            model = "llama3-8b-8192",
            messages = new[] { new { role = "user", content = userInput } },
            temperature = 0.7,
            max_tokens = 150
        };

        string jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        try
        {
            var response = await client.PostAsync(apiUrl, content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return $"API Error: {response.StatusCode} - {responseString}";
            }

            dynamic jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);

            
            if (jsonResponse == null || jsonResponse.choices == null || jsonResponse.choices.Count == 0)
            {
                return "Error: No valid response from API.";
            }

            return jsonResponse.choices[0].message.content.ToString();
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    static async Task Main()
    {
        Console.WriteLine("Welcome to your AI chatbot! Type 'exit' to quit.");

        while (true)
        {
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }

            string response = await GetAIResponse(userInput);
            Console.WriteLine("AI: " + response);
        }
    }
}
