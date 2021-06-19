using System;
using static System.Console;

namespace JogoDeDados
{
    class Program
    {
        /*
            Jogo Craps.
            Você rola dois dados. Cada dado tem seis faces, que contêm um, dois, 
            três, quatro, cinco e seis pontos, respectivamente. Depois que os dados 
            param, a soma dos pontos nas duas faces para cima é calculada. Se a soma 
            for 7 ou 11 no primeiro lance, você ganha. Se a soma for 2, 3 ou 12 no 
            primeiro lance (chamado de "dados"), você perde (ou seja, "a casa" ganha). 
            Se a soma for 4, 5, 6, 8, 9 ou 10 no primeiro lance, essa soma se tornará 
            seu "ponto". Para ganhar, você deve continuar lançando os dados até 
            "fazer seu ponto" (ou seja, lançar o mesmo valor de ponto). Você perde ao 
            obter um 7 antes de fazer seu ponto.
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto status do jogo
            Status statusDoJogo = Status.CONTINUI;
            

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
