using System;
using System.Collections.Generic;

namespace GenericsTutorial19112020
{
    class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size) 
        {
            //array = new T(size + 1);
        }
    }
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs) 
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'Y';

            //display values before swap
            Console.WriteLine("Int values before calling swap");
            Console.WriteLine("a = {0} and b = {1}", a,b);
            Console.WriteLine("Char values before calling swap");
            Console.WriteLine("c = {0} and d = {1}", c,d);

            //Call swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            Console.WriteLine("Int values after calling swap");
            Console.WriteLine("a = {0} and b = {1}", a, b);
            Console.WriteLine("Char values after calling swap");
            Console.WriteLine("c = {0} and d = {1}", c, d);


        }
    }
}
