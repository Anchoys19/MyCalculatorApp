﻿using System;
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
                    Console.Write("Enter tne first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter a sign(+,-,*,/): ");
                    char operation = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = 0;
                    Console.Write("Result is: ");
                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Wrong operation");
                            break;
                    }
                    Console.WriteLine(result);
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