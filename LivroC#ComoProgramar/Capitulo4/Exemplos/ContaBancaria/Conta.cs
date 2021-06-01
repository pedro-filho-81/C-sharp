using System;

class Conta
{
    // cria uma variável de instância
    private string nome;

    // cria o método configura o nome
    public void SetNome( string nomeDaConta )
    {
        // variável de instância recebe argumento
        nome = nomeDaConta;
    } // fim setNome

    // cria o método get name 
    public string GetNome()
    {
        // retorne o nome
        return nome;
    } // fim get nome

} // fim classe conta