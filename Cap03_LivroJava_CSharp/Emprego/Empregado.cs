using System;

class Empregado
{
    // variáveis de instâancia
    private string nome;
    private string sobreNome;
    private decimal salario;

    // construtor da classe
    public Empregado( string nome, string sobreNome, decimal salario )
    {
        this.nome = nome;
        this.sobreNome = sobreNome;
        this.salario = salario;

    } // fim construtor

    // propriedade nome
    public string Nome
    {
        get
        {
            return nome;
        } // fim get
    } // fim propriedade

    // propriedade sobreNome
    public string SobreNome
    {
        get
        {
            return sobreNome;
        } // fim get
    } // fim propriedade

    // propriedade salário
    public decimal Salario
    {
        get
        {
            return salario;
        } // fim get
        private set
        {
            // se salário menor ou igual a zero
            if( value >= 0.0M )
            {
                salario = value;
            } // fim if
        } // fim set

    } // fim propriedade
} // fim classe