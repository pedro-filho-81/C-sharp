using System;

namespace Classes
{
    public class Transaction
    {
        // cria propriedades para a classe 
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // cria o Construtor da classe
        public Transaction(decimal amount, DateTime date, string note)
        {
            // armazena a conta
            this.Amount = amount;
            // para data
            this.Date = date;
            // para o extrato
            this.Notes = note;
        } //  fim construtos
    } // fim classe
} // fim namespace
