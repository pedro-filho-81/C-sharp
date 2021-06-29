using System;

class BaralhoDeCartas
{
    // cria objeto randomico
    Random numeroAleatorio = new Random();
 
    // cria a constante
    const int NumeroDeCartas = 52;
    // cria vetor baralho
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
            baralho[ contar ] = new Cartas(faces[ contar % 13], naipe[ contar / 13] );
        } // fim for        
    } // fim construtor

    // 
} // fim classe 