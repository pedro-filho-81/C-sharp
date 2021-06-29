using System;

class Cartas
{
    // cria propriedades
    private string Face { get; }
    private string Naipe { get; }

    // cria construtor
    public Cartas( string face, string naipe )
    {
        Face = face;
        Naipe = naipe;
    } // fim construtor

    // retorna representação das cartas
    public override string ToString() => $"{Face} de {Naipe}";

} // fim classe cartas
