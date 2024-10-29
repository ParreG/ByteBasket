using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    using System;

    public abstract class Delivery
    {
        
        public Guid DeliveryId { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; } 

        
        protected Delivery(Guid deliveryId, string address, DateTime deliveryDate, string status)
        {
            DeliveryId = deliveryId;
            Address = address;
            DeliveryDate = deliveryDate;
            Status = status;
        }

        
        public abstract void Handledelivery();

        
        public virtual void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Leveransstatus har uppdaterats till: {Status}");
        }
    }

}
