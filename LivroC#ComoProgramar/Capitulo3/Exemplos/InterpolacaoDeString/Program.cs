using System;
using static System.Console;

namespace InterpolacaoDeString
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variável
            string nome = "Pedro";

            // interpolação de string
            Console.WriteLine($"Bem vindo a programação C#, {nome}!");
            // o símbolo $ permite a interpolação

        } // fim main
    } // fim classe
} // fim name
