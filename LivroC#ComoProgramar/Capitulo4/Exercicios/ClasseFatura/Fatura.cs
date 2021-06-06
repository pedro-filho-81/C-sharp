using System;

class Fatura
{
    // cria variáveis de instância
    public string numero;
    public string descricao;
    public int quantidade;
    private decimal preco;
    private decimal total;

    // cria o construtor
    public Fatura( string numero, string descricao, int quantidade, decimal preco )
    {
        this.numero = numero;
        this.descricao = descricao;
        this.quantidade = quantidade;
        Preco = preco;

    } // fim do construtor

    // cria propriedade Preco
    public decimal Preco
    {
        get
        {
            return preco;
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                preco = value;
            } // fim if
        } // fim set
    } // fim propriedade preco

} // fim classe
