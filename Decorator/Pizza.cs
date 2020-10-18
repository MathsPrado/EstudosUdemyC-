using System;
using Decorator.Interfaces;

namespace Decorator
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Esta é uma Pizza Normal";
            return pizza;
        }
    }
}
