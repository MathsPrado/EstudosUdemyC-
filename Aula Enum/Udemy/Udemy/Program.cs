using System;
using Udemy.Entities;
using Udemy.Entities.Enums;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 2080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            Console.WriteLine(txt);



        }

    }
}

