using GettingResponseFromAPI.Classes.Models;
using GettingResponseFromAPI.Classes.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GettingResponseFromAPI
{
    internal class GettingData
    {
        private static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome to the weather app!");
            while (true)
            {
                Console.WriteLine("Enter the city from which you want to see the data of(enter 'q' if you want to exit):");

                Console.Write("=> ");
                string input = Console.ReadLine();

                // Check if the user wants to exit
                if (input == "q")
                {
                    Console.WriteLine("Thanks for visiting");
                    return;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter valid city name");
                    continue;
                }

                // Check if the input is empty or whitespace
                Response? response = await WeatherService.GetInfoAsync(input);

                if (response != null)
                {
                    PrintInfo(response, input);
                }
                else
                {
                    Console.WriteLine("Empty json :(");
                }
            }
        }

        public static void PrintInfo(Response? response, string input)
        {
            if (response != null)
            {
                Console.WriteLine($"{input} is located in {response.CountryName.Name} \n");

                Console.WriteLine($"The temperature right now is {response.Main.Temp}°C" +
                                  $" but it feels like {response.Main.FeelsLike}°C \n");

                Console.WriteLine($"The minimum temperature is {response.Main.TempMin}°C" +
                                  $" and the maximum temperature is {response.Main.TempMax}°C\n");

                Console.WriteLine($"The wind speed is {response.Wind.WindSpeed} m/s\n");
                return;
            }

            Console.WriteLine("Empty data");
        }
    }
}