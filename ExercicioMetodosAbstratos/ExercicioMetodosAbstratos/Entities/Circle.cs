using ExercicioMetodosAbstratos.Entities.Enum;
using System;

namespace ExercicioMetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(Colors colors, double radius) : base(colors)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
