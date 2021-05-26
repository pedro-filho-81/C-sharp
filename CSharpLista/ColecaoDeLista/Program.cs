using System;
using static System.Console;
using System.Collections.Generic;

namespace ColecaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma variável que recebe uma nova lista de string
            var itens = new List<string>();

            // mostra a lista antes de adicionar elementos
            WriteLine($"Lista antes de adicionar elementos:\n" +
                    $"Conta os elementos na lista = {itens.Count}; Capacidade = {itens.Capacity};" );

            // adiciona um item no final da lista
            itens.Add( "vermelho" );
            // insere um item na posição zero
            itens.Insert(0, "azul");

            // mostra lista depois de adicionar elementos
            WriteLine($"\nLista depois de adicionar elementos:\n" +
                    $"Contar = {itens.Count}; Capacidade = {itens.Capacity};" );

            // imprime
            Write("\nMostra o conteúdo da lista: " );
            // loop for para mostrar os elementos da lista
            for( var i = 0; i < itens.Count; i++ )
            {
                // imprime
                Write($"{itens[i]} " );
            } // fim for

            // imprima
            Write("\nMostra o conteúdo da lista com foreach: " );
            // loop foreach para mostrar os elementos da lista
            foreach( var elementos in itens )
            {
                // mostra
                Write($"{elementos} " );
            } // fim foreach

            // adiciona doiw valores ao fim da lista
            itens.Add("verde");
            itens.Add("amarelo" );
            
            // mostra lista depois de adicionar elementos
            WriteLine($"\nLista depois de adicionar mais dois elementos:\n" +
                    $"Contar = {itens.Count}; Capacidade = {itens.Capacity};" );
        
            Write($"Mostra a lista com mais dois elementos: " );
            foreach(var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

            // removendo elemento do vetor
            itens.Remove("amarelo");
            
            Write($"\nMostra a lista depois de remover (amarela): " );
            foreach(var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

            itens.RemoveAt(1); // remove o item com o índice 1
            
            Write($"\nMostra a lista depois de remover o elemento do índice 1: " );
            foreach(var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

            // mostra lista depois de adicionar elementos
            WriteLine($"\nLista depois de remover dois elementos:\n" +
                    $"Contar = {itens.Count}; Capacidade = {itens.Capacity};" );

            WriteLine("\n\"vermelho\" " + 
                    $"{(itens.Contains("vermelho") ? string.Empty: "não")} está na lista." );

            // adiciona valores na lista
            itens.Add("laranja" );
            itens.Add("violeta" );
            itens.Add("azul" );
            itens.Add("vermelho");
            
            Write($"\nMostra a lista depois de remover o elemento do índice 1: " );
            foreach(var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

            // mostra lista depois de adicionar elementos
            WriteLine($"\nLista depois de remover dois elementos:\n" +
                    $"Contar = {itens.Count}; Capacidade = {itens.Capacity};" );

            // verifica se a palavre vermelho está na lista
            WriteLine("\n\"vermelho\" " + 
                    $"{(itens.Contains("vermelho") ? string.Empty: "não")} está na lista." );

        } // fim main
    } // fim classe
} // fim namespace
