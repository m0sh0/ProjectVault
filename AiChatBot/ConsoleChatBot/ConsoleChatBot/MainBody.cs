using System.Text;
using ConsoleChatBot.Classes;

namespace ConsoleChatBot
{
    internal class MainBody
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var path1 = AppDomain.CurrentDomain.BaseDirectory;
            //var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Connections.json");
            //var path = "/home/misho/RiderProjects/ProjectVault/AiChatBot/ConsoleChatBot/ConsoleChatBot/JSON/Connections.json";
            
            var content = File.ReadAllText(path, Encoding.UTF8);

            Console.WriteLine(content);
            
            
            ApiService.Get(ConnectionLoader.LoadConnection(0), "Hello!");
        }
    }
}
