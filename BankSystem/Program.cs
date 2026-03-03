/*
Design a Bank Account Management System using encapsulation principles in C#.
Requirements:
Create a BankAccount class.
Balance must be private.
Allow deposit and withdrawal through public methods.
Prevent negative balance withdrawals.
Sub-Questions:
1. Modify the program to prevent deposits of negative values.
2. Add a method that returns a formatted account summary (Account Name, Account
Number, Balance).
3. Simulate multiple transactions and display final balance after 5 operations.
*/

using System;
using System.Formats.Asn1;

class BankAccount
{
    private int balance = 0;
     
    public void Deposit(int amount)
    {
        Console.WriteLine("Deposit:");
        Console.WriteLine("******************");
        int result = balance+amount;
        Console.WriteLine("You just deposited: Ksh"+result);
        balance = result;
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine("Withdraw:");
        Console.WriteLine("******************");
        int result = balance-amount;
        if(result < 0)
        {
            Console.WriteLine("Balance cannot be negative.");
        }
        else
        {
            balance = result;
        }
        
        if(result <= 0)
        {
            Console.WriteLine("You have insufficient funds.");
        }
        else
        {
            Console.WriteLine("You just withdraw Ksh "+amount +"; balance = "+balance);
        }
    }


    public void Account_Details()
    {
        Console.WriteLine("Enter your Account Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Account Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("******************");
        Console.WriteLine("Account Details:");
        Console.WriteLine();
        Console.WriteLine("Account Name: "+ name);
        Console.WriteLine("Account Number: "+ number);
        Console.WriteLine("Account Balance: "+balance);
    }

}

class Account
{
    static void Main(string [] args)
    {
        BankAccount a1 = new BankAccount();
        a1.Deposit(1000);
        a1.Withdraw(1500);
        a1.Account_Details();
    }

}