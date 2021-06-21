using System;
using static System.Console;

namespace JogoDeDados
{
    class Program
    {
        class Craps
        {
            // cria enumeração com constantes que representam o status do jogo
            private enum Status { CONTINUE, VENCEU, PERDEU }

            private enum NomesDosDados
            {
                OlhoDaCobra = 2,
                Tres = 3,
                Sete = 7,
                Onze = 11,
                Doze = 12
            } // fim enum nomes dos dados

            // cria método main
            static void Main(string[] args)
            {
                // limpa a tela
                Clear();

                // cria o o bjeto status do jogo
                Status statusDoJogo = Status.CONTINUE;

                // cria meus pontos
                int meusPontos = 0;

                int somaDosDados = RolarDados();

                // cria switch
                switch((NomesDosDados)somaDosDados)
                {
                    case NomesDosDados.Sete:
                    case NomesDosDados.Onze:
                        statusDoJogo = Status.VENCEU;
                        break;

                    case NomesDosDados.OlhoDaCobra:
                    case NomesDosDados.Tres:
                    case NomesDosDados.Doze:
                        statusDoJogo = Status.PERDEU;
                        break;

                    default:
                        statusDoJogo = Status.CONTINUE;
                        meusPontos = somaDosDados;
                        Console.WriteLine($"Meus pontos são {meusPontos}" );
                        break;

                } // fim switch

                // enquanto o status do jogo for contunue
                while( statusDoJogo == Status.CONTINUE )
                {
                    somaDosDados = RolarDados();

                    // se a soma dos dados igual a meus pontos
                    if( somaDosDados == meusPontos )
                    {
                        statusDoJogo = Status.VENCEU;
                    } // fim if
                    else
                    {
                        if( somaDosDados == (int) NomesDosDados.Sete )
                        {
                            statusDoJogo = Status.PERDEU;
                        } // fim if do else
                    } // fim else
                } // fim while

                // se o status do jogo for venceu ou perdeu
                if( statusDoJogo == Status.VENCEU )
                {
                    WriteLine("Você VENCEU!" );
                } // FIM IF
                else
                {
                    WriteLine("Você PERDEU!" );
                } // fim else
            } // fim main

            // cria método Rolar dados
            static int RolarDados()
            {
                Random numerosAleatorios = new Random();

                // cria variáveis
                int dado1 = numerosAleatorios.Next( 1, 7 );
                int dado2 = numerosAleatorios.Next( 1, 7 );
                int soma = dado1 + dado2;

                // mostra a soma
                WriteLine($"Você rolou {dado1} + {dado2} = {soma}" );

                // retorne a soma
                return soma;
            } // fim método rolar dados

        } // fim classe craps
    } // fim class program
} // fim namespace
