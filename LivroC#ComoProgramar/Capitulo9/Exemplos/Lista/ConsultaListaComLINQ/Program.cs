using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace ConsultaListaComLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma lista do tipo string de nome itens
            var itens = new List<string>();

            // cabeçalho
            WriteLine("CONSULTANDO A LISTA USANDO LINQ");
            WriteLine("Mostrando a lista original:" );

            // adiciona elementos a lista com o método Add
            itens.Add("aQua");
            itens.Add("RusT");
            itens.Add("YElloW");
            itens.Add("rEd");

            // loop para mostra a lista
            foreach( var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

            WriteLine(); // pula uma linha

            // usando LINQ para colocar em maiúscula às strings na lista
            var iniciaComR =
                from item in itens // de item em itens 
                let mudarParaMaiusculas = item.ToUpper() // mude para maiúsculas
                where mudarParaMaiusculas.StartsWith("R") // onde comece com a letra R
                orderby mudarParaMaiusculas // organize em ordem crescente
                select mudarParaMaiusculas; // selecione mudar para maiúsculas

            // imprime
            WriteLine("\nLista às strings que começam com a letra R:" +
                        "\norganiza em ordem cescente e muda as palavras para letras maiúsculas.");

            // loop para mostrar os elementos de itens comforme a consulta LINQ
            foreach( var item in iniciaComR )
            {
                Write($"{item} ");
            } // fim foreach

            // adiciona mais duas palavras a lista
            itens.Add("rUby");
            itens.Add("SaFfRon");

            // imprime
            WriteLine("\nLista após a inclusão de mais duas palavras:");

            // loop para mostrar os elementos de itens comforme a consulta LINQ
            foreach( var item in iniciaComR )
            {
                Write($"{item} ");
            } // fim foreach

            WriteLine("\nMostra a lista original depois de incluir mais 2 palavras.");

            foreach( var item in itens )
            {
                Write($"{item} " );
            } // fim foreach

        } // fim main
    } // fim classe
} // fim name
