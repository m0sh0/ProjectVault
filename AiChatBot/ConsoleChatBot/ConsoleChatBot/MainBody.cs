using System.Text;
using ConsoleChatBot.Classes;


namespace ConsoleChatBot
{
    internal class MainBody
    {
        // You can play around with the capabilities. This is just a demo :)
        static async Task Main(string[] args)
        {
            string url = ConnectionLoader.LoadUrl();
            
            string chatString = Console.ReadLine();
            string response = await ApiService.GetChat(url, chatString);
            
            string codeString = Console.ReadLine();
            string response2 = await ApiService.GetCode(url, codeString);
            
            Console.WriteLine(response);
            Console.WriteLine(response2);
            
        }
    }
}
