using System;

class Empregado
{
    // propeiedades
    public int identidade;
    public string nomeDoEmpregado;
    public float salario;

    // método inserir dados
    public void inserirDados(int id, string nome, float sal)
    {
        // propriedades recebem variáveis
        identidade = id;
        nomeDoEmpregado = nome;
        salario = sal;
    } // fim método

    // método mostra dados
    public void mostrarDados()
    {
        Console.WriteLine($"O Funcionário {nomeDoEmpregado} ID {identidade} tem um salário de R${salario}\n");
    }// fim método mostra dados

} // fim classe Empregado