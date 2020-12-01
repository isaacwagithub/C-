using System;

namespace InheritanceSimpler16112020
{
    
    class Student 
    {
        public int studentNumber;
        public string Surname,firstName,course;
        public int mark1, mark2, mark3, mark4, mark5;
        public int totalMarks() 
        {
            return (mark1 + mark2 + mark3 + mark4 + mark5);
        }

    }
    class Report : Student
    { 
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program which implements inheritance. 
             * The program should inherit the properties of the first shape  
             */
            Report report = new Report();//Creating a report object

            Console.WriteLine("Enter student number: ");
            report.studentNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter surname: ");
            report.Surname = Console.ReadLine();

            Console.WriteLine("Enter first names: ");
            report.firstName = Console.ReadLine();

            Console.WriteLine("Enter course: ");
            report.course = Console.ReadLine();
            
            Console.WriteLine("Enter mark 1: ");
            report.mark1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter mark 2: ");
            report.mark2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter mark 3: ");
            report.mark3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter mark 4: ");
            report.mark4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter mark 5: ");
            report.mark5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total Marks: {0}",report.totalMarks());
            
        }
    }
}
