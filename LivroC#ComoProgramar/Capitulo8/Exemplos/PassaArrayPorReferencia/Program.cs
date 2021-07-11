using System;
using static System.Console;

namespace PassaArrayPorReferencia
{
    class Program
    {
        /*
            Testando a passagem de array por referencia, valor valor e referência
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // criando e inicializando o primeiro array 
            int [] primeiroArray = {1, 2, 3 };

            // copiando o primeiro array
            int[] firstArrayCopy = primeiroArray;

            WriteLine("Mostra o primeiro array passado por valor:" );
            WriteLine("Conteúdo do primeiro array antes da primeira cópia.\n\t" );

            // loop para mostrar os elementos do primeiro array
            foreach(var elementos in primeiroArray )
            {
                Write($"{elementos} ");
            }

            WriteLine();

            // chama o método primeira dupla
            FirstDouble(primeiroArray );

            WriteLine("\nMostra o conteúdo do primeiro array depois de FirstDouble.\n\t" );
            
            // loop para mostrar a cópia do array
            foreach( var elemento in firstArrayCopy )
            {
                Write($"{elemento} " );
            }

            if( primeiroArray == firstArrayCopy )
            {
                WriteLine("\n\nA referência se refere a alguns array." );
            }
            else
            {
                WriteLine("\n\nA referência se refere a diferentes array.");
            }

            // cria e inicializa o segundo array
            int[] segundoArray = {1, 2, 3};
            int[] copiaDoSegundoArray = segundoArray;

            WriteLine("\nPassando segundo array por referência.");
            WriteLine("Segundo array antes de chamar o método duplo segundo array.\n\t");

            foreach( var elemento in segundoArray )
            {
                Write($"{elemento} " );
            }

            WriteLine();

            // chama a função duplo segundo array
            DuploSegundoArray( ref segundoArray );

            WriteLine("\nConteúdo do segundo array após método DuploSegundoArray.\n\t");

            foreach( var elemento in segundoArray )
            {
                Write($"{elemento} " );
            }

            WriteLine();

            if( segundoArray == copiaDoSegundoArray )
            {
                WriteLine("\n\nA referêmcia se refere a alguns array." );
            }
            else
            {
                WriteLine("\n\nA referência não se refere a alguns array.");
            }

            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método
        static void FirstDouble( int[] array )
        {
            for( int i = 0; i < array.Length; i++ )
            {
                array[i] *= 2;
            }

            array = new int[] {11, 12, 13};
        } // fim método first double

        // caia o método
        static void DuploSegundoArray(ref int[] array )
        {
            for( int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }

            array = new int[] {11, 12, 13};
        } // fim método duplo segundo array

    } // fim classe
} // fim name
