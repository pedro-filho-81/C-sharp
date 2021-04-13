using System;
using static System.Console;

namespace LocalizaMaiorNumero
{
    class Program
    {
        /*
            4.21 (Localize o maior número) O processo de localizar o maior valor é muito 
            utilizado em aplicativos de computador. Por exemplo, um  programa que determina 
            o vencedor de uma competição de vendas inseriria o número de unidades vendidas 
            por cada vendedor. O vendedor  que vende mais unidades ganha a competição. 
            Escreva um programa em pseudocódigo e, então, um aplicativo Java que aceita como 
            entrada  uma série de 10 inteiros e determina e imprime o maior dos inteiros. 
            Seu programa deve utilizar pelo menos as três variáveis a seguir:  a) counter: 
            um contador para contar até 10 (isto é, monitorar quantos números foram inseridos 
            e determinar quando todos os 10 nú-  meros foram processados).  
            b) number: o inteiro mais recentemente inserido pelo usuário.  
            c) largest: o maior número encontrado até agora. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 115). Edição do Kindle. 
            Autor: Pedro Filho 13/04/2021.
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int num = 0;
            int maior = 0;
            int contador = 0;

            // enqunto contador menor que 10 faça
            while( contador < 10 )
            {
                // entrada de dados
                Write( $"Digite um {contador + 1}º inteiro: " );
                num = int.Parse(ReadLine());

                // se o contador for igual a zero
                if( contador == 0 )
                    // maior recebe o primeiro valor de num
                    maior = num;

                // e verifica se num é maior que maior
                if( num > maior ) // se verdade
                {
                    // maior recebe o número
                    maior = num;
                } // fim if

                contador++; // soma 1 ao contador até 10

            } // fim while

             // imprima o maior valor
            WriteLine($"O maior valor é {maior} ");

            ReadKey(); // para o programa
            Clear(); // limpa a tela
        } // fim main
    } // fim classe
} // fim namespace
