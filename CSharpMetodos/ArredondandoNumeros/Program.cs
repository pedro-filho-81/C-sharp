using System;
using static System.Console;

namespace ArredondandoNumeros
{
    class Program
    {
        /*
            6.9 (Arredondando números) Math.floor pode ser utilizado para arredondar valores 
            ao número inteiro mais próximo — por exemplo,  y = Math.floor(x + 0.5);  arredondará 
            o número x para o inteiro mais próximo e atribuirá o resultado a y. Escreva 
            um aplicativo que lê valores double e utiliza a  instrução anterior para 
            arredondar cada um dos números para o inteiro mais próximo. Para cada número processado, 
            exiba ambos os nú-  meros, o original e o arredondado. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 186). Edição do Kindle. 
            Autor: Pedro Filho, 30/04/2021.
        */
        static void Main(string[] args)
        {
            // cria variável
            double numero = 0.0;
            double resposta = 0;

            // entrada de dados
            Write("Digite um valor: ");
            numero = float.Parse(ReadLine());

            // resposta recebe o valor arredondado pelo método
            resposta = ArredondarNumero(numero);

            // mostra o resultado
            Console.WriteLine($"O número {numero:N2} foi arredondado para {resposta}");

        } // fim main

        public static double ArredondarNumero( double numero )
        {            
            // arredonda o número
            double arredondar = Math.Floor(numero + 0.5);
            return arredondar;
        } // fim função

    } // fim classe
} // fim namespace
