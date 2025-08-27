using System.Text;
using ConsoleChatBot.Classes;

namespace ConsoleChatBot
{
    internal class MainBody
    {
        static async Task Main(string[] args)
        {
            string url = ConnectionLoader.LoadConnection();
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"JSON","ConnectionsUrl.json");
            
            string content = File.ReadAllText(path, Encoding.UTF8);

            Console.WriteLine(content);
            string response = await ApiService.Get(url, "Hello how are you?");
            Console.WriteLine(response);
            

        }
    }
}
