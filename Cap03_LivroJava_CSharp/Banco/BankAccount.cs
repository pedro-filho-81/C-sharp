using System;
using System.Collections.Generic; // para List<T>

    class BankAccount // cria a classe BankAccount
    {
        // cria a propriedade privada da classe
        private static int accountNumberSeed = 1234567890;

        // propriedades da classe
        public string Number { get;}
        public string Nome { get; set; }
        public decimal Balance 
        { 
            get
            {
                // cria a variável balance
                decimal balance = 0;
                
                // cria o loop para verificar os itens
                foreach( var item in allTransactions )
                {
                    balance += item.Amount;
                } // fim foreach

                return balance;

            } // fim get        
        } // fim Balance

        // cria o construtor
        // o construtor deve ter o mesmo nome da classe
        // serve para atribuir valores para as variáveis e as propriedades da classe
        
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Nome = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        
        // cria uma lista 
        private List<Transaction> allTransactions = new List<Transaction>();
        
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        
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

        } // FIM MAakeWithdrawal

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
        }

    } // fim da classe
