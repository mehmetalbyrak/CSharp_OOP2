namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            
            ICreditManager housingLoanManager = new HousingLoanManager();
            

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(housingLoanManager, fileLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>() { consumerLoanManager, vehicleLoanManager, housingLoanManager};
            //applicationManager.GivePreInfoCredit(credits);


        }
    }
}

