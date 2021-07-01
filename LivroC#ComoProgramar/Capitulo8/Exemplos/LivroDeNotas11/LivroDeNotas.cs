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

    
} // fim de classe