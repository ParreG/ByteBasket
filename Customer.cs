using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    public class Customer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }

        public Customer(string name, string adress, string tel)
        {
            Name = name;
            Adress = adress;
            Tel = tel;
        }
    }
}
