using System;
using static System.Console;

namespace AritimeticaMenorMaior
{
    class Program
    {
        /*
            3.17 (Aritmético, Menor e Maior) Escreva um aplicativo que insere três inteiros 
            do usuário e exibe a soma, a média, o produto e o menor e o maior dos números. 
            Use as técnicas da Fig. 3.22. [Nota: O cálculo da média neste exercício deve 
            resultar em uma representação inteira da média. Portanto, se a soma dos valores 
            for 7, a média deve ser 2, não 2,3333….]
            Autor: Pedro Filho, 21-07-2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            int numero1;
            int numero2;
            int numero3;
            int soma = 0;
            int media = 0;
            int produto = 0;
            int menor = 0;
            int maior = 0;          

            // entrada de dados
            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(ReadLine());
            Write("Digite o segundo número: ");
            numero2 = int.Parse(ReadLine());
            Write("Digite o terceiro número: ");
            numero3 = int.Parse(ReadLine());

            //somar
            soma = numero1 + numero2 + numero3;
            // média
            media = soma / 3;
            // produto
            produto = numero1 * numero2 * numero3;

            // menor recebe número1
            menor = numero1;
            // maior recebe número 1
            maior = numero1;

            // se número2 menor que menor
            if( numero2 < menor )
            {
                menor = numero2;
            } // fim if

            // se número3 menor que menr
            if( numero3 < menor )
            {
                menor = numero3;
            } // fim if

            // se número2 maior que maior
            if( numero2 > maior )
            {
                maior = numero2;
            } // fim if

            if( numero3 > maior )
            {
                maior = numero3;
            } // fim if

            // mostra resultados
            WriteLine($"Soma => {numero1} + {numero2} + {numero3} = {soma}");
            WriteLine($"Média => {media}");
            WriteLine($"Produto => {numero1} * {numero2} * {numero3} = {produto}");
            WriteLine($"O menor valor é {menor}");
            WriteLine($"O maior valor é {maior}" );
            
        } // fim main
    } // fim classe
} // fim name
