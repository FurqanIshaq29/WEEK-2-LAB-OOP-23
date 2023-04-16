using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        class students
        {
            public string name;
            public int rollNumber;
            public float GPA;
        }
        static void Main(string[] args)
        {
         
            taskInput();
            Console.ReadKey();

        }

        static void taskOutput()
        {
            students s1 = new students();
            s1.name = "Bilal";
            s1.rollNumber = 24;
            s1.GPA = 3.4F;
            Console.WriteLine("Name : {0} Roll Number : {1} GPA : {2}", s1.name, s1.rollNumber, s1.GPA);

            students s2 = new students();
            s2.name = "Ali";
            s2.rollNumber = 13;
            s2.GPA = 4.0F;

            Console.WriteLine("Name : {0} Roll Number : {1} GPA : {2}", s2.name, s2.rollNumber, s2.GPA);

            Console.ReadKey();
        }

        static void taskInput()
        {
            students s1 = new students();
            Console.WriteLine("Enter your name : ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter your roll number : ");
            s1.rollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your GPA : ");
            s1.GPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0} Roll Number : {1} GPA : {2}", s1.name, s1.rollNumber, s1.GPA);



        }
    }
}
