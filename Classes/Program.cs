﻿using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objeto accout da classe BankAccount
            // e inicializa com o nome e o saldo de 1000
            var account = new BankAccount("<name>", 1000);
            // imprime
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            } // fim catch

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            } // fim teste de saldo negativo

        } // fim main
    } // fim class
} // fim name space
