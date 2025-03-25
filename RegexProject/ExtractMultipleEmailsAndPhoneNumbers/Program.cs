using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
/*
Contact us at support@company.com or sales@business.net.
For urgent inquiries, call +1-555-678-9999 or +44 123 4567 890.
 */
class RegexProject
{
    //Method to find valid emails and phone numbers in text
    public static Dictionary<string, List<string>> ExtractEmailsAndPhones(string text)
    {
        //Regex patterns
        string emailPattern = @"[A-Za-z0-9]+\@[A-Za-z0-9]+\.[a-z]{2,}";
        string phonePattern = @"\+[0-9]{1,}([ -])[0-9]{3}\1[0-9]{3,4}\1[0-9]{3,4}";

        //Lists for emails and phones
        List<string> emails = new();
        List<string> phones = new();

        //Collections for matches
        MatchCollection emailMatches = Regex.Matches(text, emailPattern);
        MatchCollection phoneMatches = Regex.Matches(text, phonePattern);

        //Adding the phones and emails to the lists
        foreach (Match email in emailMatches)
        {
            emails.Add(email.Value);
        }

        foreach (Match phone in phoneMatches)
        {
            phones.Add(phone.Value);
        }

        //Make a dictionary with the phones and emails
        Dictionary<string, List<string>> emailsAndNumbers = new()
        {
            {"emails", emails},
            {"phones", phones}
        };

        return emailsAndNumbers;

    }

    static void Main()
    {
        //Get user input
        string text = Console.ReadLine();

        Dictionary<string, List<string>> emailsAndPhones = ExtractEmailsAndPhones(text);

        //Print the result
        foreach (var pair in emailsAndPhones)
        {
            Console.Write($"{pair.Key}: [{string.Join(", ",pair.Value)}] ");
        }

       
    }
}