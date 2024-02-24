using System;

namespace StringVariables
{
    internal class StringVariablesApp
    {
        static void Main(string[] args)
        {
            string firstName = string.Empty; // Standard for a string saying that is an empty string
            string lastName = string.Empty;
            string filePath = string.Empty;

            firstName = "Gabriel";
            lastName = "Lima";

            // filePath = "C:\\Temp\\Demo"; // The next follow character after \ is a scape character

            // @ Everything inside a string is treated as a literal string not as a special character
            filePath = @"C:\Temp\Demo \n";
            // firstName = "123";

            // Console.WriteLine(firstName + " " + lastName);

            string testString = $@"The file for {firstName} is at C:\SampleFiles";

            // String Interpolation
            Console.WriteLine($"Hello {firstName} {lastName}");

            Console.WriteLine(filePath);
            Console.WriteLine(testString);
        }
    }
}