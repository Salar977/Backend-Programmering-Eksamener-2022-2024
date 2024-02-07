namespace Oppgave3;

public class Author
{
    // Fields
    private int _birthYear;
    private string _firstName;
    private string _lastName;
    
    
    // Properties
    public int BirthYear => _birthYear;
    public string FirstName => _firstName;
    public string LastName => _lastName;
    
    
    // Constructors
    public Author(string firstName, string lastName, int birthYear)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthYear = birthYear;
    }
    
    
    // Methods
    public void GetFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
    
    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {BirthYear}";
    }
}