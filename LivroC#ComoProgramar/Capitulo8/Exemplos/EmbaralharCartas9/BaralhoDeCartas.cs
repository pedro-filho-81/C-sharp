using System;

class BaralhoDeCartas
{
    // cria objeto randomico
    private static Random numeroAleatorio = new Random();
    // cria a constante
    private const int NumeroDeCartas = 52;
    // cria vetor baralho do tipo Cartas
    private Cartas[] baralho = new Cartas[ NumeroDeCartas ];
    // cria variável
    private int cartaAtual = 0;

    // cria construtor
    public BaralhoDeCartas()
    {
        string[] faces = {"As", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito",
                            "Nove", "Dez", "Valete", "Dama", "Rei" };
        string[] naipe = { "Ouros", "Espadas", "Copas", "Paus" };

        for( var contar = 0; contar < baralho.Length; contar++ )
        {
            baralho[ contar ] = new Cartas( faces[ contar % 13], naipe[ contar / 13] );
        } // fim for        
    } // fim construtor 

    // cria metodo embaralhar
    public void Embaralhar()
    {
        // atribuir valores
        cartaAtual = 0;

        // loop 
        for( var primeiro = 0; primeiro < baralho.Length; ++primeiro )
        {
            var segundo = numeroAleatorio.Next( NumeroDeCartas );

            Cartas temporario = baralho[ primeiro ];
            baralho[primeiro] = baralho[ segundo ];
            baralho[ segundo ] = temporario;
        } // fim for
    } // fim método embaralhar

    public Cartas DarCartas()
    {
        if( cartaAtual < baralho.Length )
        {
            return baralho[ cartaAtual++ ];
        }// fim if
        else
        {
            return null;
        } // fim else
    } // fim método dar cartas
} // fim classe 