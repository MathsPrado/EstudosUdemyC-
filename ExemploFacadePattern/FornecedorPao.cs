using System;
using ExemploFacadePattern.Interface;

namespace ExemploFacadePattern
{
    public class FornecedorPao : IPao
    {
        public FornecedorPao()
        {
        }

        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo Pão de alho");
        }

        public void BuscarPaodeAlhoComQueijo()
        {
            ObterQuiejo();
            Console.WriteLine("Obtendo Pao de Alho com Queijo.");
        }

        private void ObterQuiejo()
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
