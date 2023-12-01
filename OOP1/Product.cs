namespace OOP1;

public class Product
{
    public int Id { get; set; } // primary key
    public int CategoryId { get; set; } // foreign key
    public string? ProductName { get; set; }
    public double UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    
    
}