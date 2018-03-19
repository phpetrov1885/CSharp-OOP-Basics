using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();
        string commands = Console.ReadLine();

        while (commands != "End")
        {
            var splitCommand = commands.Split();
            var accountId = int.Parse(splitCommand[1]);

            switch (splitCommand[0])
            {
                case "Create":
                    if (!accounts.ContainsKey(accountId))
                    {
                        var account = new BankAccount();
                        account.Id = accountId;
                        accounts.Add(accountId, account);
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                    break;
                case "Deposit":
                    if (ValidatePersonAccount(accountId, accounts))
                    {
                        accounts[accountId].Deposit(int.Parse(splitCommand[2]));
                    }
                    break;
                case "Withdraw":
                    if (ValidatePersonAccount(accountId, accounts))
                    {
                        accounts[accountId].Withdraw(int.Parse(splitCommand[2]));
                    }
                    break;
                case "Print":
                    if (ValidatePersonAccount(accountId, accounts))
                    {
                        Console.WriteLine(accounts[accountId]);
                    }
                    break;
            }

            commands = Console.ReadLine();
        }
    }

    static bool ValidatePersonAccount(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(accountId))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
       
    }
}

