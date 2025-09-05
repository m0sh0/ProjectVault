# ConsoleChatBot ApiService

This is a small C# learning project that demonstrates how to call the [Groq API](https://groq.com/) using `HttpClient` and receive text or code responses from LLM models.

---

## 📂 Project Structure

- **ApiService.cs** – contains methods for sending requests (`GetChat`, `GetCode`) and a shared helper method (`CallApiAsync`) for handling responses.  
- **ConnectionLoader.cs** – loads the API URL from a JSON file and reads the API key from an environment variable.  
- **Connections.cs** – a simple DTO class that stores the `Url` from the JSON file.  

---

## 🔑 API Key Setup

The project expects your Groq API key to be stored in an environment variable named `GROQ_API_KEY`.

### Linux / macOS (bash, zsh)
```bash
export GROQ_API_KEY="your_api_key_here"
```
To make it **persistent**, add this line to your `~/.bashrc` or `~/.zshrc`.

### Windows (PowerShell)
```powershell
setx GROQ_API_KEY "your_api_key_here"
```
After that, restart PowerShell or your computer.

In the code, the key is accessed via:
```csharp
string apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");
```

---

## ⚙️ Example Usage

```csharp
using System;
using System.Threading.Tasks;
using ConsoleChatBot.Classes;

class Program
{
    static async Task Main()
    {
        string url = ConnectionLoader.LoadUrl();

        var response = await ApiService.GetChat(url, "Hello! Can you tell me a fun fact?");
        Console.WriteLine($"Chat response:\n{codeResponse}");

        var codeResponse = await ApiService.GetCode(url, "Write a simple C# Hello World program");
        Console.WriteLine($"Code response:\n{codeResponse");
    }
}
```

---

## 📥 Example Output

```
Chat response:
Did you know that honey never spoils? Archaeologists have found pots of honey in ancient Egyptian tombs that are over 3000 years old and still perfectly edible.

Code response:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

---

## 📝 Notes

- This is an **educational project**, kept intentionally simple for easier understanding.  
- The project can be used as a base for **experiments** – users can create their own `Main` program or build a UI.  
- Model names and parameters (`temperature`, `max_tokens`) can be adjusted depending on your needs.  
