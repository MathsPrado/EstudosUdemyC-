using System;
using Decorator.Interfaces;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza baconDecorator = new BaconDecorator(pizza);
            IPizza queijoDecorator = new QueijoDecorator(baconDecorator);
            IPizza cebolaDecorator = new CebolaDecorator(queijoDecorator);

            Console.WriteLine(pizza.BuscarTipoPizza());
            Console.WriteLine(cebolaDecorator.BuscarTipoPizza());



        }
    }
}
