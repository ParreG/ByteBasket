using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    public class Order
    {
        public System.Guid OrderId { get; set; }
        public List<Pruduct> Pruducts { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public Delivery delivery { get; set; }

        public Order(System.Guid orderId, List<Pruduct> pruducts, DateTime orderDate, Delivery delivery)
        {
            OrderId = orderId;
            Pruducts = pruducts;
            OrderDate = orderDate;
            this.delivery = delivery;
        }

        public void ProcessDelivery()
        {
            Delivery delivery1;

        }
        public void Printorder()
        {
            Console.WriteLine("Kvitto för din beställning: ");


            for (int i = 0; i < Pruducts.Count; i++)
            {
                TotalPrice += Pruducts[i].Price;
                Console.WriteLine($"{Pruducts[i].Name} kostar: {Pruducts[i].Price}kr");
            }
            Console.WriteLine($"Ditt totala pris blir: {TotalPrice}kr!");

        }
    }
}
