using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    class P6
    {
        public static void P6Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;
                Console.WriteLine("Division = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
    }

}
