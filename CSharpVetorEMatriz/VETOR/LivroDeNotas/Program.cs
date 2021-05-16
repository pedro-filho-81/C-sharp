using System;
using static System.Console;

namespace LivroDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um vetor para as notas
            int[] vetorDasNotas = { 87, 61, 94, 100, 83, 78, 55, 91, 76, 85 };

            // cria o objeto para GradeBook
            GradeBook meuLivroDeNotas = new GradeBook( "CS101 Introdução a programação C#.", vetorDasNotas );

            meuLivroDeNotas.MostrarMensagem();
            meuLivroDeNotas.ProcessandoAsNotas();
            
            Console.WriteLine("Hello World!");
        }
    }
}
