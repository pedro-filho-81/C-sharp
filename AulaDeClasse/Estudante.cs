using System;

// cria a classe publica estudante
class Estudante
{
    // cria as propriedades publicas da classe
    public int matricula;
    public string nomeDoAluno;

    // CRIA O MÉTODO DISPLAY
    // para mostrar as atribuições feitas pelo programa principal
    public void Display(int id, string nome)
    {
        // imprime 
        Console.WriteLine($"O aluno {nome} tem a matricula número{id}\n");
    } // fim método

}// fim classe estudante