using System;

class Empregado
{
    // propeiedades publica da classe Empregado
    //sendo pública pode ser visto pelo programa principal;
    public int identidade;
    public string nomeDoEmpregado;
    public float salario;

    // cria o método inserir dados
    //sendo pública pode ser visto pelo programa principal;
    public void inserirDados(int id, string nome, float sal)
    {
        // propriedades recebem parâmetros
        identidade = id;
        nomeDoEmpregado = nome;
        salario = sal;
    } // fim método

    // cria o método mostra dados
    //sendo pública pode ser visto pelo programa principal;
    public void mostrarDados()
    {
        Console.WriteLine($"O Funcionário {nomeDoEmpregado} ID {identidade} tem um salário de R${salario}\n");
    }// fim método mostra dados

} // fim classe Empregado