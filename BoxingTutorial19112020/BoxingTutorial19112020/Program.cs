using System;

namespace BoxingTutorial19112020
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            object o = i;   //boxing
            Console.WriteLine(o);

            int j = (int)o; //unboxing
            Console.WriteLine(i);
        }
    }
}
