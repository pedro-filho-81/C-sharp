using System;
using static System.Console;

namespace ContaBancaria4
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // chama a classe Conta e atribui valor
            Conta minhaConta = new Conta("Pedro", 1000m);
            Conta minhaConta1 = new Conta("Cleonice", 500m);
            Conta minhaConta2 = new Conta("Tatiane", -7.53m);

            // cabeçalho
            WriteLine("LISTA DOS CORRENTISTAS DO BANCO COM SALDO INICIAL" );

            // IMPRIME RESULTADO
            WriteLine($"A conta 1 é de {minhaConta.Nome} saldo inicial de {minhaConta.Saldo:C}");
            WriteLine($"A conta 2 é de {minhaConta1.Nome} saldo inicial de {minhaConta1.Saldo:c}");
            WriteLine($"A conta 3 é de {minhaConta2.Nome} saldo inicial de {minhaConta2.Saldo:C}\n");

            // entrada de dados
            Write("Digite o valor do depósito da conta 1 : ");
            decimal deposito = decimal.Parse(ReadLine());
            minhaConta.Deposito(deposito);

            Write("Digite o valor do depósito da conta 2 : ");
            decimal deposito1 = decimal.Parse(ReadLine());
            minhaConta1.Deposito(deposito1);

            Write("Digite o valor do depósito da conta 3 : ");
            decimal deposito2 = decimal.Parse(ReadLine());
            minhaConta2.Deposito(deposito2);

            // cabeçalho
            WriteLine("\nLISTA DOS VALORES DEPOSITADOS E SEUS SALDOS.");
            WriteLine($"Foi depósitado {deposito:C}, na conta de {minhaConta.Nome}");
            WriteLine($"Saldo atual {minhaConta.Saldo:C}\n" );

            WriteLine($"Foi depósitado {deposito1:C}, na conta de {minhaConta1.Nome}");
            WriteLine($"Saldo atual {minhaConta1.Saldo:C}\n" );

            WriteLine($"Foi depósitado {deposito2:C}, na conta de {minhaConta2.Nome}");
            WriteLine($"Saldo atual {minhaConta2.Saldo:C}\n" );


            Console.WriteLine("Hello World!");
        }
    }
}
