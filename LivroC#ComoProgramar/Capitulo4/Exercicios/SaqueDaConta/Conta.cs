using System;

class Conta
{
    // cria propriedade nome
    public string NomeDaConta { get; set; }
    
    // cria variável privada saldo
    private decimal saldo;

    // cria construtor da classe
    public Conta( string nome, decimal saldoInicial )
    {
        NomeDaConta = nome;
        saldo = saldoInicial;
    } // fim construtor

    // cria propriedade saldo
    public decimal Saldo
    {
        get
        {
            return saldo;
        } // fim get
        set
        {
            if( value > 0 )
            {
                saldo = value;
            } // fim if

        } // fim set    
    } // fim propriedade

    // cria método depósito
    public void Deposito( decimal valorDeDeposito )
    {
        // se valor do depósito maior que zero
        if( valorDeDeposito > 0.0m)
            saldo += valorDeDeposito;
    } // fim método depósito

    // cria método saque
    public void Saque( decimal saque )
    {
        // se saque menor ou igual ao saldo
        if( saque > 0.0m && saque <= saldo )
        {
            // saque retira dinheiro do saldo
            saldo -= saque;
        } // fim if
        else
        {
            Console.WriteLine($"Saque {saque:C} maior que o saldo {saldo:C}\n" );
        } // fim else

    } // fim método saque
    
} // fim classe Conta
