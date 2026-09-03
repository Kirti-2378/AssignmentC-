using System;

class BankAccount
{
    public string AccountNumber { get; set; }

    private double balance;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            Console.WriteLine("Deposit amount must be positive.");
    }
}

class Program
{
    public static void Main1(string[] args)
    {
        BankAccount account = new BankAccount();

        account.AccountNumber = "1234567890";
        account.Balance = 1000;

        account.Deposit(500);

        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}