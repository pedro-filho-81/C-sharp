using System;
using static System.Console;

class ClasseBaralhoDeCartas
{
    // cria o objeto randômico
    private static Random numeroAleatorio = new Random();

    // cria a constante número de cartas
    private const int NumerosDeCartas = 52;
    // cria o objeto para a classe cartas
    public Cartas[] baralho = new Cartas[ NumerosDeCartas ];

    // cria a variável carta atual
    private int cartaAtual = 0;

    // cria o construtor da classe
    public ClasseBaralhoDeCartas()
    {
        // cria uma vetor string
        string[] face = {"Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", 
                        "Dez", "Valete", "Dama", "Rei" };

        string[] naipe = { "Copas", "Ouro", "Paus", "Espadas" };

        for( int contador = 0; contador < baralho.Length; contador++ )
        {
            baralho[ contador ] = new Cartas(face[contador % 13], naipe[ contador / 13 ] );
        } // fim for

    } // fim construtor

    public void Embaralhar()
    {
        // carta atual comaça em zero
        cartaAtual = 0;

        for( int primeiro = 0; primeiro < baralho.Length; primeiro++ )
        {
            var segundo = numeroAleatorio.Next(NumerosDeCartas);

            Cartas temp = baralho[ primeiro ];
            baralho[ primeiro ] = baralho[ segundo ];
            baralho[ segundo ] = temp;
        } // fim for
    } // fim método embaralhar

    public Cartas DistribuirUmaCarta()
    {
        if( cartaAtual < baralho.Length )
        {
            return baralho[ cartaAtual++ ];
        }
        else
        {
            return null;
        } // fim else
    } // fim função 
    
} // fim classe
