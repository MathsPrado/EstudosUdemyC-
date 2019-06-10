using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "matheus", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Prado", 500.0, 500));
            list.Add(new SavingsAccount(1003, "Boby", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Lima", 500.0, 500));

            double total = 0;

            foreach (Account acc in list)
            {
                total += acc.Balance;
            }
            Console.WriteLine("Total Balance:" + total);

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("conta" + acc.Number + ",Saldo atualizado" + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
