using System;

public class Account
{
    public decimal Income { get; set; }
    public decimal Withdrawal { get; set; }
    public decimal Transference { get; set; }
    public decimal Balance { get; private set; } = 200;

    public Account() { }
    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void income(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Income successful. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Incorrect amount");
        }
    }

    public void withdrawal(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance for withdrawal");
        }
    }

    public void transference(decimal amount, Account targetAccount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            targetAccount.Balance += amount;
            Console.WriteLine($"Transferred {amount} to the selected account. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount for transfer.");
        }
    }

    public static void Main(string[] args)
    {
        Account myAccount = new Account(200); 
        Account targetAccount = new Account(); 
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Income   2. Withdrawal   3. Transference   4. Show Balance");
        int typeOption = Convert.ToInt32(Console.ReadLine());

        switch (typeOption)
        {
            case 1:
                Console.WriteLine("Type amount to deposit:");
                decimal incomeAmount = Convert.ToDecimal(Console.ReadLine());
                myAccount.income(incomeAmount);
                break;

            case 2:
                Console.WriteLine("Type amount to withdraw:");
                decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                myAccount.withdrawal(withdrawalAmount);
                break;

            case 3:
                Console.WriteLine("Type an account number to transfer");
                Console.ReadLine();
                Console.WriteLine("Type amount to transfer:");
                decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                myAccount.transference(transferAmount, targetAccount);
                break;

            case 4:
                Console.WriteLine($"Current Balance: {myAccount.Balance}");
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
