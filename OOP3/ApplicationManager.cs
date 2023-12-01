namespace OOP3
{
    class ApplicationManager
    {
        // Method Injection
        public void DoApplication(ICreditManager creditManager, IloggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void GivePreInfoCredit(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
