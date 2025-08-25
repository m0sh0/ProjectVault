using ConsoleChatBot.Classes;

namespace ConsoleChatBot
{
    internal class MainBody
    {
        static void Main(string[] args)
        {
            ApiService.Get(ConnectionLoader.LoadConnection(0), "Hello!");
        }
    }
}
