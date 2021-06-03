using System;
using static System.Console;

namespace SaqueDaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe conta e atribui valores
            Conta minhaConta = new Conta("Pedro", 1000m);
            Conta minhaConta1 = new Conta("Cleonice", -7.25m );

            // cabeçalho
            // cor do fundo
            BackgroundColor = ConsoleColor.DarkBlue;
            // cor das letras
            ForegroundColor = ConsoleColor.White;
            // texto
            WriteLine("LISTA DE CLIENTES E SEUS SALDOS" );
            // retorna a cor anterior
            ResetColor();

            // mostra conta inicial
            WriteLine($"{minhaConta.NomeDaConta} Saldo inicial {minhaConta.Saldo:C}");
            WriteLine($"{minhaConta1.NomeDaConta} Saldo inicial {minhaConta1.Saldo:C}\n");

            // entrada de dados
            Write("Digite o nome do cliente:" );
            string nomeDoCliente = ReadLine();
            minhaConta.NomeDaConta = nomeDoCliente;
            
            Write("Digite o valor do depósito: " );
            decimal valorDoDeposito = decimal.Parse(ReadLine());
            minhaConta.Deposito(valorDoDeposito);
            
            // mostra resultado
            // mostra conta 
            WriteLine($"{minhaConta.NomeDaConta} Saldo inicial {minhaConta.Saldo:C}");

            // entrada de dados
            Write("\nDigite o nome do cliente1:" );
            string nomeDoCliente1 = ReadLine();
            minhaConta1.NomeDaConta = nomeDoCliente1;
           
            Write("Digite o valor do depósito: " );
            decimal valorDoDeposito1 = decimal.Parse(ReadLine());
            minhaConta1.Deposito(valorDoDeposito1);

            // mostra resultado
            // mostra conta 
            WriteLine($"{minhaConta1.NomeDaConta} Saldo inicial {minhaConta1.Saldo:C}\n");
            
            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
