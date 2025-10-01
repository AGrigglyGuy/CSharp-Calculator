using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Welcome to this calculator app.");
            Console.WriteLine("Please enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please wenter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the operator to use (+, -, *, /)");
            char operatorEquation = Convert.ToChar(Console.ReadLine());

            int result;
            if (operatorEquation == '+')
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"The equation {firstNumber} + {secondNumber} = {result}");
            }
            if (operatorEquation == '-')
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"The equation {firstNumber} - {secondNumber} = {result}");
                if (operatorEquation == '*')
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The equation {firstNumber} * {secondNumber} = {result}");
                    if (operatorEquation == '/')
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("You can't divide by zero! You're going to break the laws of mathematics!");
                            
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"The equation {firstNumber} / {secondNumber} = {result}");
                        }

                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
