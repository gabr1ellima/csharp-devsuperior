using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome User to App
            Console.WriteLine("Welcome to the Greeting Application");
            Console.WriteLine("This application was built by Gabriel Lima");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            // Ask for First Name
            
            string firstName;
            string lastName;

            Console.Write("Write your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Write your Last Name: ");
            lastName = Console.ReadLine();

            // Greet User by Name
            Console.WriteLine();
            Console.WriteLine("Hello " + firstName + " " + lastName + ".");

            Console.WriteLine("Thank you for using my application.");
            Console.ReadLine();
        }
    }
}