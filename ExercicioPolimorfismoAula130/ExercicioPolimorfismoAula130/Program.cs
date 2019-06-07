using ExercicioPolimorfismoAula130.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPolimorfismoAula130
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.WriteLine("Enter the number of Employees:");
            int n = int.Parse(Console.ReadLine());

           for (int i = 0; i < n ; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.WriteLine("Outsource (y/n)?");

                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine(" Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Hours:: ");
                double hours = double.Parse(Console.ReadLine());

                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new EmployedOutsource(name, hours, valuePerHour, additionalCharge));
                }
                else if(ch== 'n')
                {
                    list.Add(new Funcionario(name, hours, valuePerHour));
                }

                foreach(Funcionario emp in list)
                {
                    Console.WriteLine("Name:"+emp.Name+ "-- Pagamento:"+emp.Pagamento().ToString("F2"), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
