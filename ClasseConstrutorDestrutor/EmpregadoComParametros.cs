using System;

public class EmpregadoParametrizado
{
    // cria propriedades da classe
    public int identidade;
    public string nomeFuncionario;
    public float salario;

    // cria o construtor da classe
    public void ConstrutorFuncParametrizado(int i, string nome, float sal)
    {
        // propriedades recebem parâmetros
        identidade = i;
        nomeFuncionario = nome;
        salario = sal;

    } // fim construtor

    // cria display
    public void Display()
    {
        Console.WriteLine($"\nO funcionário {nomeFuncionario}\nidentidade número {identidade}\nrecebe R${salario}");
    } // fim display

}// fim classe
