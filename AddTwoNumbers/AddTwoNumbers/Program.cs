using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($" {number1} + {number2} = {number1 + number2}");
        }
    }
}
