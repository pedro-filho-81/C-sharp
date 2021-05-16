using System;
using static System.Console;

namespace SegundoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria e inicializa um array
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // imprime
            WriteLine( $"  Ìndice {"Valor",10}");

            // loop para mostrar os valores do array
            for( int contar = 0; contar < numeros.Length; contar++ )
            {
                // imprima
                WriteLine( $"numero[{contar + 1}]{numeros[contar], 10}" );
            } // fim for

        } // fim main
    } // fim classe
} // fim namespace
