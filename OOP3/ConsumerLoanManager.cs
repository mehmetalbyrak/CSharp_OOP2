namespace OOP3;

public class ConsumerLoanManager: ICreditManager
{
    public void Calculate()
    {
        Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
    }

    public void DoSomething()
    {
        throw new NotImplementedException();
    }
}