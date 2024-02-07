namespace Oppgave4;

public class Manager : Employee
{
    // Properties
    public double Bonus { get; set; }
    
    
    // Constructors
    public Manager(int id, string name, double baseSalary, double bonus) : base(id, name, baseSalary)
    {
        Bonus = bonus;
    }
    
    
    // Methods
    public override double CalculateSalary()
    {
        return base.CalculateSalary() + Bonus;
    }

    public override string ToString()
    {
        return base.ToString() + $", Bonus: {Bonus}";
    }
}