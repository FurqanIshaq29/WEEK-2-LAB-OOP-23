using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsmanagementsystem
{
    class Program
    {
        class students
        {
            public string name;
            public int rollNumber;
            public float GPA;
            public char isHostelite;
            public string department;
        }

        static void Main(string[] args)
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }

                else if (option == '2')
                {
                    viewStudents(s, count);
                }
                else if (option == '3')
                {
                    topStudents(s, count);
                }
                else if (option == '4')
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid choice");
                }


            } while (option != '4');
            Console.WriteLine("Press Enter to EXIT ");
            Console.ReadKey();
        }

        static char menu()
        {
            char option;
            Console.WriteLine("Press 1 to add students");
            Console.WriteLine("Press 2 to View students");
            Console.WriteLine("Press 3 to topstudents");
            Console.WriteLine("Press 4 to exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static students addStudent()
        {
            Console.Clear();
            students s1 = new students();
            Console.WriteLine("Enter the Name : ");
            s1.name = Console.ReadLine();

            Console.WriteLine("Enter your Roll Number : ");
            s1.rollNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Gpa:");
            s1.GPA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your department : ");
            s1.department = Console.ReadLine();

            Console.WriteLine("Is hostelite(y || n) : ");
            s1.isHostelite = char.Parse(Console.ReadLine());

            return s1;


        }

        static void viewStudents(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Fount");

            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name : {0}  Roll Number : {1}  GPA : {2}  Department : {3}  Hostelite : {4}", s[i].name, s[i].rollNumber, s[i].GPA, s[i].department, s[i].isHostelite);
                Console.WriteLine("Press enter to continue .......");
            }
            Console.ReadKey();

        }

        static void topStudents(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Fount");

            }

            else if (count == 1)
            {
                viewStudents(s, 1);

            }

            else if (count == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    int index = largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;

                }
                viewStudents(s, 2);
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                viewStudents(s, 3);
            }
            Console.ReadKey();

        }
        static int largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].GPA;
            for (int i = start; i < end; i++)
            {
                if (large < s[i].GPA)
                {
                    large = s[i].GPA;
                    index = i;
                }
            }
            return index;

        }
    }
}
