using System;
using ExemploFacadePattern.Interface;

namespace ExemploFacadePattern
{
    public class RestauranteFacade
    {
        private IPizza _FonecedorPizza;
        private IPao _FornecedorPao;

        public RestauranteFacade()
        {
            _FonecedorPizza = new FornecedorPizza();
            _FornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _FonecedorPizza.buscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _FonecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoDeAlho()
        {
            _FornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            _FornecedorPao.BuscarPaodeAlhoComQueijo();
        }
    }   
}
