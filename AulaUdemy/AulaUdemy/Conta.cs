using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUdemy
{
   abstract class Conta : IImpostos
    {
        public int Numero { get; set; }
        public string NomeTitular { get; set; }
        protected double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public abstract double Saca(double valor, double saldo);
     
      
    }

    public interface IImpostos
    {
    }
}
