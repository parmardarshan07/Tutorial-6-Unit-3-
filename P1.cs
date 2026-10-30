using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    interface IEmployee
    {
        void GetDetails();
        void ShowEmployeeDetails();
    }
    class Employee : IEmployee
    {
        string name;
        int age;
        string designation;

        public void GetDetails()
        {
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Designation: ");
            designation = Console.ReadLine();
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee Designation: " + designation);
        }
    }

    class P1
    {
        public static void P1Main()
        {
            Employee emp = new Employee();
            emp.GetDetails();
            emp.ShowEmployeeDetails();
        }
    }
}
