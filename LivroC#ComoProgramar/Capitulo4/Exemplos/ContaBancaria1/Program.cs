using System;
using static System.Console;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe conta
            Conta minhaConta = new Conta();

            // mostra o nome inicial
            WriteLine($"O nome da conta inicial: {minhaConta.GetNome()}");

            // entrada de dados
            Write("Digite o nome: " );
            // cria a variável nome e aguarda a tetrada pelo usuário
            string nome = ReadLine();
            // o objeto minha conta chama o método set nome e atribui o nome digitado
            minhaConta.SetNome(nome);

            // o nome da conta é
            WriteLine($"Nome da conta: {minhaConta.GetNome()}");

        } // fim main
    } // fim classe
} // fim namespace
