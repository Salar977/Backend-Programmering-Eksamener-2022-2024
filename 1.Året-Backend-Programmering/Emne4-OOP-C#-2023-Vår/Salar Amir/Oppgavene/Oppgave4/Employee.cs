namespace Oppgave4;

public class Employee
{
    // Fields
    public int Id { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    
    
    // Constructors
    public Employee(int id, string name, double baseSalary)
    {
        Id = id;
        Name = name;
        BaseSalary = baseSalary;
    }
    
    
    // Methods
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
    
    public override string ToString()
    {
        return $"Type: {this.GetType().Name}, CalculatedSalary: {CalculateSalary()}, " +
               $"Id: {Id}, Name: {Name}, BaseSalary: {BaseSalary}";
    }
}