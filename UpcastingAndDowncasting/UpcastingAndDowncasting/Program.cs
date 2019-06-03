using System;
using UpcastingAndDowncasting.Entities;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Matheus", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Ronladinho", 0.0, 500.0);

            // UPCASTING ( Recebe um objeto de qualuqer tipo de sub-classe dela)

            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1003, "Hazard", 0.0, 200.0);

            Console.WriteLine(acc2.Number + "," + acc2.Holder + "," + acc2.Balance);

            Account acc3 = new SavingsAccount(1004, "Eren", 0.0, 0.01);

            // DOWNCASTING (Coversão da super-classe para a sub-classe)

            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {

                //BusinessAccount acc5 = (BusinessAccount)acc3;  //outra forma é a de baixo;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; //outra forma é a de baixo;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
