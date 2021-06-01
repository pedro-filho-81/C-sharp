using System;
using static System.Console;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe Conta
            Conta minhaConta = new Conta();

            // imprime
            WriteLine( $"Nome inicial da conta: {minhaConta.Nome}");

            // entrada de dados do usuário
            Write( $"Entre com o nome para a conta: ");
            // cria variável contaNome e atribui o valor informado pelo usuário
            string contaNome = ReadLine();
            // minha conta nome recebe o nome informado pelo usuário
            minhaConta.Nome = contaNome;

            // mostra o nome da conta
            WriteLine($"O nome da conta é {minhaConta.Nome}");

        } // fim main
    } // nome da classe
} // fim namespace
