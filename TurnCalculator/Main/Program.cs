using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> numbersAndLetters = new()
            {
                { '1', 'I' },
                { '2', 'Z' },
                { '3', 'E' },
                { '4', 'H' },
                { '5', 'S' },
                { '6', 'G' },
                { '7', 'L' },
                { '8', 'B' },
                { '9', '-' },
                { '0', 'O' }

            };

            while (true)
            {
                Console.WriteLine("Enter a number and turn the calculator to see if you get a word: ");
                Console.WriteLine("Type 'Exit' to exit the program. ");
                string input = Console.ReadLine();

                if (input == "Exit")
                {
                    break;
                }

                List<char> inputList = new();
                inputList = input.Where(ch => ch != '.').ToList();

                StringBuilder result = new();

                TurnCalc(inputList, result, numbersAndLetters, input);
            }

            Console.WriteLine("See you next time!");

        }

        private static void TurnCalc(List<char> inputList, StringBuilder result, Dictionary<char, char> numbersAndLetters, string input)
        {
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                if (inputList[i] == '1')
                {
                    result.Append(numbersAndLetters['1']);
                }
                else if (inputList[i] == '2')
                {
                    result.Append(numbersAndLetters['2']);
                }
                else if (inputList[i] == '3')
                {
                    result.Append(numbersAndLetters['3']);
                }
                else if (inputList[i] == '4')
                {
                    result.Append(numbersAndLetters['4']);
                }
                else if (inputList[i] == '5')
                {
                    result.Append(numbersAndLetters['5']);
                }
                else if (inputList[i] == '6')
                {
                    result.Append(numbersAndLetters['6']);
                }
                else if (inputList[i] == '7')
                {
                    result.Append(numbersAndLetters['7']);
                }
                else if (inputList[i] == '8')
                {
                    result.Append(numbersAndLetters['8']);
                }
                else if (inputList[i] == '9')
                {
                    result.Append(numbersAndLetters['9']);
                }
                else if (inputList[i] == '0')
                {
                    result.Append(numbersAndLetters['0']);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }

            Console.WriteLine($"{input} => {result}");
            result.Clear();
        }
    }
}