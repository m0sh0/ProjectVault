using System.Text;
using ConsoleChatBot.Classes;


namespace ConsoleChatBot
{
    internal class MainBody
    {
        static async Task Main(string[] args)
        {
            string url = ConnectionLoader.LoadUrl();
            
            //var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"JSON","ConnectionsUrl.json");
            
            //string content = File.ReadAllText(path, Encoding.UTF8);

            //Console.WriteLine(content);
            string input = Console.ReadLine();
            //string response = await ApiService.GetCode(url, input);
            string response2 = await ApiService.GetCode(url, input);
            //Console.WriteLine(response);
            Console.WriteLine(response2);
            
            

            //string url = ConnectionLoader.LoadUrl();
            //
            //string input = Console.ReadLine();
//
            //string apiResponse = await ApiService.GetCode(url, input);
//
            //Console.WriteLine(apiResponse);


        }
    }
}
