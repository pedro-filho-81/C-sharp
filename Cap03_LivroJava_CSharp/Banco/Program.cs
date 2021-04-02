using System;

// fornece uma maneira de organizar o código
namespace AccountTest
{
    // classe principal
    class Program
    {
        // método principal
        static void Main(string[] args)
        {
            // cria o objeto da classe e atribui valor
            BankAccount account = new BankAccount("Pedro Filho", 1000);
            //Transaction transaction = new Transaction();
            
            // mostra o resultado
            Console.WriteLine($"O número da conta é {account.Number}\npertence a {account.Nome} " +
                $"\ncom saldo inicial no valor de {account.Balance:C}");

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
            }

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();

        } // fim main
    } // fim classe
} // fim namespace
