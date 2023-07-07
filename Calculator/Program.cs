using System;
using System;
using System;
using System.Runtime.CompilerServices;

namespace MyCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Hello person");
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter a sign (+, -, *, /, ^): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    double result = 0;
                    double num2;

                    switch (operation)
                    {
                        case '+':
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter the second number: ");
                                    num2 = Convert.ToDouble(Console.ReadLine());
                                    result = num1 + num2;
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                                }
                            }
                            break;
                        case '-':
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter the second number: ");
                                    num2 = Convert.ToDouble(Console.ReadLine());
                                    result = num1 - num2;
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                                }
                            }
                            break;
                        case '*':
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter the second number: ");
                                    num2 = Convert.ToDouble(Console.ReadLine());
                                    result = num1 * num2;
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                                }
                            }
                            break;
                        case '/':
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter the second number: ");
                                    num2 = Convert.ToDouble(Console.ReadLine());
                                    result = num1 / num2;
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                                }
                            }
                            break;
                        case '^':
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter the exponent: ");
                                    num2 = Convert.ToDouble(Console.ReadLine());
                                    result = Math.Pow(num1, num2);
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong operation");
                            break;
                    }
                    Console.WriteLine("Result is: " + result);
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number format. Please enter a valid number.");
                }
            }
        }
    }
}