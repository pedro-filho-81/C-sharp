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
            Conta minhaConta2 = new Conta("Tatiane", 250.25m);

            // cabeçalho
            WriteLine("LISTA DOS CORRENTISTAS DO BANCO COM SALDO INICIAL" );

            // IMPRIME RESULTADO
            WriteLine($"A conta 1 é de {minhaConta.Nome} saldo inicial de {minhaConta.Saldo:C}");
            WriteLine($"A conta 2 é de {minhaConta1.Nome} saldo inicial de {minhaConta1.Saldo:c}");
            WriteLine($"A conta 3 é de {minhaConta2.Nome} saldo inicial de {minhaConta2.Saldo:C}\n");

            Console.WriteLine("Hello World!");
        }
    }
}
