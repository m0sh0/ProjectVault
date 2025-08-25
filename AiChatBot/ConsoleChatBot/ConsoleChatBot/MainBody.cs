using ConsoleChatBot.Classes;

namespace ConsoleChatBot
{
    internal class MainBody
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Connections.json");
            var content = File.ReadAllText(path);
            
            
            ApiService.Get(ConnectionLoader.LoadConnection(0), "Hello!");
        }
    }
}
