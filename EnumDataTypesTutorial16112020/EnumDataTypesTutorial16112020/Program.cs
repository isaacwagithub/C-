using System;

namespace EnumDataTypesTutorial16112020
{
    class Car
    {
        public string color = "red";
        public int maxSpeed = 200;

        public void fullThrotle()
        {
            Console.WriteLine("The car is going as fast as it can! ");
        }
    }
    class Program
    {
        enum Color { yellow, orange, red, green, blue, purple, black };
        enum Months : byte { january,february,march,april,may,june,july,august,september,october,novenber,december};
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.color);
            Console.WriteLine(car.maxSpeed);
            car.fullThrotle();

            Console.WriteLine("Read names of the color enum");
            Console.WriteLine("Choose a number from 1 - 12");
            int mnth = Convert.ToInt32(Console.ReadLine());
            mnth -= 1;
            string s = Enum.GetName(typeof(Months),mnth);
            Console.WriteLine("This is "+s+" month");
            foreach (string color in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine(color);
            }
        }
    }
}
