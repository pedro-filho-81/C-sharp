using System;
using static System.Console;

namespace ListaDeArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            Console.WriteLine("Hello World!");
        }

        static double Media(params double[] numeros )
        {
            // cria variável
            var total = 0.0;

            // cria um loop para percorrer o vetor
            foreach( var valor in numeros )
            {
                // variável total soma os valores do vetor números 
                total += valor;
            } // fim foreach
        } // fim função
        
    }
}
