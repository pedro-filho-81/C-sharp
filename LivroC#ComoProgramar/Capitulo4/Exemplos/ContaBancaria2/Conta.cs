using System;

class Conta
{
    // cria variável de instância
    private string nomeDaConta;

    // Cria a propriedade Set nome da conta
    public string Nome
    {
        get
        { 
            // retorna o nome da conta
            return nomeDaConta;
        }
        set
        {
            // propriedade nome recebe o nome da conta
            nomeDaConta = value;
        } // fim set

    } // fim propriedade Nome

} // fim classe
