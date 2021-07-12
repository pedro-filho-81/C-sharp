using System;

class Empregado
{
    // cria propriedades
    public string PrimeiroNome {get;}
    public string UltimoNome {get;}

    // cria variável de instância
    private decimal salario;
    
    // cria construtor
    public Empregado( string primeiroNome, string ultimoNome, decimal salario )
    {
        PrimeiroNome = primeiroNome;
        UltimoNome = ultimoNome;
        Salario = salario;
    } // fim construtor

    // cria a propriedade salario
    public decimal Salario
    {
        get
        {
            return salario;
        } // fim get
        set
        {
            if( value >= 0M )
            {
                salario = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // retorna uma string contendo informações do empregado
    public override string Tostring() => ($"{PrimeiroNome, -10}{SegundoNome, -10}{Salario, 10:C2}");
    
} // fim da classe
