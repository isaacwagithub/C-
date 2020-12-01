using System;

namespace StringManipulationTutorial19112020
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = " isaac mokoena God'son ";
            string text2 = "isaac";
            Console.WriteLine($"{text1.Trim().Length}, {text1.Trim()}");
            Console.WriteLine(text1.Substring(1,9));
            Console.WriteLine(text1.StartsWith("i"));
            string[] substring = text1.Split(" ");

            foreach (var item in substring)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(text1.Remove(3));

            if (text1.Equals(text2))
            {
                Console.WriteLine("both texts are the same");
            }
            else 
            {
                Console.WriteLine("Both texts are not the same");
            }
        }
    }
}
