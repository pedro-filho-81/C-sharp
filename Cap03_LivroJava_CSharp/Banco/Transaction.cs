using System;

class Transaction
{
    // cria as propriedades
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    // cria o construtor da classe
    public Transaction( decimal amount, DateTime date, string note )
    {
        this.Amount = amount;
        this.Date = date;
        this.Notes = note;
    } // fim Transaction
} // fim da classe
