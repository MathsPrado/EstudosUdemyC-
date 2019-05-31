using Exercicio_Aula118.Entities;
using Exercicio_Aula118.Entities.Enum;
using System;
using System.Globalization;

namespace Exercicio_Aula118
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data Entry
            Console.WriteLine("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker Data:");
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            #endregion



            #region Contracts
            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour: ");
                double valuePourHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePourHour, hours);
                worker.addContract(contract);
            }
            #endregion

            #region Final and data to calculating
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month =  int.Parse(monthAndYear.Substring(0,2));

            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Department" + worker.Department.Name);
            Console.WriteLine("Income for:" +monthAndYear +":"+ worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));
            #endregion



        }
    }
}