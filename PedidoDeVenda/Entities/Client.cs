using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDeVenda.Entities
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime brithDate { get; set; }

        public Client()
        {
        }
        public Client(string name, string email, DateTime brithDate)
        {
            this.name = name;
            this.email = email;
            this.brithDate = brithDate;
        }

        public override string ToString()
        {
            return "Cliente: "+ name +
                   " (" + brithDate.ToString("yyyy-MM-dd") + ") - " +
                   email;
        }
    }
}
