using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPolimorfismoAula130.Entities
{
    class EmployedOutsource : Funcionario
    {
        

        public double AdditionalCharge { get; set; }


        public EmployedOutsource()
        {
        }

        public EmployedOutsource(string name, double hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Pagamento()
        {
           return base.Pagamento() + 1.1 * AdditionalCharge;
          
        }


    }
}
