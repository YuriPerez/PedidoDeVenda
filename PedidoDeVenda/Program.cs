using PedidoDeVenda.Entities;
using PedidoDeVenda.Entities.Enums;
using System;
using System.Globalization;

namespace PedidoDeVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            //informa os dados do cliente
            Console.WriteLine("Enter the cliente data ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            //instancia o cliente
            Client c1 = new Client(clientName, clientEmail, birthdate);

            Console.WriteLine("Enter order data ");
            Console.Write("Status (PENDINGPAYMENT, PROCESSING, SHIPPED,  DELIVERED): ");
            OrderStatus s1 = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());

            Console.Write("How many itens to this order: ");
            int a = int.Parse(Console.ReadLine());
            //Instancia o pedido
            Order o1 = new Order(DateTime.Now, s1, c1);

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter item data: ");
                Console.Write("Produt Name: ");
                string pdName = Console.ReadLine();
                Console.Write("Product Price: ");
                double pdPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //instanciando o produto
                Product p = new Product(pdName, pdPrice);

                Console.Write("Quantity: ");
                int pdQt = int.Parse(Console.ReadLine());
                //instanciando o itemPedido
                OrderItem orderItem = new OrderItem(pdQt, pdPrice, p);

               //Adicionando o item do pedido a Lista de Itens
                o1.addItem(orderItem);
            }
            Console.WriteLine(o1.ToString());






        }
    }
}
