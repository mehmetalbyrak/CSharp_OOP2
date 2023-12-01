namespace OOP1;

public class ProductManager
{
    //encapsulation 
    public void Add(Product product)
    {
        Console.WriteLine(product.ProductName + " eklendi. ");
    }
    
    public void Update(Product product)
    {
        Console.WriteLine(product.ProductName + " güncellendi.  ");
    }
    
    
    
    
    
    
    
    // void and int usage in Methods
    
    /*
    public int Addition(int number1, int number2)
    {
        return number1 + number2;
    }
    
    public void Addition2(int number1, int number2)
    {
        Console.WriteLine(number1 + number2);
    }
    
    */
    
    
    
}