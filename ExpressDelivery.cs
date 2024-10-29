using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    internal class ExpressDelivery : Delivery
    {


        public ExpressDelivery(Guid deliveryId, string address, DateTime deliveryDate, string status) : base(deliveryId, address, deliveryDate, status)
        {
        }

        public override void Handledelivery()
        {
            Console.WriteLine($"Din express leverans ID: {Guid.NewGuid()}");
            Console.WriteLine($"levarans hanteras. uppskattat leveranstid är: {DateTime.Now.AddDays(4)}");
        }
    }
}
