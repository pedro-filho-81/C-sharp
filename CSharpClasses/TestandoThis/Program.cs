using System;
using static System.Console;

namespace TestandoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um objeto da classe simples tempo
            var tempo = new SimplesTempo(13, 25, 35 );
            WriteLine($"{tempo.ConstruirString()}" );
        
        } // fim main

    } // fim classe
} // fim namespace
