namespace Methods
{
    class BoxManager
    {
        // naming convention
        // syntax

        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string description, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productName);
        }
    }
}


