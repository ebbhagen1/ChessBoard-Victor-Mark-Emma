
using System;

class Program
{
    static void Main(string[] args)
    {
        // Example: read text from the console and parse to int safely
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int value))
        {
            Console.WriteLine($"You entered: {value}");
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter only digits.");
        }

        // Another example: parsing a known string without throwing exceptions
        string s = "123";
        if (int.TryParse(s, out int parsed))
        {
            Console.WriteLine($"Parsed from string: {parsed}");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
