using System;
using Decorator.Interfaces;

namespace Decorator
{
    //Base Decorator
    public class PizzaDecorator : Interfaces.IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }
}
