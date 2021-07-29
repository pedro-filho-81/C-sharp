using System;
using static System.Console;

class Coaching
{
    // variáveis
    private decimal encargos;

    // cria propriedades
    public string NomeDoTreinador { get; set; }
    public string Tempos { get; set; }
    public int Jogadores { get; set; }
    
    public decimal Encargos
    {
        get
        {
            return encargos;        
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                encargos = value;
            } // fim if
        } // fim set
    } // fim propriedade

    public Coaching( string nome, int jogadores, string tempos, decimal encargos )
    {
        NomeDoTreinador = nome;
        Jogadores = jogadores;
        Tempos = tempos;
        Encargos = encargos;

    } // fim construtor

    // método display
    public void DisplayDetails()
    {
        WriteLine($"Treinador: {NomeDoTreinador}" +
                    $"\nJogadores: {Jogadores}" +
                    $"\nTempo: {Tempos}" +
                    $"\nEncarcos: {Encargos:c}");
        WriteLine(); // pula uma linha
    } // fim dysplay

} // fim classe
