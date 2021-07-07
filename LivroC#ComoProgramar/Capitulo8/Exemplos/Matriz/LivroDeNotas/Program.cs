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

            // cria matriz
            int[ , ] matrizNotas = {{87, 97, 100},
                                    {69, 58, 41},
                                    {36, 25, 10},
                                    {100, 81, 82},
                                    {38, 56, 20},
                                    {11, 90, 40},
                                    };
            // cria o objeto da classe notas do aluno
            var minhasNotas = new NotasDoAluno("C# 6 para programadores.", notas );

            Console.WriteLine("Hello World!");
        }
    }
}
