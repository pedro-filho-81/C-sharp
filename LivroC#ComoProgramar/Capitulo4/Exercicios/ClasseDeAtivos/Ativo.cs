using System;
using static System.Console;

class Ativo
{
    // variáveis
    private decimal valorDoAtivo;
    private decimal taxaDeDepreciacao;

    // propriedade
    public string NomeDoAtivo { get; set; }

    //cria construtor
    public Ativo( string nome, decimal valor, decimal taxa )
    {
        NomeDoAtivo = nome;
        ValorDoAtivo = valor;
        TaxaDaDepreciacao = taxa;
    } // fim construtor

    public decimal TaxaDaDepreciacao
    {
        get
        {
            return taxaDeDepreciacao;
        }// fim get
        set
        {
            if( value > 0.0m )
            {
                taxaDeDepreciacao = value;
            } // fim if
            
        } // fim set
    } // fim propriedade

    public decimal ValorDoAtivo
    {
        get
        {
            return valorDoAtivo;
        } // fim get
        set
        {
            if( value > 0.0m)
            {
                valorDoAtivo = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // método
    public decimal CalcularDepreciacao( decimal valor, decimal taxa)
    {
        // calcular taxa
        taxa = taxa * valor / 100;
        // retorna a taxa
        return taxa;
    } // fim método

} // fim classe