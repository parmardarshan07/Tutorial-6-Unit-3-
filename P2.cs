using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    interface IPersonalDetails        
    {
        void GetPersonalDetails();
        void ShowPersonalDetails();
    }

    interface IProfessionalDetails
    {
        void GetProfessionalDetails();
        void ShowProfessionalDetails();
    }

    class Employee1 : IPersonalDetails, IProfessionalDetails
    {
        string name;
        int age;
        string designation;
        double salary;

        public void GetPersonalDetails()
        {
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowPersonalDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Age: " + age);
        }

        public void GetProfessionalDetails()
        {
            Console.WriteLine("Enter Employee Designation: ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowProfessionalDetails()
        {
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    class P2
    {
        public static void P2Main()
        {
            Employee1 emp = new Employee1();
            emp.GetPersonalDetails();
            emp.GetProfessionalDetails();
            emp.ShowPersonalDetails();
            emp.ShowProfessionalDetails();
        }
    }
}
