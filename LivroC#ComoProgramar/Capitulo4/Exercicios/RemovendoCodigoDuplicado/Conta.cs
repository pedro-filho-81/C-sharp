using System;
using static System.Console;

class Conta
{
    // cria variáveis de instância
    private string nomeDaConta; // nome do titular da conta
    private decimal valorDoDeposito;
    private decimal valorDoSaque;
    private decimal saldoDaConta;

    // cria a propriedade Nome
    public string Nome
    {
        get
        {
            // retorna o nome do titular da conta
            return nomeDaConta;
        } // fim get
        set
        {
            // a variável de instância recebo o nome do titular da conta
            nomeDaConta = value;
        } // fim set
    } // fim propriedade Nome

    // cria a propriedade Saldo da conta
    public decimal SaldoDaConta
    {
        get
        {
            return saldoDaConta;
        } // fim get
        set
        {
            // se o valor digitado for maior que zero
            if( value > 0.0m )
            {
                // o saldo da conta recebe o valor
                saldoDaConta += value;
            } // fim if
        } // fim set
    } // fim propriedade

    public decimal ValorDoDeposito
    {
        get
        {
            return valorDoDeposito;
        } // fim get
        set
        {
            // se o valor digitado for maior que zero
            if( value > 0.0m )
            {
                // a variável de instância da classe recebe o valor
                valorDoDeposito = value;
                // e o saldo da conta recebe o valor do depósito
                saldoDaConta += valorDoDeposito;
            } // fim if
        } // fim set
    } // fim propriedade

    public decimal ValorDoSaque
    {
        get
        {
            return valorDoSaque;
        } // fim get
        set
        {
            // se o valor do saque for maior que zero
            if( value > 0.0m )
            {
                // e se o valor digitado for menor ou igual ao saldo da conta
                if( value <= saldoDaConta )
                {
                    // o valor do saque recebe o valor
                    valorDoSaque = value;
                    // e o saldo da conta e diminuido do valor do saque
                    saldoDaConta -= valorDoSaque;
                } // fim if interno
            } // fim if externo
        } // fim set
    } // fim propriedade

} // fim classe conta
