using System;
using static System.Console;

namespace VariaveisRecebemValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int numero1;
            int numero2;
            int soma;

            // entrada de dados
            Console.Write("Digite o primeiro valor: ");
            numero1 = int.Parse(ReadLine());

            Write("Digite o segundo valor: " );
            numero2 = int.Parse(ReadLine());

            // calcular a soma
            soma = numero1 + numero2;

            // mostra a soma
            WriteLine($"A soma entre {numero1} e {numero2} é {soma}\n");

        } // fim main
    } // fim classe
} // fim name
