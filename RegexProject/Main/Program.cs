using System;
using System.Text.RegularExpressions;

class RegexProject
{
    // Method to find email in a given text
    public static string FindEmail(string text)
    {
        // Pattern for email
        string pattern = @"[A-za-z]+[0-9]+\@[a-z]+\.[a-z]{2,3}";

        var matchedEmail = Regex.Match(text, pattern);

        // If email is found, return it, otherwise return "No email found"
        if (matchedEmail.Success)
        {
            return$"The email is: {matchedEmail.Value}" ;
        }
        else
        {
            return "No email found";
        }

    }

    static void Main()
    {
        string text = "Hello! My email is student123@gmail.com and my phone number is +359 888-123-456.";
        Console.WriteLine(FindEmail(text)); 
    }
}