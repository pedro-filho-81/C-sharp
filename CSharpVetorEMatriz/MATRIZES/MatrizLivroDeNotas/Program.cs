using System;
using static System.Console;

namespace MatrizLivroDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria a matris notas
            int[ , ] matrizNotas = {{87, 96, 70},
                                    {68, 87, 90},
                                    {94, 100, 90},
                                    {100, 81, 82},
                                    {83, 65, 85},
                                    {78, 87, 65},
                                    {85, 75, 83},
                                    {91, 94, 100},
                                    {76, 72, 84},
                                    {87, 93, 73} };

                // cria o objeto de grad book
                GradeBook meuLivroDeNotas = new GradeBook("CS101 Introdução a programação C#", matrizNotas );

                // chama a função mostra mensagem
                meuLivroDeNotas.MostrarMensagem(); 

                // chama a função processando notas
                meuLivroDeNotas.ProcessandoAsNotas();

            // cria o objeto da classe


            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
