using System;
using SistemaDePedidos.Entities.Enums;
using SistemaDePedidos.Entities;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("BirthDate (DD/MM/YYYY) : ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client clientData = new Client(clientName, clientEmail, clientBirthDate);
            
            Console.WriteLine();
            Console.WriteLine("Enter order informations:");
  
            Console.Write("Wich order status? Type one of these status: (PendingPayment/Processing/Shipped/Delivered):  ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime orderMoment = DateTime.Now;

            Order order = new Order(orderMoment, orderStatus, clientData);

            Console.WriteLine();
            Console.Write("How many items to this order? : ");
            int amountItems = int.Parse(Console.ReadLine());
            int itemsCount = 1;

            while (amountItems >= itemsCount)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #" + itemsCount + " item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: R$");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int productQtd = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(productQtd, productPrice, product);
                
                order.AddItem(orderItem);

                itemsCount++;

                Console.WriteLine();
            }
            
            Console.WriteLine(order);





        }
    }
}
