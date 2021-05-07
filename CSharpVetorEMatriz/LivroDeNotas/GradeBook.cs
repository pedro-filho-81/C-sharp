using System;
using static System.Console;

class GradeBook
{
    // cria vetor
    private int[] notasDosAlunos;

    // cria a propriedade
    public string NomeDoCurso { get; }

    // cria o construtor que recebe o nome do curso e as notas dos alunos
    public GradeBook( string nomeDoCurso, int[] notas )
    {
        // variável da classe recebe parâmetro
        notasDosAlunos = notas;
        // propriedade recebe parâmetro
        NomeDoCurso = nomeDoCurso;

    } // fim construtor

    // cria o método mostrar mensagem 
    public void MostrarMensagem()
    {
        // imprime a mensagem de boas vindas e recebe o nome do curso
        WriteLine($"Bem vindo ao curso: {NomeDoCurso}");

    } // fim método

    // método processando as notas
    public void ProcessandoAsNotas()
    {
        // chama o método mostrar bitas
        MostrarNotas();

        // chama o método média das notas
        WriteLine($"\nA Média das notas é {GetMediaDasNotas():F}" );
        
        // chama o método GetMinimo e GetMaimo
        WriteLine($"A menor nota é {GetMenorNota()}" );
        WriteLine($"A maior nota é {GetMaiorNota()}\n" );

        // chama o método grafico de barras
        GraficoDeBarras();

    } // fim método

    // cria o método menor nota
    public int GetMenorNota()
    {
        // cria a variável notas baixas que recebe a primeira nota do vetor
        var notasBaixas = notasDosAlunos[0];
        
        // loop for percorre o vetor notas dos alunos 
        foreach( var notaDoAluno in notasDosAlunos )
        {
            // verifica se a nota do aluno e menor que notas baixas
            if( notaDoAluno < notasBaixas ) // se verdade
            {
                // notas baixar recebe a nota do aluno
                notasBaixas = notaDoAluno;

            } // fim if
        } // fim foreach
        
        // retorne notas baixas
        return notasBaixas;        
    
    } // fim método

    // método maior valor
    public int GetMaiorNota()
    {
        // cria a variável maior nota que recebe a primeira nota do vetor
        var maiorNota = notasDosAlunos[ 0 ];

        // loop para buscar a maior nota no vetor
        foreach( var notaAlta in notasDosAlunos )
        {
            // verifica se a nota alta é maior que a maior nota
            if( notaAlta > maiorNota ) // se verdade
            {
                // maior nota receve o valor
                maiorNota = notaAlta;

            } // fim if
        } // fim for

        //nretorna a maior nota
        return maiorNota;
    } // fim método    

    // cria método média das notas
    public double GetMediaDasNotas()
    {
        // cria a variável total
        var total = 0.0;

        // loop para percorrer o vetor  notas dos alunos
        foreach( var nota in notasDosAlunos )
        {
            // total recebe a soma das notas do vetor
            total += nota;
        }

        // retorna a média das notas
        return total / notasDosAlunos.Length;
    } // fim método

    // cria método grafico de barras
    public void GraficoDeBarras()
    {
        // cabeçalho
        WriteLine("DISTRIBUIÇÃO DAS NOTAS" );

        // cria o vetor frequência
        var frequencia = new int[11];

        // loop para percorrer o vetor notas dos alunos
        foreach( var nota in notasDosAlunos )
        {
            // verifica a frequência das notas
            ++frequencia[ nota / 10 ];
        }

        // loop verifica a frequencia
        for( int contar = 0; contar < frequencia.Length; contar++ )
        {
            if( contar == 10 )
            {
                Write("100");
            }
            else
            {
                Write($"{contar * 10:D2} - {contar *10 + 9:D2}: " );
            }

            for( var inicio = 0; inicio < frequencia[ contar ]; inicio++ )
            {
                Write("*");
            }

            WriteLine();

        } // fim for
    
    } // fim método

    // cria método saída das notas
    public void MostrarNotas()
    {
        WriteLine("AS NOTAS SÃO");

        for( var estudantes = 0; estudantes < notasDosAlunos.Length; estudantes++ )
        {
            WriteLine($"Estudante{estudantes + 1, 2} : {notasDosAlunos[ estudantes ], 3 }" );
        } // fim for

    } // fim método

} // fim classe
