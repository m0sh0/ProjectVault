using System;
using System.Globalization;
using System.Linq;
using System.Text;

/*
 Test cases:

AB[3CD]
IF[2E]LG[5O]D
*/
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your space message (type \"Exit\" if you want to exit the program)");
                Console.Write("your space message here >>>  ");

                // Get input from the user
                string input = Console.ReadLine();

                // Check if the user wants to exit
                if (input == "Exit")
                {
                    Console.WriteLine("See you next time!");
                    break;
                }

                //Extracting the blocks with brackets
                string[] parts = input.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                // StringBiulder for the final message
                StringBuilder message = new();

                // Method for decrypting the message
                DecryptSpaceMessage(parts, message);

                // Print the final message
                Console.WriteLine($"Your message is: {message.ToString().ToUpper()}");
            }
     
        }

        private static void DecryptSpaceMessage(string[] parts, StringBuilder message)
        {
            // Loop through the parts of the message
            for (int i = 0; i < parts.Length; i++)
            {
                // Get the current part
                string part = parts[i];
                string repeatCountAsString = String.Empty;

                // Loop through the characters of the part
                for (int j = 0; j < part.Length; j++)
                {
                    string current = part[j].ToString();

                    // Check if character is a number
                    bool isNumber = int.TryParse(current, out int result);
                    if (isNumber)
                    {
                        repeatCountAsString += current;
                        part = part.Remove(j, 1);
                        j--;
                    }
                }

                // Trying to parse the repeat count
                int repeatCount;
                var parsingSuccessful = int.TryParse(repeatCountAsString, out repeatCount);

                // If parsing is successful, repeat the part
                if (parsingSuccessful)
                {
                    for (int j = 0; j < repeatCount; j++)
                    {
                        message.Append(part);
                    }
                }
                // If parsing is not successful, append the part
                else
                {
                    message.Append(part);
                }

            }
        }
    }
}
