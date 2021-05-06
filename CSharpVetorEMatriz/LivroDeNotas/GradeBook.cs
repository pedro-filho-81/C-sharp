using System;
using static System.Console;

class GradeBook
{
    // cria vetor
    private int[] grades;

    // cria a propriedade
    public string NomeDoCurso { get; }

    // cria o construtor
    public GradeBook( string nome, int[] grade )
    {
        // variável da classe recebe parâmetro
        grades = grade;
        // propriedade recebe parâmetro
        NomeDoCurso = nome;
    } // fim construtor

    // cria o método mostrar mensagem 
    public void MostrarMensagem()
    {
        WriteLine($"Bem vindo ao curso: {NomeDoCurso}");
    } // fim método

} // fim classe
