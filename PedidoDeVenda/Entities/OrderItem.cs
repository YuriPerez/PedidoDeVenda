using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PedidoDeVenda.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product prod  { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product prod)
        {
            this.quantity = quantity;
            this.price = price;
            this.prod = prod;
        }

        public double subTotal()
        {
            return quantity * price    ;
        }

        public override string ToString()
        {
            return prod.ToString() +
            ", Quantity: " + quantity +
            ", Subtotal: " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
