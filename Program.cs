namespace ByteBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Anna Larsson", "LinneaGatan 24, 181123 Stockholm", "073423123");
            

            List<Pruduct> pruducts = new List<Pruduct>
            {
                new Pruduct("Laptop", 1, 8999.99),
                new Pruduct("Mus", 2, 299.99),
                new Pruduct("Tangentbord", 1, 699.99)
            };


            Order order = new Order(Guid.NewGuid(), pruducts, DateTime.Now);
            order.Printorder();
            Console.WriteLine();

            Thread.Sleep(3000);

            DeliveryOptions();

            



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
    }
}
