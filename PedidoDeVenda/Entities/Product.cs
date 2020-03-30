using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PedidoDeVenda.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return name + ", $" + price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
