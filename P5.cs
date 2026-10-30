using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6_Unit_3_
{
    class BankAccount
    {
        public delegate void BankDelegate();

        public event BankDelegate BankDepositeEvent;
   
        public void Deposite(double amount)
        {
            if (BankDepositeEvent != null)
                BankDepositeEvent();
        }
    }

    class P5
    {
        public static void BankDepositeHandler()
        {
            Console.WriteLine("Event: Money deposited successfully!");
        }
        public static void P5Main()
        {
            BankAccount account = new BankAccount();

            account.BankDepositeEvent += BankDepositeHandler;
            account.Deposite(50000);
            Console.ReadLine();
        }
    }
}
