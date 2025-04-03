using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string demo = Console.ReadLine();
            var a = int.TryParse(demo, out int result);

            Console.WriteLine(a);
            
        }
    }
}
