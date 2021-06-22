using System;
using static System.Console;

namespace Escopo
{
    class Program
    {
        // cria uma variável global
        private static int variavelGlobal = 1;

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variável em main
            int variavelInterna = 5;

            WriteLine($"O valor da variável interna é {variavelInterna}");

            UsarVariavelLocal();

            UsarVariavelStatica();

            UsarVariavelLocal();

            UsarVariavelStatica();

            WriteLine($"\nO valor da variável local é {variavelInterna}");
        } // fim main

        static void UsarVariavelLocal()
        {
            // cria variável
            int variavelDoMetodo = 25;

            // mostrar variável do método
            WriteLine($"\nO valor da variável do método UsarVariavelLocal é {variavelDoMetodo}" );

            // pré-incrementa a variável do método
            ++variavelDoMetodo;

            // mostra a variável do método depois do incremento
            WriteLine($"O valor da variável depois do incremento é {variavelDoMetodo}" );

        } // fim método usar variável local

        
        // cria o método usar variável static
        static void UsarVariavelStatica()
        {
            // mostrar 
            WriteLine($"\nO valor da variável estática é {variavelGlobal}" );

            variavelGlobal *= 10;

            WriteLine($"Variável global no método UsarVariavelStatica é {variavelGlobal}");
        } // fim método UsarVariavelStatica

    } // fim classe
} // fim namespace
