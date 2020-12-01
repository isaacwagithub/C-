using System;
using System.Collections;

namespace RandomizeTutorial19112020
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(2);
            arrayList.Add(9);
            arrayList.Add(13);

            Console.WriteLine("ArrayList Capacity is {0}", arrayList.Capacity);
            Console.WriteLine("ArrayList Count is {0}", arrayList.Count);


            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(0, 100);
                Console.WriteLine("The number is {0}",number);
            }
        }
    }
}
