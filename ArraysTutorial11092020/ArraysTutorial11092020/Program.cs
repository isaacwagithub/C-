using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTutorial11092020
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cars = new string[8]{ "volvo", "bmw", "ford", "mazda", "mercedes benz", "hammer", "super bike", "nissan" };
            Array.Sort(cars);
            int[] numbers = { 1,2,3,4,5,6,7,8,9};
            Console.WriteLine("=======For loop==========");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("=======Foreach loop==========");

            foreach (string car in cars)
            {
                Console.WriteLine(car);

            }
            Console.WriteLine("=======Max, Min and Sum==========");
            Console.WriteLine("The maximum value is: "+numbers.Max());
            Console.WriteLine("The minimum value is: " + numbers.Min());
            Console.WriteLine("The sum is: " + numbers.Sum());
            Console.ReadLine();

        }
    }
}
