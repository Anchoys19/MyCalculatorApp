using System;
using System.Runtime.CompilerServices;

namespace MyCalculatorApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;
            Console.WriteLine("Hello person");
            Console.Write("Enter tne first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a sign(+,-,*,/): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            Console.Write("Enter tne result: ");
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
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}