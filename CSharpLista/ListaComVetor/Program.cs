using System;
using static System.Console;
using System.Linq;

namespace ListaComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            // cria um vetor e atribui valor
            int[] vetor = { 2, 5, 9, 7, 8, 6, 1, 4, 2, 3, 0 };

            Write( $"Vetor original: " );
            // loop para mostra o vetor original
            foreach( var numero in vetor )
            {
                // imprima os números
                Write( $"{numero} " );
            } // fim

            // cria variável que recebe
            var filtrando = from valor in vetor where valor > 4 select valor;

            // imprima
            Write( $"\nMosta valores maiores que 4: " );
            // loop para mostrar os valores maiores que 4
            // para cada elemento em filtrando maior que 4
            foreach( var elementos in filtrando )
            {
                // imprima o elemento
                Write( $"{elementos} " );
            } // fim foreach

            // imprime vetor em ordem
            Write( $"\nVetor em ordem crecen: " );
            // cria variável que recebe vetor ordenado
            var vetorEmOrdem = from valor in vetor orderby valor select valor;
            // loop para mostrar o vetor ordenado
            foreach( var elemento in vetorEmOrdem )
            {
                // imprima
                Write( $"{elemento} " );
            } // fim foreach

            // cria variável
            var organizaREsultado = from valor in vetor orderby valor descending select valor;
            // imprime
            Write( $"\nResultado organizado: " );
            foreach( var valor in organizaREsultado )
                Console.Write($"{valor} " ); // imprima

            var organizaFiltrando = from valor in filtrando orderby valor descending select valor;
            Write( $"\nVetor filtrando organizado: " );
            foreach( var valor in organizaFiltrando )
            {
                Write( $"{valor} " );
            } // fim foreach

            // cria variável que recebe instruções
            var filtraOrganiza = from valor in vetor where valor < 5 orderby valor descending select valor;
            Write( $"\nOrganiza valor menor que 5: " );
            foreach( var valor in filtraOrganiza )
                Write( $"{valor} " );

        } // fim main
    } // fim classe
} // fim namespace
