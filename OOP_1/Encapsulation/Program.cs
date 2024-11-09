using Encapsulation;

BankAccount bankAccount = new BankAccount(10000);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");
bankAccount.Deposit(5000);
Console.WriteLine($"Balance after deposit: {bankAccount.GetBalance()}");
bankAccount.Withdraw(8000);
Console.WriteLine($"Balance after withdraw: {bankAccount.GetBalance()}");
