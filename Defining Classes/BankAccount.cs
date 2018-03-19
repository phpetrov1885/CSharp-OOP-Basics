using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class BankAccount
{
    private int id;
    public int Id { get; set; }

    private decimal balance;
    public decimal Balance { get; set; }


    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account ID{Id}, balance {Balance:f2}";
    }
}

