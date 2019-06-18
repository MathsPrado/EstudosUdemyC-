using System;

namespace ExercicioInterface.Entites
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Veiculos Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Veiculos veiculos)
        {
            Start = start;
            Finish = finish;
            Vehicle = veiculos;
            Invoice = null;
        }
    }
}
