// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Welcome to this calculator app.");
            Console.WriteLine("Please enter the first number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the operator to use (+, -, *, /)");
            char operatorEquation = Convert.ToChar(Console.ReadLine());

            decimal result;
            if (operatorEquation == '+')
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"The equation {firstNumber} + {secondNumber} = {result}");
            }
            if (operatorEquation == '-')
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"The equation {firstNumber} - {secondNumber} = {result}");
               
                }
                 if (operatorEquation == '*')
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The equation {firstNumber} * {secondNumber} = {result}");
                }
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
                    Console.WriteLine("Thank you for using this calculator app. Goodbye!");
            }
        }
    }


