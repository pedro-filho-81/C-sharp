using System;
using static System.Console;

namespace OsDoisMaioresNumeros
{
    class Program
    {
        /*
            4.23 (Encontre os dois números maiores) Utilizando uma abordagem semelhante 
            àquela do Exercício 4.21, encontre os dois maiores valores  entre os 10 valores 
            inseridos. [Observação: você só pode inserir cada número uma vez.] 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 115). Edição do Kindle. 
            Autor: Pedro Filho 13/04/2021
        */
        static void Main(string[] args)
        {
            // variáveis
            int num = 0;
            int primeiroMaior = 0;
            int segundoMaior = 0;
            int contador = 0;

            // enquanto contador menor que 10
            while( contador < 10 )
            {
                // entrada de dados
                Write($"Digite o {contador + 1}º inteiro: ");
                num = int.Parse(ReadLine());

                // se contador igual a zero
                if( contador == 0 )
                {
                    primeiroMaior = num;
                    segundoMaior = num;
                }   // fim if

                // analisando os números
                // se primeiro maior menor que num
                if( primeiroMaior < num ) // se verdade
                {
                    // primeiro maior recebe num
                    primeiroMaior = num;
                } // fim if

                // se segundo maior menor que num e menor que primeiro maior
                else if( segundoMaior < num && segundoMaior < primeiroMaior )
                {
                    // segundo maior recebe num
                    segundoMaior = num;
                }
                // incrementar
                contador++;
            } // fim while

            // imprima o resultado
            Console.WriteLine($"Primeiro maior é {primeiroMaior} e o segundo maior é {segundoMaior}");
            ReadKey(); // pausa o programa
            Clear(); // limpa a tela
        } // fim main
    } // fim classe
} // fim namespace
