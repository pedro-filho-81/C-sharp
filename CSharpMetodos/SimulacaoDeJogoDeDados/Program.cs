using System;
using static System.Console;

namespace SimulacaoDeJogoDeDados
{
    class Program
    {
        /*
            Um jogo popular de azar é um jogo de dados conhecido como craps, que é jogado 
            em cassinos e nas ruas de todo o mundo. As  regras do jogo são simples e diretas:  
            Você lança dois dados. Cada dado tem seis faces que contêm um, dois, três, 
            quatro, cinco e seis pontos,  respectivamente. Depois que os dados param de rolar, 
            a soma dos pontos nas faces viradas para cima é calculada.  Se a soma for 7 ou 11 
            no primeiro lance, você ganha. Se a soma for 2, 3 ou 12 no primeiro lance 
            (chamado  “craps”), você perde (isto é, a “casa” ganha). Se a soma for 4, 5, 6, 8, 9 
            ou 10 no primeiro lance, essa soma torna-  -se sua “pontuação”. Para ganhar, 
            você deve continuar a rolar os dados até “fazer sua pontuação” (isto é, obter  um valor 
            igual à sua pontuação). Você perde se obtiver um 7 antes de fazer sua pontuação. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 171). Edição do Kindle. 
            Pedro Filho, 26/04/2021.
        */
        
        //  cria o objeto Randon dado
        private static Random numeroAleatorio = new Random();

        // MÉtodo principal
        static void Main(string[] args)
        {
            // cria variável
            int meusPontos = 0; // pontos se não ganhar ou perder no jogo
            int statusDoJogo = 0; // pode conter CONTINUE, VENCEU ou PERDEU

            int somaDosDados = RolaDados(); // primeira rolagem dos dados

            // determina o estado jo jogo e a pontuação no primeiro lançamento
            switch (somaDosDados)
            {
                case 7: // CASO apareça o número 7
                case 11: // ou o número 11
                    // imprima
                    WriteLine("VOCÊ VENCEU!! NA PRIMEIRA JOGADA.");
                    break; // saia

                case 2: // caso apareça 2
                case 3: // ou 3
                case 12: // ou 12
                    // imprima
                    WriteLine("VOCÊ PERDEU! NA PRIMEIRA JOGADA.");
                    break; // saia

                default:  // se não
                    // imprima
                    WriteLine($"VOCÊ CONTINUA JOGANDO!");
                    // status recebe 1
                    statusDoJogo = 1;
                    // meus pontos recebe a soma dos dados
                    meusPontos = somaDosDados;
                    // imprime os pontos
                    WriteLine($"Meus pontos é {meusPontos}");
                    break; // sai do switch

            } // fim switch

            // enquanto
            while( statusDoJogo == 1 )
            {
                somaDosDados = RolaDados();
                if( somaDosDados == meusPontos )
                {
                    WriteLine("VOCÊ VENCEU!!!");
                    break;
                }
                else if( somaDosDados == 7 )
                {
                    WriteLine("VOCÊ PERDEU!");
                    break;
                }
            }

            Console.ReadKey();
            Console.Clear(); // limpa a tela

        } // fim main

        public static int RolaDados()
        {
            int dado1 = numeroAleatorio.Next( 1, 7 );
            int dado2 = numeroAleatorio.Next( 1, 7 );
            // soma dados
            int somaDados = dado1 + dado2;

            System.Console.WriteLine($"Jogador rolou {dado1} + {dado2} = {somaDados}");

            return somaDados;
        } // fim método

    } // fim classe
} // fim namespace
