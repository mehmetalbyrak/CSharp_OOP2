using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double price = 15;
            string description = "Amasya elması";

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";
            product1.StockQuantity = 20;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diayrbakır karpuzu";
            product2.StockQuantity = 50;


            Product[] products = new Product[] {product1, product2};
            
            
            //type safety 
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.StockQuantity);
                Console.WriteLine("---------------------");
            }
            
            Console.WriteLine("---------------------- Methodlar ----------------");
            
            
            //encapsulation
            BoxManager boxManager = new BoxManager(); //instance
            boxManager.Add(product1);
            boxManager.Add(product2);
            
            boxManager.Add2("Armut", "Yeşil armut", 12, 10);
            boxManager.Add2("Elma", "Yeşil elma", 12, 9);
            boxManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
