using System;
using static System.Console;

namespace DesenhosComAsterisco
{
    class Program
    {
        /*
            3.18 (Exibindo formas com asteriscos) Escreva um aplicativo que exiba uma caixa, 
            uma oval, uma seta e um diamante usando asteriscos (*), como na Fig. 3.25.
            Autor: Pedro Filho, 22/07/2021
        */

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            Console.WriteLine("DESENHOS COM ASTERISCOS");

            // mostrando desenhos
            WriteLine("**********       ***         *          *");
            WriteLine("*        *     *     *      ***        * *");
            WriteLine("*        *    *       *    *****      *   *");
            WriteLine("*        *    *       *      *       *     *");
            WriteLine("*        *    *       *      *      *       *");
            WriteLine("*        *    *       *      *       *     *");
            WriteLine("*        *    *       *      *        *   *");
            WriteLine("*        *     *     *       *         * *");
            WriteLine("**********       ***         *          *");
        } // fim main
    } // fim classe
} // fim name
