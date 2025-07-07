using System;

namespace TestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veena");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to TestingProject.");

            int age = 25;
            Console.WriteLine("Age: " + age);

            double height = 6.2;
            Console.WriteLine("Height: " + height + " feet");

            Console.WriteLine("\nIs it raining today? (Yes/No)");
            string answer = Console.ReadLine();
            bool isRaining = answer.ToLower() == "yes";
            Console.WriteLine("Is it raining: " + isRaining);

            if (isRaining)
            {
                Console.WriteLine("Don't forget your umbrella!");
            }
            else
            {
                Console.WriteLine("Great! You don't need an umbrella.");
            }

            double num1 = 8;
            double num2 = 3;

            Console.WriteLine("\nFirst number: " + num1);
            Console.WriteLine("Second number: " + num2);

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            string divisionResult = num2 != 0 ? (num1 / num2).ToString() : "Cannot divide by zero";

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Addition: {sum}");
            Console.WriteLine($"Subtraction: {difference}");
            Console.WriteLine($"Multiplication: {product}");
            Console.WriteLine($"Division: {divisionResult}");
        }
    }
}


