using System;
using static System.Console;

class LivroDeNotas
{
    // cria o vetor notas
    private int[] notas;
    // cria a propriedade nome do curso
    public string NomeDoCurso { get; }

    // cria o construtor
    public LivroDeNotas( string nomeDoCurso, int[] vetorNotas )
    {
        NomeDoCurso = nomeDoCurso;
        notas = vetorNotas;
    } // fim construtor

    // mostra mensagem
    public void MostrarMensagem()
    {
        WriteLine($"Bem vindo ao livro de notas:\n {NomeDoCurso}!\n");
    } // fim método mostrar mensagem

    public void ProcessarNotas()
    {
        SaidaDasNotas();

        WriteLine($"A média da classe é {ObterMedia():F}" );

        WriteLine($"A maior nota é {ObterNotaMaxima()}");
        WriteLine($"A menor nota é {ObterNotaMinima()}" );

        MostraBarraDeCaractere();

    } // fim método processa notas

    // cria método obtem mínimo
    public int ObterNotaMinima()
    {
        var menorNota = notas[0];

        // loop para percorrer vetor em busca da menor nota
        foreach( var valor in notas )
        {
            // se valor maior que menor nota 
            if( valor < menorNota )
            {
                menorNota = valor;
            } // fim if

            return menorNota;
        } // fim for
    } // fim método obter mínimo

    // cria método maior nota
    public int ObterNotaMaxima()
    {
        var maiorNota = notas[ 0 ];

        // loop para obter a maior nota
        foreach( var valor in notas )
        {
            if( valor > maiorNota )
            {
                maiorNota = valor;
            } // fimif

            // retorne a maior nota
            return maiorNota;

        } // fim for
    } // fim método  maior nota

    // cria o método obtem média
    public double ObterMedia()
    {
        int total = 0.0F;

        // loop
        foreach( var nota in notas )
        {
            total += nota;
        } // fim for

        return total / notas.Length;
    } // fim método obter média

    
} // fim de classe