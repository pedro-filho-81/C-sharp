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

            // loop para mostra os elementos da lista
            foreach(var elemento in itens )
            {
                WriteLine($"{elemento}");
            }

            // depois de adicionar valores a lista itens
            WriteLine($"Depois de adicionar valores a variável contar é {itens.Count} e a capacidade é {itens.Capacity}");

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
