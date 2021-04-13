using System;
using static System.Console;

namespace SaidaNoFormatoTabela
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variável
            int contador = 0;
            // cabeçalho da tabela
            WriteLine($"{'N', 7}{"10*N",7}{"100*N",10}{"1000*N", 12}  ");
            // enquanto contador menor que 10 faça
            while( contador < 10 )
            {
                // imprime os valores da tabela
                WriteLine($"{contador + 1, 7}{(contador + 1)  * 10,7}{(contador + 1) * 100,10}{(contador + 1) * 1000, 12}");
                contador++; // soma 1 ao contador
            } // fim while

            ReadKey();
            Clear();
        } // fim main
    } // fim classe
} //  fim namespace
