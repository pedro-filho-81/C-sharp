using System;
using static System.Console;

class Cartas
{
    // propriedade face das cartas (é um ás ou um dois etc.)
    private string Face { get; }
    // propriedade 
    private string Naipe { get; }

    // cria o construtor
    public Cartas( string face, string naipe )
    {
        // atribui variáveis às propriedades
        Face = face;
        Naipe = naipe;
    } // fim construtor

    // retorna a representação da string do cartão
    public override string ToString() => $"{Face} de {Naipe}";

} // fim da classe Cartas