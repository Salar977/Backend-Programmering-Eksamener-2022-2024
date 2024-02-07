namespace Oppgave2;

public class BankAccount
{
    // Fields
    private double _balance;
    public string AccountNumber { get; init; }
    public string OwnerName { get; set; }

    public double Balance
    {
        get
        {
            return _balance;
        }
    }

    // Constructor
    public BankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    // Methods
    public void Deposit(double amount)
    {
        Console.WriteLine($"\nSetter inn {amount} kr");
        if(amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Ny saldo: {Balance} kr");
        }
        else
        {
            Console.WriteLine("Error: Kan ikke sette inn 0 eller mindre.");
        }
    }
    
    public void Withdraw(double amount)
    {
        Console.WriteLine($"\nPrøver å ta ut {amount} kr");
        if(amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Ny saldo: {Balance} kr");
        }
        else
        {
            Console.WriteLine("Error: Ikke dekning på konto.");
        }
    }

    public override string ToString()
    {
        return $"Kontonummer: {AccountNumber}\nEier: {OwnerName}\nSaldo: {Balance} kr";
    }
}