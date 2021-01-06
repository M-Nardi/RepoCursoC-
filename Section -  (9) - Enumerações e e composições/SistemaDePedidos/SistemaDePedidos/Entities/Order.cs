using System;
using System.Collections.Generic;
using System.Text;
using SistemaDePedidos.Entities.Enums;


namespace SistemaDePedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Momment ");
            sb.Append(Moment);
            sb.AppendLine("");
            sb.Append("Order Status: ");
            sb.Append(Status);
            sb.AppendLine("");
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.Append(Client.Email);
            sb.AppendLine("");
            sb.AppendLine("Order Items:");

            foreach (OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name);
                sb.Append(", R$");
                sb.Append(item.Product.Price);
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: R$");
                sb.Append(item.SubTotal());
                sb.AppendLine("");
            }

            sb.Append("Order Total Price: R$");
            sb.Append(Total());

            return sb.ToString();
        }

    }
}
