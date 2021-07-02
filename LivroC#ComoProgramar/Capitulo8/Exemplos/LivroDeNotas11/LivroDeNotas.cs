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

        WriteLine($"A maior nota é {ObterMaiorNota()}");
        WriteLine($"A menor nota é {ObterMenorNota()}" );

        // pula linha
        WriteLine();

        MostraBarraDeCaractere();

    } // fim método processa notas

    // cria método obtem mínimo
    public int ObterMenorNota()
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
        } // fim for

        return menorNota;

    } // fim método obter mínimo

    // cria método maior nota
    public int ObterMaiorNota()
    {
        var maiorNota = notas[ 0 ];

        // loop para obter a maior nota
        foreach( var valor in notas )
        {
            if( valor > maiorNota )
            {
                maiorNota = valor;
            } // fimif
        } // fim for

        // retorne a maior nota
        return maiorNota;
    } // fim método  maior nota

    // cria o método obtem média
    public double ObterMedia()
    {
        float total = 0.0F;

        // loop
        foreach( var nota in notas )
        {
            total += nota;
        } // fim for

        return total / notas.Length;
    } // fim método obter média

    // cria método barra de caractere
    public void MostraBarraDeCaractere()
    {
        WriteLine("DISTRIBUIÇÃO DAS NOTAS");

        // CRIA VETOR FREQUÊNCIA
        int[] frequencia = new int[ 11 ];

        // cria loop para verificar a frequência
        foreach( var nota in notas)
        {
            ++frequencia[ nota / 10 ];
        } // fim foreach

        // cria loop para mostrar a frequência
        for( int i = 0; i < frequencia.Length; i++ )
        {
            // se i igual a 10 imprima 100
            if( i == 10 )
            {
                WriteLine("100" );
            } // fim if
            else // se não
            {
                // imprima
                Write($"{ i * 10:D2}:{ i * 10 + 9:D2} " );

                // loop para mostra os caracteres
                for( var estrela = 0; estrela < notas[ i ] / 10; estrela++ )
                {
                    Write("*" );
                } // fim for estrela

            } // fim else
            
            // pula uma linha
            WriteLine();

        } // fim for
    } // fim método saída das notas

    // cria método saída de notas
    public void SaidaDasNotas()
    {
        WriteLine("As notas são: " );

        // loop
        for( var estudante = 0; estudante < notas.Length; estudante++ )
        {
            WriteLine($"Estudante{estudante + 1, 3}{ notas[ estudante ], 4}" );
        } // fim for

        // pula uma linha
        WriteLine();
    }// fim método saída das notas
} // fim de classe
