using PedidoDeVenda.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PedidoDeVenda.Entities
{
    class Order
    {
        public DateTime date { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public Order()
        {
        }
        public Order(DateTime date, OrderStatus status, Client client)
        {
            this.date = date;
            this.status = status;
            this.client = client;
            orderItems = new List<OrderItem>();
        }

        public void addItem(OrderItem item)
        {
            orderItems.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach (OrderItem it in orderItems)
            {
                sum = sum + it.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb1 = new StringBuilder();
            Console.WriteLine(" ");
            sb1.AppendLine("ORDER SUMARY");
            sb1.AppendLine("Order moment: "+ date.ToString("yyyy - MM - dd HH: mm:ss"));
            sb1.AppendLine("Order status: "+ status.ToString());
            sb1.AppendLine(client.ToString());
            sb1.AppendLine("");
            sb1.AppendLine("ORDER ITENS: ");
            foreach (OrderItem ort in orderItems)
            {
                sb1.AppendLine(ort.ToString());
            }
            sb1.Append("Total Price: $");
            double totalPrice = 0;
           foreach (OrderItem ort in orderItems)
            {          
                totalPrice += ort.subTotal();
            }
            sb1.AppendLine(totalPrice.ToString("F2", CultureInfo.InvariantCulture));
            return sb1.ToString();
        }
    }
}
