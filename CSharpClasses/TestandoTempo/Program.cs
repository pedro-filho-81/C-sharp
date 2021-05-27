﻿using System;
using static System.Console;

namespace TestandoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria e inicializa o objeto da classe Tempo1
            var hora = new Tempo1(); // invoca a classe Tempo1

            // mostra cabeçalho
            WriteLine("MOSTRA PADRÃO DA HORA ATUAL" );

            // mostra a string representando a hora
            WriteLine($"O início da hora universal é: {hora.FormatoHoraUniversal()}" );

            WriteLine($"O padrão da hora universal é: {hora.ToString()}" );

            // chama método
            hora.TempoAtual(13,30,35);        

            // mostra
            WriteLine($"\nMostra a hora universal depois da chamada do método TempoAtual():" );
            WriteLine($"A hora atual é: {(hora.FormatoHoraUniversal())}" );
            WriteLine($"Padrão da hora atual: {hora.ToString()}" );

            // pula linha
            WriteLine();
            
        } // fim main
    } // fim classe
} // fim namespace
