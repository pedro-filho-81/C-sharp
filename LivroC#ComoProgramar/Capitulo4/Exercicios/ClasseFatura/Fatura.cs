using System;

class Fatura
{
    // cria variáveis de instância
    public string numero;
    public string descricao;
    public int quantidade;
    private decimal preco;

    // cria o construtor
    public Fatura( string numero, string descricao, int quantidade, decimal preco )
    {
        this.numero = numero;
        this.descricao = descricao;
        Quantidade = quantidade;
        Preco = preco;

    } // fim do construtor

    // cria a propriedade Quantidade
    public int Quantidade
    {
        get
        {
            return quantidade;
        } // fim get
        set
        {  
            if( value <= 0 )
            {
                quantidade = 0;
            } // fim if
        } // fim set
    } // fim propriedade quantidade

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

            if( value <= 0.0m )
            {
                preco = 0.0m;
            } // fim if

        } // fim set
    } // fim propriedade preco

    // cria método calcular preço
    public decimal CalcularPreço( int quantidade, decimal preco )
    {
        // multiplicar quantidade pelo preço
        return quantidade * preco;
    } // fim método calcular preço

} // fim classe
