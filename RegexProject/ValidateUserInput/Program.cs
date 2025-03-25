using System;
using System.Text.RegularExpressions;

class RegexProject
{
    public static bool ValidateEmail(string email)
    {

        string emailPattern = @"[a-z]+\@[a-z]+\.[a-z].[com]";

        Match emailMatch = Regex.Match(email, emailPattern);


        if (emailMatch.Success)
        {
            
            return true;
        }

        
        return false;

    }

    public static bool ValidatePassword(string password)
    {
        string passwordPattern = @"(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[^a-zA-Z]).{8,}";

        Match passwordMatch = Regex.Match(password, passwordPattern);

        if (passwordMatch.Success)
        {
            return true;
               
        }

        return false;
        
    }

    static void Main()
    {
        int e = 0;
        while (e == 0)
        {
            Console.WriteLine("Enter an email. The format should be [example@domain.com.]");
            Console.Write("-> ");
            string email = Console.ReadLine();

            if (ValidateEmail(email))
            {
                Console.WriteLine($"The email [{email}] is valid!");
                e++;
            }
            else
            {
                Console.WriteLine($"The email [{email}] is invalid! Try again!");
            }
        }

        Console.WriteLine();

        int p = 0;
        while (p == 0)
        {
            Console.WriteLine("Enter a password. A strong password must:");
            Console.WriteLine("-> Be at least 8 characters long");
            Console.WriteLine("-> Contain one uppercase letter");
            Console.WriteLine("-> Contain one number");
            Console.WriteLine("-> Contain one special character (@$!%*?&)");

            Console.Write("-> ");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine($"The password [{password}] is valid!");
                p++;
            }
            else
            {
                Console.WriteLine($"The password [{password}] is invalid!");
            }
        }
    



        

    }
}