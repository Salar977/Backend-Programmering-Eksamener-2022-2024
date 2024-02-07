using Oppgave2;

BankAccount bankAccount1 = new BankAccount("123456789", "Elon Musk");
BankAccount bankAccount2 = new BankAccount("987654321", "Jeff Bezos");

Console.WriteLine(bankAccount1);
bankAccount1.Deposit(5000000);
bankAccount1.Withdraw(2000000);
bankAccount1.Withdraw(4000000);