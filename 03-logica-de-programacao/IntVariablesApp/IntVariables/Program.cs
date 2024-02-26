using System;

namespace IntVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yes - 2, 18, 2854, -9
            // No - 1.2, -5.7

            int age = 0;
            // Int64 age = 0; Int33 is twice as mush as int or Int32 than Int64 is many time bigger than Int32

            age = 25;

            int ageInTenYears = age + 10;

            // Two billion +/-
            // signed Int32
            // unsigned - 4 billion
            // bit - 0 or 1
            // byte - 8 bits - 00000000
            
            Console.WriteLine(age);
            Console.WriteLine(ageInTenYears);

            // Don't divide ints - Console.WriteLine(age / 2);
        }
    }
}