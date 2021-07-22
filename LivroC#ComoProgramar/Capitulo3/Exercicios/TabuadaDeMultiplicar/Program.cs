using System;
using static System.Console;

namespace TabuadaDeMultiplicar
{
    class Program
    {
        /*
            3.29 (Tabela de multiplicação de um número) Usando apenas as técnicas de programação 
            que você aprendeu neste capítulo, escreva um aplicativo que peça ao usuário para 
            inserir um número inteiro e exibe a tabela de multiplicação desse número, no formato 
            mostrado na Figura 3.26. Todos os cálculos devem ser feitos em termos de uma variável n.
            Autor: Pedro Filho 22/07/2021
        */

        static void Main(string[] args)
        {
            // limpa tela
            Clear();

            // variável
            int numero;

            // entrada de dados
            Write("Digite um número inteiro: ");
            numero = int.Parse(ReadLine());

            // cabeçalho
            WriteLine("\tTABUADA DE MULTIPLICAR");

            // tabuada de multiplicar
            WriteLine($"{numero}\tx\t 1\t=\t{numero * 1}");
            WriteLine($"{numero}\tx\t 2\t=\t{numero * 2}");
            WriteLine($"{numero}\tx\t 3\t=\t{numero * 3}");
            WriteLine($"{numero}\tx\t 4\t=\t{numero * 4}");
            WriteLine($"{numero}\tx\t 5\t=\t{numero * 5}");
            WriteLine($"{numero}\tx\t 6\t=\t{numero * 6}");
            WriteLine($"{numero}\tx\t 7\t=\t{numero * 7}");
            WriteLine($"{numero}\tx\t 8\t=\t{numero * 8}");
            WriteLine($"{numero}\tx\t 9\t=\t{numero * 9}");
            WriteLine($"{numero}\tx\t10\t=\t{numero * 10}\n");

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
