using System;
using static System.Console;

namespace ArgumentoLinhaComando
{
    class Program
    {
        // inicializando array com argumentos de linha de comando
        static void Main(string[] args)
        {
            // limpar a tela
            Clear();

            // verifica o número de argumentos na linha
            if( args.Length != 3)
            {
                WriteLine("ERRO! Por favor, re-entre com o comando, incluindo\n" +
                            $"O tamanho do array, inicialize e incremente.");
            } // fim if
            else
            {
                // obtem o tamanho do array a partir do primeiro número na linha de comando
                var arrayLength = int.Parse(args[0]);
                int[] array = new int[arrayLength];

                // obtém o valor inicial e o incremento a partir do segundo número na linha de comando
                var initialValue = int.Parse(args[1]);
                var increment = int.Parse(args[2]);

                // calcula o valor de cada elemento do array
                for( int contar = 0; contar < array.Length; contar++ )
                {
                    array[contar] = initialValue + increment * contar;
                }

                WriteLine($"{"Index"}{"Value", 8}" );
                
                // exibe o valor
                for( int contar = 0; contar < array.Length; contar++)
                {
                    WriteLine($"{contar, 5}{array[contar], 8}");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
