using System;
using static System.Console;

namespace ContaBancaria3
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // 1º chama a classe Conta
            // 2º cria o objeto minhaConta 
            // 3º atribui um valor
            Conta minhaConta = new Conta( "Pedro" );
            // cria novo objeto
            Conta minhaConta1 = new Conta("Maria");
            // cria novo objeto
            Conta minhaConta2 = new Conta("Cleonice");

            // cabeçalho
            WriteLine("LISTA DOS NOMES DAS CONTAS:");
            // chama a classe Conta através do objeto minhaConta e mostra o nome armazenado
            WriteLine($"Primeiro nome da conta é {minhaConta.Nome}");
            WriteLine($"Segundo nome da conta é {minhaConta1.Nome}");
            WriteLine($"Terceiro nome da conta é {minhaConta2.Nome}");
            
        } // fim main
    } // fim classe principal
} // fim namespace
