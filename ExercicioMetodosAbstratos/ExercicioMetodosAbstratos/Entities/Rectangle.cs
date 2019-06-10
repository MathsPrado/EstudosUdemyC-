using ExercicioMetodosAbstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle( Colors colors, double widht, double height) : base(colors)
        {
            Widht = widht;
            Height = height;
        }
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
