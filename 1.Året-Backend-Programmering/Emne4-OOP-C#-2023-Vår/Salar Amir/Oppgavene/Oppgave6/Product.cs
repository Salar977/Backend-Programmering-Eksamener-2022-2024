namespace Oppgave6;

public class Product
{
    // Oppgave 6A
    
    // Properties
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
    // Constructors
    public Product(int id, string name, double price, int quantity)
    {
        ID = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    
    // Methods
    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Price: {Price}, Quantity: {Quantity}";
    }
}