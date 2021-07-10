using System;

namespace Calcutator
{
    class Program
    {
        static void Menu()
        {

            for (int i = 0; i < 2; i--)
            {
                Console.WriteLine("Welcome to primitive calculator. Enjoy");

                Console.WriteLine("Choose operation:  ");
                Console.WriteLine("For Addition enter 1");
                Console.WriteLine("For Subtraction enter 2");
                Console.WriteLine("For Multiplication enter 3");
                Console.WriteLine("For Division enter 4");

                Console.Write("Enter your chosen number from menu:  ");
                int menu = Int32.Parse(Console.ReadLine());

                Console.Write("Enter first number:  ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number:  ");
                double num2 = double.Parse(Console.ReadLine());

                

                switch (menu)
                {
                    case 1:
                        Console.WriteLine($"Result is: {Operations.Add(num1, num2)}");
                        Console.WriteLine("**//////////:::::::::://////////:::::::::**");
                        break;
                    case 2:
                        Console.WriteLine($"Result is: {Operations.Sub(num1, num2)}");
                        Console.WriteLine("**//////////:::::::::://////////:::::::::**");
                        break;
                    case 3:
                        Console.WriteLine($"Result is: {Operations.Mul(num1, num2)}");
                        Console.WriteLine("**//////////:::::::::://////////:::::::::**");
                        break;
                    case 4:
                        Console.WriteLine($"Result is: {Operations.Div(num1, num2)}");
                        Console.WriteLine("**//////////:::::::::://////////:::::::::**");
                        break;
                }
            }

            
        }


        static void Main(string[] args)
        {
            Menu();
        }
    }
}
