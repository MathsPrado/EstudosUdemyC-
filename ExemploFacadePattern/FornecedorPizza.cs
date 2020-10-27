using System;
using ExemploFacadePattern.Interface;

namespace ExemploFacadePattern
{
    public class FornecedorPizza : IPizza
    {
        public FornecedorPizza()
        {
        }

        public void buscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando a pizza normal!");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando a pizza vegana! \n");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vegetais");
        }
    }
}
