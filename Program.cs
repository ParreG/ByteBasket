namespace ByteBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer0 = new Customer("Anna Larsson", "LinneaGatan 24, 181123 Stockholm", "073423123");
            Customer customer1 = new Customer("Erik Svensson", "Björkgatan 12, 12345 Göteborg", "0709876543");
            Customer customer2 = new Customer("Maria Johansson", "Tallvägen 5, 45678 Malmö", "0734567890");
            Customer customer3 = new Customer("Lars Olsson", "Eklundavägen 8, 98765 Uppsala", "0765432109");



            List<Pruduct> products = new List<Pruduct>
            {
                new Pruduct("Laptop", 1, 8999.99),
                new Pruduct("Mus", 2, 299.99),
                new Pruduct("Tangentbord", 1, 699.99),
                new Pruduct("Skärm", 1, 2499.99),
                new Pruduct("Hörlurar", 1, 499.99),
                new Pruduct("Webbkamera", 1, 799.99),
                new Pruduct("Extern Hårddisk", 1, 1199.99),
                new Pruduct("USB-kabel", 3, 49.99),
                new Pruduct("Skrivare", 1, 1499.99),
                new Pruduct("Router", 1, 999.99),
                new Pruduct("Mobilhållare", 2, 199.99),
                new Pruduct("Musmatta", 1, 99.99),
                new Pruduct("Trådlös laddare", 1, 299.99)
            };

            
            List<Pruduct> products1 = new List<Pruduct>
            {
                new Pruduct("Smartphone", 1, 6999.99),
                new Pruduct("Tablet", 1, 4999.99),
                new Pruduct("Bärbar högtalare", 1, 1299.99),
                new Pruduct("Smartwatch", 1, 2499.99),
                new Pruduct("VR-headset", 1, 3499.99)
            };

            
            List<Pruduct> products2 = new List<Pruduct>
            {
                new Pruduct("Spelkontroll", 2, 599.99),
                new Pruduct("Gamingstol", 1, 1999.99),
                new Pruduct("Spelkonsol", 1, 3999.99),
                new Pruduct("Grafikkort", 1, 4999.99),
                new Pruduct("Mikrofon", 1, 799.99)
            };

            
            List<Pruduct> products3 = new List<Pruduct>
            {
                new Pruduct("Kamera", 1, 3999.99),
                new Pruduct("Stativ", 1, 999.99),
                new Pruduct("Objektiv", 1, 2999.99),
                new Pruduct("Fotobok", 1, 199.99),
                new Pruduct("Blixt", 1, 1499.99)
            };


            List<Order> orders = new List<Order>
            {
                new Order(Guid.NewGuid(), products, customer0, DateTime.Now),
                new Order(Guid.NewGuid(), products1, customer1, DateTime.Now),
                new Order(Guid.NewGuid(), products2, customer2, DateTime.Now),
                new Order(Guid.NewGuid(), products3, customer3, DateTime.Now)
            };



            foreach (var order in orders)
            {
                order.Printorder();
                Console.WriteLine();
                Thread.Sleep(new Random().Next(400, 1000));
                Order.DeliveryOptions();
            }

            













        }
    }
}
