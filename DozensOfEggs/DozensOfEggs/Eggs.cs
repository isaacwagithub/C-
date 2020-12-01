using System;

namespace DozensOfEggs
{
    class Eggs
    {
        static void Main(string[] args)
        {
            int numberOfEggs;
            Console.WriteLine("Please enter value for the number of eggs ");
            numberOfEggs = Convert.ToInt32(Console.ReadLine());

            DozenOfeggs(numberOfEggs);
        }

        public static void DozenOfeggs(int numberOfEggs) 
        {
            int Dozen = numberOfEggs / 12;
            int remainder = numberOfEggs % 12;

            if (remainder == 1)
            {
                Console.WriteLine($"{numberOfEggs} eggs is {Dozen} full dozen with {remainder} egg remaining ");

            }

            else if (remainder >= 2)
            {
                Console.WriteLine($"{numberOfEggs} eggs is {Dozen} full dozen with {remainder} eggs remaining ");
            }
            else 
            {
                Console.WriteLine($"{numberOfEggs} eggs is {Dozen} full dozen with no remainder of eggs");
            }
        }

    }
}
