using System;
using static System.Console;

class Credito
{
    // cri variáveis de instância
    private int valorInvestido;
    private int jurosGanhos;
    private int taxaDeJuros;
    private int tempoAplicado;
    private int numeroDaConta;
    private int valorFinal;

    // cria o construtor
    public Credito( int contaNumero, int valorInvestido, int taxaDeJuros, int tempoAplicado )
    {
        numeroDaConta = contaNumero;
        ValorInvestido = valorInvestido;
        TaxaDeJuros = taxaDeJuros;
        TempoAplicado = tempoAplicado;
    } // fim construtor

    public int ValorInvestido
    {
        get
        {
            return valorInvestido;
        } // fim get
        set
        {
            if( value > 0 )
            {
                valorInvestido = value;
            } // fim if
        } // fim set
    } // fim propriedade
    
    // cria propriedade taxaDeJuros
    public int TaxaDeJuros
    {
        get
        {
            return taxaDeJuros;
        } // fim get
        set
        {
            if( value > 0 )
            {
                taxaDeJuros = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // cria a propriedade JurosGanhos
    public int JurosGanhos
    {
        get
        {
            return jurosGanhos;
        } // fim get
        set
        {
            if( value > 0 )
            {
                jurosGanhos = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // cria a propriedade TempoAplicado
    public int TempoAplicado
    {
        get
        {
            return tempoAplicado;
        } // fim get
        set
        {
            if( value > 0 )
            {
                tempoAplicado = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // cria a propriedade ValorFinal
    public int ValorFinal
    {
        get
        {
            return valorFinal;
        } // fim get
        set
        {
            if( value > 0 )
            {
                valorFinal = value;
            } // fim if
        } // fim set
    } // fim propriedade

} // fim da classe