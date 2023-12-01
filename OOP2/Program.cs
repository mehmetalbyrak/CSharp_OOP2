namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Mehmet";
            customer1.Surname = "Albayrak";
            customer1.TcNo = "55555555555";
            
            
            
            // Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerNo = "678910";
            customer2.Id = 1;
            customer2.CompanyName = "2B2";
            customer2.TaxNo = "1234567890";

            // SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}

