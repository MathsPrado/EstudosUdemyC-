using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUdemy
{
    class ContaCorrente : Conta
    {
        public static int totalContaCorrente = 0;

        public ContaCorrente()
        {
            totalContaCorrente++;
        }

        public override double Saca(double valor, double saldo)
        {
            if (valor >= saldo)
            {
                saldo -= (valor + 0.4);
            }
            return saldo;
        }
    }
}
