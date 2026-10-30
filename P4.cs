using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    delegate void StudentDetails();

    class Student1
    {
        public static void DisplayName()
        {
            Console.WriteLine("Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Student Name: " + name);
        }
        public static void DisplayCourse()
        {
            Console.WriteLine("Student Course:");
            string course = Console.ReadLine();
            Console.WriteLine("Student Course: " + course);
        }
        public static void DisplaySem()
        {
            Console.WriteLine("Student Semester:");
            string sem = Console.ReadLine();
            Console.WriteLine("Student Semester: " + sem);
        }
    }

    class P4
    {
        public static void P4Main()
        {
            StudentDetails obj;
                
            obj = Student1.DisplayName;
            obj += Student1.DisplayCourse;
            obj += Student1.DisplaySem;
            obj(); //Invocation (calling DisplayName,DisplayCourse,DisplaySem Methods )
            Console.Read();
        }
    }
}
