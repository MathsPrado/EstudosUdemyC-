using ExercicioMetodosAbstratos.Entities.Enum;

namespace ExercicioMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Colors Colors { get; set; }


        public Shape(Colors colors)
        {
            Colors = colors;
        }

      

        public abstract double Area();
      
    }
}
