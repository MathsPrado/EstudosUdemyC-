using ExercicioMetodosAbstratos.Entities;
using ExercicioMetodosAbstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number of shapes ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine("Shape number #"+i);
                Console.WriteLine("Rectangle  or Circle (r/c)?");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Color (Black/ Blue/ Red)");
                Colors colors = Enum.Parse<Colors>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.WriteLine("Width:");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Height:");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(colors, widht, height));
                }
                else
                {
                    Console.WriteLine("Radios");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(colors, radius));
         
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
