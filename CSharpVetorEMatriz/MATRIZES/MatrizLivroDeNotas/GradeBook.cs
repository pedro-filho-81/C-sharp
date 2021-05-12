using System;
using static  System.Console;

class GradeBook
{
    // cria a matriz retangular notas dos alunos
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
        MostrarAsNotas();

        // chama os métodos MaiorNota e Menor Nota
        WriteLine($"\nA maior nota é {MaiorNota()}" );
        WriteLine($"A menor nota é {MenorNota()}\n" );

        // chama o método mostrar gráfico de barras
        GraficoDeBarras();
        
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
        var contarNotas = notasDosAlunos.GetLength(1);

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
    } // fim método média das notas

    // cria o método gráfico de barras
    public void GraficoDeBarras()
    {
        // CABEÇALHO
        WriteLine("GRÁFICO DE BARRAS" );

        // armazena a frequência de notas em cada 10 notas
        var frequencia = new int[11];

        // para cada nota em notas dos alunos, incrementa a frequência apropriada
        foreach( var nota in notasDosAlunos )
        {
            ++frequencia[ nota / 10 ];
        } // fim para cada nota

        for( int contar = 0; contar < frequencia.Length; contar++ )
        {
            // se contar igual a 10
            if( contar == 10 )
            {
                // imprima cem
                Write("  100:" );

            } // fim if contar
            // se não
            else
            {
                // imprima
                Write($"{contar * 10:D2}-{contar * 10 + 9:D2}: " );
            } // fim else

            // loop para a barra de asterisco
            for( int inicio = 0; inicio < frequencia[contar]; inicio++ )
            {
                // imprima
                Write( "*" );
            } // fim for asterisco

            WriteLine(); // pula uma linha
        } // fim função gráfico de barras

    } // fim método grafico de barras

    public void MostrarAsNotas()
    {
        // cabeçalho
        WriteLine("As notas são:\n");
        Write("            ");

        //loop para coluna
        for (int teste = 0; teste < notasDosAlunos.GetLength(1); teste++)
        {
            // imprima
            Write($"{" Teste", 11}{teste + 1}");

        } // fim for test

        WriteLine( $"{"Média", 9}" );

        // cria linha e coluna de teste representando matriz notas dos estudantes
        for( var estudantes = 0; estudantes < notasDosAlunos.GetLength(0); estudantes++ )
        {
            Write( $"Estudante{estudantes + 1, 2}" );

            // loop para mostrar estudantes e a nota
            for( var nota = 0; nota < notasDosAlunos.GetLength(1); nota++ )
            {
                // imprima
                Write($"{notasDosAlunos[estudantes, nota], 12}" );
            } // fim for nota

            // chama o método média dos alunos para calcular a média
            WriteLine($"{MediaDasNotas(estudantes), 10:N}");
            
        } // fim for estudante
    } // fim método gráfico de barras

} // fim classe GradeBook
