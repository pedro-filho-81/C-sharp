using System;
using static System.Console;

class ClasseBaralhoDeCartas
{
    // cria o objeto randômico
    private static Random numeroAleatorio = new Random();

    // cria a constante número de cartas
    private const int NumerosDeCartas = 52;
    
    // cria o vetor baralho para a classe Cartas
    public Cartas[] baralho = new Cartas[ NumerosDeCartas ];

    // cria a variável carta atual
    private int cartaAtual = 0;

    // cria o construtor da classe
    public ClasseBaralhoDeCartas()
    {
        // cria o vetor string face que armazena o valor das cartas
        string[] face = {"Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", 
                        "Dez", "Valete", "Dama", "Rei" };

        // cria o vetor string naipe que armazena o tipo da carta
        string[] naipe = { "Copas", "Ouro", "Paus", "Espadas" };

        // loop for
        for( int contador = 0; contador < baralho.Length; contador++ )
        {
            baralho[ contador ] = new Cartas(face[contador % 13], naipe[ contador / 13 ] );
        } // fim for

    } // fim construtor

    // cria o método embaralhar cartas
    public void Embaralhar()
    {
        // carta atual comaça em zero
        cartaAtual = 0;

        // loop for para embaralhar as cartas
        for( int primeiro = 0; primeiro < baralho.Length; primeiro++ )
        {
            // cria uma variável que recebe um número aleatório
            var segundo = numeroAleatorio.Next(NumerosDeCartas);

            // embaralhando as cartas
            Cartas temp = baralho[ primeiro ];
            baralho[ primeiro ] = baralho[ segundo ];
            baralho[ segundo ] = temp;
        } // fim for
    } // fim método embaralhar

    // cria o método distribuir uma carta
    public Cartas DistribuirUmaCarta()
    {
        // se a carta atual menor que o tamanho do baralho
        if( cartaAtual < baralho.Length )
        {
            // retorne o baralho 
            return baralho[ cartaAtual++ ];
        }
        // se não
        else
        {
            // retorne o valor nulo
            return null;
        } // fim else
    } // fim função 
    
} // fim classe
