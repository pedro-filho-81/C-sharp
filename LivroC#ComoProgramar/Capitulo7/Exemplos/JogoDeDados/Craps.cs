using System;

class Craps
{
    // cria o objeto randon
    private static Random numeroAleatorio = new Random();

    // cria o enumerador
    private enum Status { CONTINUI, VENCEU, PERDEU }

    private enum NomeDosDados
    {
        OlhoDaCobra = 2,
        Tres = 3,
        Sete = 7,
        Onze = 11,
        Doze = 12
    } // fim enum

    public static void main(String[] args)
    {
        Status statusDoJogo = Status.CONTINUI;

        int meusPontos = 0;

        int somaDosDados = RolaDados();

        switch((NomeDosDados)somaDosDados)
        {
            case NomeDosDados.Sete:
            case NomeDosDados.Onze:
                statusDoJogo = Status.VENCEU;
                break;

            case NomeDosDados.OlhoDaCobra:
            case NomeDosDados.Tres:
            case NomeDosDados.Doze:
                statusDoJogo = Status.PERDEU;
                break;

            default:
                statusDoJogo = Status.CONTINUI;
                meusPontos = somaDosDados;
                Console.WriteLine($"Meus pontos são {meusPontos}");
                break;
        } // fim switch 

        // enquanto status do jogo continue
        while( statusDoJogo == Status.CONTINUI )
        {
            somaDosDados = RolaDados();

            if( somaDosDados == meusPontos )
            {
                statusDoJogo = Status.VENCEU;
            } // fim if
            else
            {
                if(somaDosDados == (int) NomeDosDados.Sete )
                {
                    statusDoJogo = Status.PERDEU;
                } // fim if
            } // fim else
        } // fim while

        if( statusDoJogo == Status.VENCEU )
        {
            Console.WriteLine("Você venceu!" );
        } // fim if
        else
        {
            Console.WriteLine("Você perdeu!" );
        } // fim else
    } // fim main

    // cria método
    static int RolaDados()
    {
        // cria variáveis dados
        int dado1 = numeroAleatorio.Next( 1, 7 );
        int dado2 = numeroAleatorio.Next( 1, 7 );

        int soma = dado1 + dado2;

        // mostar resultado
        Console.WriteLine($"Você jogou {dado1} + {dado2} = {soma}" );

        // retorne a soma
        return soma;
    } // fim método
} // fim classe
