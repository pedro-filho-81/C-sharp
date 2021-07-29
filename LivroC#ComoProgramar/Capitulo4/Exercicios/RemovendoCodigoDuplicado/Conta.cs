using System;
using static System.Console;

class Conta
{
    // cria variáveis de instância
    private string nomeDaConta;
    private decimal saldo;

    // cria a propriedade Nome
    public string Nome
    {
        get
        {
            return nomeDaConta;
        } // fim get
        set
        {
            nomeDaConta = value;
        } // fim set
    } // fim propriedade Nome

    // cria a propriedade Saldo
    public decimal Saldo
    {
        get
        {
            return saldo;
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                saldo += value;
            } // fim if
        } // fim set
    } // fim propriedade

    // cria método Depósito
    public decimal Deposito( decimal valorDoDeposito )
    {
        // se valor do depósito maior que 0.0
        if( valorDoDeposito > 0.0m )
        {
            // saldo recebe o valor do depósito
            saldo += valorDoDeposito;
        } // fim if
        // se valor do depósito menor ou igual a 0.0
        if( valorDoDeposito <= 0.0m )
        {
            valorDoDeposito = 0.0m;
            return valorDoDeposito;

        } // fim if

        return saldo;
    } // fim do método

    // cria o método Saque
    public decimal Saque( decimal valorDoSaque )
    {
        // se o saldo maior ou igual ao valor do saque
        if( saldo > valorDoSaque )
        {
            // saldo recebe o valor do saque
            saldo -= valorDoSaque;
        } // fim if
        
        // retorne o saldo
        return saldo;

    } // fim do método

} // fim classe conta
