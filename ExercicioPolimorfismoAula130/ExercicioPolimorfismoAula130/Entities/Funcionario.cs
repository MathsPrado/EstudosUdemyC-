namespace ExercicioPolimorfismoAula130.Entities
{
    public class Funcionario
    {
        public string Name { get; set; }
        public double Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string name, double hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Pagamento()
        {
           return  Hours * ValuePerHour;
        }
    }
}
