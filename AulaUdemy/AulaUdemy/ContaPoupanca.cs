using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUdemy
{
    class ContaPoupanca : Conta
    {
        public override double Saca(double valor, double saldo)
        {
           if (valor >= saldo )
            {
                saldo -= (valor + 0.1);
            }
            return saldo;
        }
    }
}
