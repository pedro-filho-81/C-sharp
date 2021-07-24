using System;
using static System.Console;

class Aluno
{
    // cria as variáveis
    private decimal nota1;
    private decimal nota2;
    private decimal nota3;

    // cria propriedades
    public string IdDoAluno { get; set; }
    public string Nome { get; set; }
    public decimal Nota1
    { 
        get
        {
            return nota1;
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                nota1 = value;
            } // fim if
        } // fim set
                            
    } // fim propriedade

    public decimal Nota2 
    { 
        get
        {
            return nota2 ;
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                nota2 = value;
            } // fim if
        } // fim set
                            
    } // fim propriedade

    public decimal Nota3 
    { 
        get
        {
            return nota3;
        } // fim get
        set
        {
            if( value > 0.0m )
            {
                nota3 = value;
            } // fim if
        } // fim set
                            
    } // fim propriedade

    // cria o construtor
    public Aluno( string identidade, string nome, decimal nota1, decimal nota2, decimal nota3 )
    {
        IdDoAluno = identidade;
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    } // fim construtor

    // método soma
    public decimal Total( decimal nt1, decimal nt2, decimal nt3 )
    {
        return nt1 + nt2 + nt3;
    } // fim total

    public decimal Media( decimal total )
    {
        return total / 3;
    } // fim media
    
} // fim classe
