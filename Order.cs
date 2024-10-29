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
        public Customer CustomerInfo { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public Order(System.Guid orderId, List<Pruduct> pruducts, Customer customer, DateTime orderDate)
        {
            OrderId = orderId;
            Pruducts = pruducts;
            CustomerInfo = customer;
            OrderDate = orderDate;
            
        }

        public static void DeliveryOptions()
        {
            string[] deliveryOptions = new string[2]
            {
                "1. Standard Leverans (8 dagar)",
                "2. Expressleverans (2 dagar)"
            };

            Console.WriteLine("Välj leverans typ: ");
            foreach (var item in deliveryOptions)
            {
                Console.WriteLine(item);
            }
            int choice;
            Console.Write("Ditt val: ");


            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Ogiltigt val. Ange 1 för Standard Leverans eller 2 för Expressleverans.");
                Console.Write("Ditt val: ");
            }

            Delivery delivery;
            if (choice == 1)
            {
                delivery = new StandardDelivery(Guid.NewGuid(), "Jarlavägen 34", DateTime.Now, "Pågående");
                delivery.Handledelivery();
            }
            else if (choice == 2)
            {
                delivery = new ExpressDelivery(Guid.NewGuid(), "Jarlavägen 34", DateTime.Now.AddDays(2), "Pågående");
                delivery.Handledelivery();
            }

        }

        public void Printorder()
        {
            
            Console.WriteLine();
            Console.WriteLine("Kvitto för din beställning: ");


            for (int i = 0; i < Pruducts.Count; i++)
            {
                TotalPrice += Pruducts[i].Price;
                Console.WriteLine($"{Pruducts[i].Name} kostar: {Math.Round(Pruducts[i].Price, 2):F2} kr");
                Thread.Sleep(new Random().Next(400, 2000));
            }
            Console.WriteLine($"Ditt totala pris blir: {Math.Round(TotalPrice, 2):F2}kr!");

        }
    }
}
