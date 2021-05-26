using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace ConsultaListaComLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // CRIA uma lista para strings
            var itens = new List<string>();
            // adiciona elementos na lista
            itens.Add("aQua");
            itens.Add("RusT");
            itens.Add("yElLow");
            itens.Add("rEd");
            
            // cabeçalho
            WriteLine("CONSULTANDO LISTA COM LINQ");
            
            // mostra lista original
            Write("Lista original: ");
            // loop para mostrar o conteúdo da lista
            foreach( var elementos in itens )
            {
                // mostra
                Write($"{elementos} " );
            } // fim foreach

            WriteLine(); // pula uma linha

            // cria e atribui uma consulta a variável
            var comeceComR = from elemento in itens
            // deixa os elementos com as letras em maiúsculas
            let letrasMaiusculas = elemento.ToUpper()
            // onde os elementos comecem com a letra r
            where letrasMaiusculas.StartsWith("R")
            // organiza em ordem crescente
            orderby letrasMaiusculas
            // seleciona as letras maiúsculas
            select letrasMaiusculas;

            // mostra lista
            WriteLine("Mostra lista com os elementos com letras maiúsculas" );
            // loop foreach para mostra os elementos
            foreach( var elemento in comeceComR )
            {
                // imprima os elementos da lista itens
                Write($"{elemento} " );
            }  // fim foreach

            WriteLine(); // pule uma linha

            // adicione elementos a lista
            itens.Add("rUby");
            itens.Add("SaFRon");

            // imprima
            Write("Mostra lista original com mais dois elementos: " );
            foreach( var elementos in itens )
            {
                // imprimaa
                Write($"{elementos} ");
            } // fim foreach

            WriteLine(); // pule uma linha

            // imprima
            Write("Mostra os elementos que começam com a letra R: " );
            foreach( var elementos in comeceComR )
            {
                // imprimaa
                Write($"{elementos} ");
            } // fim foreach

        } // fim main
    } // fim classe
} // fim namespace
