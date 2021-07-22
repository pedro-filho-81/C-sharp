using System;
using static System.Console;

namespace Multiplos
{
    class Program
    {        
        /*
            3,25 (múltiplos) Escreva um aplicativo que lê dois inteiros, determina se 
            o primeiro é um múltiplo do segundo e exibe o resultado. [Dica: use o operador 
            restante.]
            Autor: Pedro Filho, 22/07/2021
        */
     
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variável
            int numero1;
            int numero2;

            // cabeçalho
            WriteLine("NÚMEROS MULTIPOLOS");
            
            // entrada de dados
            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(ReadLine());
            Write("Digite o segundo número: ");
            numero2 = int.Parse(ReadLine());

            // se o primeiro número é multiplo do segundo
            if( numero1 % numero2 == 0 )
            {
                WriteLine($"{numero1} é multiplo de {numero2}");
            } // fim if
            
            if( numero1 % numero2 != 0 )
            {
                WriteLine($"{numero1} não é multiplo de {numero2}" );
            } // fim if
        } // fim main
    } // fim classe
} // fim name
