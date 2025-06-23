using EncapsulationExample;

BankAccount bankAccount = new BankAccount(100);

bankAccount.Deposit(1000);
bankAccount.Withdraw(250);

Console.WriteLine(bankAccount.getBalance());