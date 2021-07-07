using System;
using static System.Console;

class NotasDoAluno
{
    // cria uma matriz
    int[ , ] notas;

    // propriedade nome do curso
    public string NomeDoCurso { get; }

    public NotasDoAluno( string nomeDoCurso, int[ , ] matrizNotas )
    {
        NomeDoCurso = nomeDoCurso;
        notas = matrizNotas;
    } // fim construtor

    public void DisplayNotas()
    {
        WriteLine($"Bem vindo ao livro de notas do curso {NomeDoCurso}" );
    } // fim mostrar notas

    // cria método processo das notas
    public void ProcessandoNotas()
    {
        // mostrar notas
        //MostrarNotas();

        // mostrar resultado
        //WriteLine($"A menor nota é {MostrarMenorNota()}" +
                    //$"\nA maior nota é {MstrarMaiorNota()}" );
        
        // mostrar barras de caracteres
        //BarrasDeCaracteres();

    } // fim método processando notas

    // cria método menor nota
    public int ObterMenorNota()
    {
        int menorNota = notas[0, 0];

        foreach( var nota in notas )
        {
            // se nota menor que menor nota
            if( nota < menorNota)
            {
                menorNota = nota;
            } // fim if menor nota
        } // fim foreach

        return menorNota;
    } // fim método menor nota

    // cria método maior nota
    public int ObterMaiorNota()
    {
        int maiorNota = notas[0,0];

        foreach( var nota in notas )
        {
            if( nota > maiorNota )
            {
                maiorNota = nota;
            } // fim if
        } // fim foreach

        return maiorNota;
    } // fim método maior nota

    // cria método média
    public float ObterMedia( int estudante )
    {
        // cria variáveis
        var contaNotas = notas.GetLength(1);
        var total = 0.0f;

        for( int exame = 0; exame < contaNotas; exame++ )
        {
            total += notas[ estudante, exame ];
        } // fim for

        return total / contaNotas;

    } // fim método obter média

} // fim da classe
