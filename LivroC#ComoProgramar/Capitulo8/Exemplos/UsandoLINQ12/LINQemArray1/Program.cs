using System;
using static System.Console;
using System.Linq;

namespace LINQemarray1
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um array
            int[] valores = {2, 0, 9, 8, 1, 3, 4, 5, 7, 6};

            WriteLine("TRABALHANDO COM LINQ");

            // mostra os valores originais
            WriteLine("Mostra os valores originais do array: ");

            // loop para mostra os valores do vetor
            foreach( var valor in valores)
            {
                Write($"{valor} " );
            } // fim foreach

            // pula linha
            WriteLine();

            // LINQ para obter os valores do array maiores que 4
            var filtrar =
                from valor in valores
                where valor > 4
                select valor;

            WriteLine("Mostra os valores do array maiores que 4:" );

            // mostra o resultado da filtragem
            foreach( var valor in filtrar )
            {
                Write($"{valor} ");
            } // fim foreach
            
            // LINQ para ordenar os valores do array
            WriteLine("\nMortrar os valores do array em ordem crescente.");

            var ordenar =
                from valor in valores
                orderby valor
                select valor;

            // loop para mostrar os valores ordenado
            foreach( var valor in ordenar )
            {
                Write($"{valor} " );
            } // fim foreach

            WriteLine("\nMostra os valores do array em ordem decrescente:");

            // LINQ para mostrar os valores ordenado em ordem decrescente
            var ordemDecrescente = 
                from valor in valores
                orderby valor descending
                select valor;

            // loop para mostra os valores
            foreach( var valor in ordemDecrescente )
            {
                Write($"{valor} ");
            }// fim foreach

            // LINQ para mostrar os valores maiores que 4 em ordem decrescente
            WriteLine("\nMostra os valores maiores que 4 em ordem decrescente:");

            var maiorQue4emOrdem = // cria variável
                from valor in valores // fonte de dados
                where valor > 4 // condição
                orderby valor descending // coloca em ordem
                select valor; // seleciona o objeto

            // loop para mostrar os valores
            foreach( var valor in maiorQue4emOrdem )
            {
                Write($"{valor} ");
            } // fim foreach
            
            Console.WriteLine("\nHello World!");
        } // fim main
    } // fim classe
} // fim name
