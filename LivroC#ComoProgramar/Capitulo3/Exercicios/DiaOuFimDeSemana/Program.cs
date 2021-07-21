using System;
using static System.Console;

namespace DiaOuFimDeSemana
{
    class Program
    {
        /*
            3.16 (Dia da semana / fim de semana) Escreva um aplicativo 
            que peça ao usuário para inserir um número inteiro e exibe as 
            palavras "dia útil" se a entrada for de 1 a 5 ou "fim de semana" 
            se a entrada for 6 ou 7. Qualquer outra entrada deve ser exibida 
            "inválido". Use as técnicas mostradas na Fig. 3.22.
            Autor: Pedro Filho, 21/07/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // entrada de dados
            Write("Digite um número inteiro: " );
            int dia = int.Parse(ReadLine());

            // se dia está entre 1 a 5
            if( dia >= 1 )
            {
                if( dia <= 5 )
                {
                    // imprima
                    WriteLine($"{dia} é um dia útil." );
                } // fim if interno
            } // fi if externo

            // se dia igual a 6 ou 7
            if( dia >= 6 )
            {
                if( dia <= 7 )
                {
                    // imprima
                    WriteLine($"{dia} é fim de semana." );
                } // fim if
            } // fim if

            // se dia menor que zero e maior que 7
            if( dia <= 0 )
            {
                if( dia > 7 )
                {
                    WriteLine($"{dia} valor inválido." );
                } // fim if
            } // fim if

            Console.WriteLine("Hello World!");
        } // fimmain
    } // fim classe
} // fim name
