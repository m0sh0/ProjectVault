using System;

internal class PatternDrawing
{
    private static void Main(string[] args)
    {
        bool restart = true;
        while (restart) // Loop for restarting the program
        {
            // Step 1: Display a menu to the user
            Console.WriteLine("Welcome to the C# Pattern Drawing Program!");
            Console.WriteLine("Choose a pattern type:");
            Console.WriteLine("1. Right-angled Triangle");
            Console.WriteLine("2. Square with Hollow Center");
            Console.WriteLine("3. Diamond");
            Console.WriteLine("4. Left-angled Triangle");
            Console.WriteLine("5. Pyramid");
            Console.WriteLine("6. Reverse Pyramid");
            Console.WriteLine("7. Heart");
            Console.WriteLine("8. Rectangle with Hollow Center");

            // Step 2: Get the user's choice
            Console.Write("Enter the number corresponding to your choice: ");
            int choice = int.Parse(Console.ReadLine());

            // Step 3: Get dimensions based on choice
            int rows = 0, width = 0, height = 0;
            if (choice >= 1 && choice <= 7)
            {
                Console.Write("Enter the amount of rows: ");
                rows = int.Parse(Console.ReadLine());
            }
            else if (choice == 8)
            {
                Console.Write("Enter the height of the rectangle: ");
                height = int.Parse(Console.ReadLine());

                Console.Write("Enter the width of the rectangle: ");
                width = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Do you want to restart the program? (y/n)");

                string restartChoice = Console.ReadLine();
                if (restartChoice.ToLower() != "y")
                {
                    Console.WriteLine("Sad to see you go :( Goodbye!");
                    break;
                }
                else
                {
                    continue;
                }
            }

            // Step 4: Generate the selected pattern
            switch (choice)
            {
                case 1: // Right-angled Triangle
                    PrintRightAngledTriangle(rows);

                    restart = false;
                    break;

                case 2: // Square with Hollow Center
                    PrintSquareWithHollowCenter(rows);

                    restart = false;
                    break;

                case 3: // Diamond
                    PrintDiamond(rows);

                    restart = false;
                    break;

                case 4: // Left-angled Triangle
                    PrintLeftAngledTriangle(rows);

                    restart = false;
                    break;

                case 5: // Pyramid
                    PrintPyramid(rows);

                    restart = false;
                    break;

                case 6: //  Reverse pyramid
                    PrintReversePyramid(rows);

                    restart = false;
                    break;

                case 7: // Heart
                    PrintHeart(rows);

                    restart = false;
                    break;

                default:
                    Console.WriteLine("❌ Invalid choice! Please restart the program.");
                    break;
            }
        }
    }

    private static void PrintRightAngledTriangle(int rows)
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    private static void PrintSquareWithHollowCenter(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if (i == 0 || i == rows - 1 || j == 0 || j == rows - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintDiamond(int rows)
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }

    private static void PrintLeftAngledTriangle(int rows)
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = rows; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    private static void PrintPyramid(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int x = i; x <= rows; x++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }

    private static void PrintReversePyramid(int rows)
    {
        for (int i = rows; i >= 0; i--)
        {
            for (int x = i; x <= rows; x++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }

    private static void PrintHeart(int rows)
    {
        for (int i = rows / 2; i <= rows; i += 2)
        {
            for (int j = 1; j < rows - i; j += 2)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = rows; i >= 1; i--)
        {
            for (int j = i; j < rows; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (i * 2) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}