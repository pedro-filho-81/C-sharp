using System;

class Conta
{
    // cria a propriedade nome
    public string Nome { get; set; }
    
    // cria a variável privada saldo
    private decimal saldoInicial;
    
    // cria o construtor da classe
    public Conta( string nome, decimal saldoInicial )
    {
        // propriedade nome recebe variável
        Nome = nome;
        Saldo = saldoInicial;

    } // fim construtor

    // cria a propriedade Saldo
    public decimal Saldo
    {
        get
        {
            // retorna o valor do saldo inicial
            return saldoInicial;
        } // fim get
        set
        {
            // se o valor for maior que zero
            if( value > 0.0m )
            {
                // saldo inicial recebe o valor
                saldoInicial = value;
            } // fim if

        } // fim set
    } // fim propriedade

    // cria o método depósito
    public void Deposito( decimal valorDoDeposito )
    {
        // se o valor do depósito for maior que zero
        if( valorDoDeposito > 0.0m )
        {
            // Saldo soma mais valor do depósito
            Saldo += valorDoDeposito; 
        } // fim if

    } // fim método depósito

} // fim classe
