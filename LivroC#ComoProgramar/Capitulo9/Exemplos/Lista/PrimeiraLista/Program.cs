using System;
using static System.Console;
using System.Collections.Generic;

namespace PrimeiraLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("ADICIONANDO ITENS A UMA LISTA");

            // cria lista de strings itens
            var itens = new List<string>();

            // antes de adicionar um item
            WriteLine($"Antes de adicionar valores a lista itens a contagem é {itens.Count}, capacidade {itens.Capacity}");
            
            // ADICIONA um valor a lista itens
            itens.Add("vermelho"); // add adiciona um elemento ao fim da lista
            itens.Insert(0, "amarelo"); // Insert adiciona um elemento ao índice indicado

            // depois de adicionar valores a lista itens
            WriteLine($"Depois de adicionar valores a variável contar é {itens.Count} e a capacidade é {itens.Capacity}");

            // mostra as cores da lista
            WriteLine($"\n\nMostra com a instrução for as cores adicionadas na lista:");

            for( int i = 0; i < itens.Count; i++ )
            {
                Write($"{itens[i]} " );
            } // fim for

            // mostra as cores da lista
            WriteLine($"\n\nMostra com a instrução foreact as cores adicionadas na lista:");

            // loop para mostra os elementos da lista
            foreach(var elemento in itens )
            {
                Write($"{elemento} ");
            } // fim foreach

            // adicionando às cores verde e amarelo com Add
            itens.Add("Verde");
            itens.Add("Amarelo");

            WriteLine($"\n\nA lista depois de adicionar mais 2 cores: " +
                    $" Contagem = {itens.Count} Capacidade = {itens.Capacity}");

            WriteLine("A lista com mais dois elementos:" );
            
            foreach(var elemento in itens )
            {
                Write($"{elemento} ");
            } // fim foreach
            
            // removendo o primeiro amarelo da lista
            itens.Remove("amarelo");

            WriteLine( $"\n\nMostra a lista sem a string amarelo.\nUsando o comando itens.Remove(\"amarelo\")" );
            
            foreach(var elemento in itens )
            {
                Write($"{elemento} ");
            } // fim foreach
            
            // removendo o item do índice 1
            itens.RemoveAt( 1 );

            WriteLine("\n\nLista sem o item do índice = 1" +
                        "\nRemovido com a instrução itens.RemoveAt( 1 )");
            
            foreach(var elemento in itens )
            {
                Write($"{elemento} ");
            } // fim foreach

            WriteLine($"\n\nA lista depois de removido 2 itens: " +
                    $" Contagem = {itens.Count} Capacidade = {itens.Capacity}");

            // checando se um valor está na lista
            WriteLine("\n\nTem a cor vermelho na lista?" +
                    $"{ (itens.Contains("vermelho") ? "SIM" : "NÃO" )}");
    
        } // fim main
    } // fim classe
} // fim name
