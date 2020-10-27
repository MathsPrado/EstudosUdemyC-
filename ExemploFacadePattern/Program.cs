using System;

namespace ExemploFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RestauranteFacade();
            Console.WriteLine("---------!-- Pedido de Pizza do CLiente -----------!-- \n");

            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            Console.WriteLine("---------!-- Pedido de Pão do CLiente -----------!-- \n");

            facade.BuscarPaoDeAlho();
            facade.BuscarPaoDeAlhoComQueijo();
        }
    }
}
