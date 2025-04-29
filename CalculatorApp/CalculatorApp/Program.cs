using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string command;
            do
            {
                Console.WriteLine("Enter a command (add, subtract, multiply, divide) or 'exit' to quit:");
                command = Console.ReadLine().ToLower();

                if (command != "exit")
                {
                    Console.WriteLine("Enter the first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (command)
                    {
                        case "add":
                            result = calculator.Add(num1, num2);
                            break;
                        case "subtract":
                            result = calculator.Subtract(num1, num2);
                            break;
                        case "multiply":
                            result = calculator.Multiply(num1, num2);
                            break;
                        case "divide":
                            if (num2 != 0)
                            {
                                result = calculator.Divide(num1, num2);
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero.");
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid command.");
                            continue;
                    }

                    Console.WriteLine($"Result: {result}");
                }

            } while (command != "exit");
        }
    }
}