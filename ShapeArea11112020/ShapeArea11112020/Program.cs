using System;

namespace ShapeArea11112020
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, radius, height, width;
            int shape;
            string response;

            Control:
            Console.WriteLine("=======================================");
            Console.WriteLine("Calculator For Area Shapes");
            Console.WriteLine("=======================================");
            Console.WriteLine("Choose which shape you want to determine the area of");
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("1 - Rectangle");
            Console.WriteLine("3 - Square");
            Console.WriteLine("4 - Circle");

            shape = Convert.ToInt16(Console.ReadLine());

            if (shape == 1)
            {
                Console.Write("Enter the width: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height: ");
                height = Convert.ToDouble(Console.ReadLine());

                area = TriangleMethod(width, height);

                Console.WriteLine("=======================================");
                Console.WriteLine("The area is: {0}", area);
                Console.WriteLine("=======================================");

            }
            else if (shape == 2)
            {
                Console.Write("Enter the width: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height: ");
                height = Convert.ToDouble(Console.ReadLine());

                area = RectangleMethod(width, height);

                Console.WriteLine("=======================================");
                Console.WriteLine("The area is: {0}", area);
                Console.WriteLine("=======================================");
            }
            else if (shape == 3)
            {
                Console.Write("Enter the width: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height: ");
                height = Convert.ToDouble(Console.ReadLine());

                area = SquareMethod(width, height);

                Console.WriteLine("=======================================");
                Console.WriteLine("The area is: {0}", area);
                Console.WriteLine("=======================================");
            }
            else if (shape == 4)
            {
                Console.Write("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());

                area = CircleMethod(radius);

                Console.WriteLine("=======================================");
                Console.WriteLine("The area is: {0}", area);
                Console.WriteLine("=======================================");

            }
            else 
            {
                Console.WriteLine("Unknown selection. Please try again");
                goto Control;
            }
            Tryagain:
            
            Console.WriteLine("Would you like to calculate again (Y/N) ?");
            response = (Console.ReadLine()).ToLower();
            
            if (response == "y")
            {
                goto Control;
            }
            else if (response == "n")
            {
                Console.WriteLine("Thank you for using the application, Goodbye!");
            }
            else 
            {
                Console.WriteLine("Unknown response. Please try again", ConsoleColor.Red);
                goto Tryagain;
            }

        }

        private static double CircleMethod(double radius)
        {
            return (3.14*(radius * radius));
        }

        private static double SquareMethod(double width, double height)
        {
            return (width * height);
        }

        private static double RectangleMethod(double width, double height)
        {
            return (width * height);
        }

        private static double TriangleMethod(double width, double height)
        {
            return (0.5)*(width * height);
        }
    }
}
