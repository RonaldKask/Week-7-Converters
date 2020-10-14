using System;
using System.Transactions;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter c to calculate fahrenheit to celcious, or f  to calculate celcious to fahrenheit.");
            string userInput = Console.ReadLine();
            if (userInput == "c")
            {
                ToCelcious();
            }else
            {
                ToFahrenheit();
            }
        }

        public static void ToCelcious()
        {
            Console.WriteLine("Enter the temperature in F: ");
            int tempF = Int32.Parse(Console.ReadLine());
            double result = (tempF - 32) * 5 / 9;
            Console.WriteLine($"Result in Celcious: {result}");
        }

        public static void ToFahrenheit()
        {
            Console.WriteLine("Enter the temperature in C: ");
            int tempC = Int32.Parse(Console.ReadLine());
            double result = (tempC * 9) / 5 + 32;
            Console.WriteLine($"Result in fahrenheit: {result}");
        }
    }
}
