using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    delegate void Calculate(int x, int y); //Declaration

    class P3
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Additon: " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }
        public static void Multi(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }
        public static void P3Main()
        {
            Calculate obj = new Calculate(Add); //Instatiation
            obj += new Calculate(Sub);
            obj += Multi;
            obj += Div;
            // Add(15,5);
            obj(15, 5); //Invocation (calling Add,Sub,Multi,Div Methods )

            Console.Read();
        }
    }
}
