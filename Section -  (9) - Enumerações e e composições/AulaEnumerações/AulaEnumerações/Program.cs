using System;
using AulaEnumerações.Entities;
using AulaEnumerações.Entities.Enums;

namespace AulaEnumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);

            //conversao int para string enums
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //imprimir valor enum correspondente a classe orderstatus
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


        }
    }
}
