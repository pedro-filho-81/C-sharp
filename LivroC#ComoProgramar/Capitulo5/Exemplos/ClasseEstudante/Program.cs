using System;
using static System.Console;

namespace ClasseEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria objeto da classe Estudante
            Estudante mediaDoAluno = new Estudante("Pedro", 95 );
            // chama o método mostra a média
            MostraMedia( mediaDoAluno );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método mostra media
        public static void MostraMedia( Estudante minhaMedia )
        {
            // mosta a média
            WriteLine($"{minhaMedia.Nome} média {minhaMedia.Media}" );
        } // fim método mostra a media

    } // fim classe
} // fim namespace
