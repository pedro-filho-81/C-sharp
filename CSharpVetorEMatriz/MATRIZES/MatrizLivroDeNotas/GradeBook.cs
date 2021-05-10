using System;
using static  System.Console;

class GradeBook
{
    // cria a matriz retangular grade
    private int[ , ] notasDosAlunos;
    
    // cria a propriedade nome do curso
    public string NomeDoCurso { get; }

    // cria o construtor
    public GradeBook( string nomeDoCurso, int[ , ] notas )
    {
        // atribuindo a variável nome do curso a propriedade Nome do curso
        NomeDoCurso = nomeDoCurso;
        // atribuindo a matriz notas a variável da classe notas dos alunos
        notasDosAlunos = notas;

    } // fim construtor

    // cria o método mostrar mensagem
    public void MostrarMensagem()
    {
        WriteLine($"Bem vindo ao curso: {NomeDoCurso}!\n" );
    } // fim do método

    // cria o método processando as notas
    public void ProcessandoAsNotas()
    {
        // chama o método mostrar as notas
        //MostrarAsNotas();

        // chama os métodos MaiorNota e Menor Nota
        WriteLine($"A maior nota é {MaiorNota()}" );
        WriteLine($"A menor nota é {MenorNota()}\n" );

        // chama o método mostrar gráfico de barras
        //MostrarGraficoDeBarras();
        
    } // fim método processando notas

    // cria o método maior nota
    public int MaiorNota()
    {
        // cria a variável maior nota que recebe a primeira nota da
        // matriz notas dos alunos
        var maiorNota = notasDosAlunos[0,0];

        // loop para encontrar a maior nota na matriz notas dos alunos
        foreach( var nota in notasDosAlunos )
        {
            // se nota maior que maior nota
            if( nota > maiorNota )
            {
                // maior nota recebe nota
                maiorNota = nota;
            } // fim if
        } // fim foreach

        // retorne a maior nota
        return maiorNota;

    } // fim método maior nota

    // cria o método menor nota
    public int MenorNota()
    {
        // cria a variável menor nota e atribui o valor
        // do primeiro elemento da matriz notas dos alunos
        var menorNota = notasDosAlunos[0,0];

        // cria o loop para pesquisar a menor nota na matriz notas dos alunos
        foreach( var nota in notasDosAlunos )
        {
            // se a nota for menor que a menor nota
            if( nota < menorNota )
            {
                // menor nota receba a nota
                menorNota = nota;
            } // fim if
        } // fim foreach

        // retorne a menor nota
        return menorNota;

    } // fim método

    // cria o método média das notas
    public double MediaDasNotas( int estudantes )
    {
        // cria a variável contar notas que recebe
        // o tamanho da matriz notas dos alunos
        var contarNotas = notasDosAlunos[0,0];

        // cria a variável total que é inicializada com zero
        var total = 0.0;

        // loop para somar o total das notas dos alunos
        for( int exame = 0; exame < contarNotas; exame++ )
        {
            // total soma as notas dos alunos de cada estudante
            total += notasDosAlunos[ estudantes, exame ];
        } // fim for

        // retorne
        return total / contarNotas;
    } // fim método



} // fim classe GradeBook
