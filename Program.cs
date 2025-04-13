using System;

namespace activity1
{
    class Program
    {
        static void Main(string[] args)

        {
            //initialized indentifiers
            double value1, value2, result;
            string selection;

            Console.WriteLine("Welcome user!\n");

            Console.WriteLine("Simple Calculator\n");
            Console.WriteLine("Operators: \n    Add(1)\n    Subtract(2)\n    Multiply(3)\n    Divide(4)\n    Exit(5)\n\n");

            Console.Write("Choose operation:");
            selection = Console.ReadLine();

            if (selection == "1") // ADD
            {
                Console.Write("Enter first number: ");
                value1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number:");
                value2 = double.Parse(Console.ReadLine());

                result = value1 + value2;

                Console.WriteLine("Output: " + result);

            }
            else if (selection == "2") // SUBTRCT
            {
                Console.Write("Enter first number: ");
                value1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number:");
                value2 = double.Parse(Console.ReadLine());

                result = value1 - value2;

                Console.WriteLine("Output: " + result);
            }
            else if (selection == "3") // MULTIPLY
            {
                Console.Write("Enter first number: ");
                value1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number:");
                value2 = double.Parse(Console.ReadLine());

                result = value1 * value2;

                Console.WriteLine("Output: " + result);
            }
            else if (selection == "4") // DIVIDE
            {
                Console.Write("Enter first number: ");
                value1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number:");
                value2 = double.Parse(Console.ReadLine());

                if (value1 > value2) // checks which of the value is the greater value
                {
                    result = value1 / value2;

                    Console.WriteLine("Output: " + result);

                }
                else
                {
                    result = value2 / value1;

                    Console.WriteLine("Output: " + result);

                }
            }
            else if (selection == "5") // EXIT
            {
                Console.WriteLine("Thank you for using the calculator...");
            }
            else // INVALID PROMPT 
            {
                Console.WriteLine("Input is invalid!");
            }

        }
    }
}
