using System;

namespace Inheritance16112020
{
    class Shape 
    {
        public void setWidth(int w) 
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    //Derived class
    class Rectangle : Shape 
    {
        public int getArea() 
        {
            return (width * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            
            Console.WriteLine("Enter the height of the rectangle: ");
            rectangle.setHeight(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter the height of the rectangle: ");
            rectangle.setWidth(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The area of the rectangle is: {0}", rectangle.getArea());
        }
    }
}
