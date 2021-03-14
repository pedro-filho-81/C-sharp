using System;
using System.Collections.Generic;
using System.Transactions;

namespace Classes
{
    // cria a classe BankAccount
    public class BankAccount
    {
        private const int V = 0;

        // cria as propriedades (variáveis) da classe
        private static int accountNumberSeed = 1234567890;
        public string Number {get;}
        public string Owner { get; set; }
        public  decimal Balance 
        { 
            get 
            {
                // cria a variável
                decimal balance = 0;
                // para cada item em toda transação
                foreach(var item in allTransactions)
                {
                    // balance recebe a soma do item da conta
                    balance += item.Amount;
                } // fim foreach

                return balance;

            } // fim get

        } // fim da propriedade balancr

        // cria o CONSTRUTOR da classe
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name; // armazena o nome

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

        } // fim construtos

        // cria o objeto da classe Transactione
        private List<Transaction> allTransactions = new List<Transaction>();
        
        // cria o método faça depósito
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        } // fim método

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        } // fim método

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        } // fim do método

    } // fim classes    
} // fim namespace