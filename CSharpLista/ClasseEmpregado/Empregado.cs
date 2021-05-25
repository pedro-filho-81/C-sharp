class Empregado
{
    // cria as propriedades
    public string PrimeiroNome { get; }
    public string UltimoNome { get; }
    private decimal salarioMensal;

    // cria o construtor
    public Empregado( string primeiroNome, string ultimoNome, decimal salarioMensal )
    {
        // atribuindo 
        PrimeiroNome = primeiroNome;
        UltimoNome = ultimoNome;
        SalarioMensal = salarioMensal;
    } // fim construtor

    public decimal SalarioMensal
    {
        get
        {
            return salarioMensal;
        } // fim get
        set
        {
            // se valor maior ou igual a zero
            if( value >= 0M )
            {
                // salário mensal recebe o valor
                salarioMensal = value;
            } // fim if
        } // fim set
    } // fim propriedade

    // retorna uma string contendo as informações do empregado
    public override string ToString() => 
            $"{PrimeiroNome, -10} {UltimoNome, -10} {SalarioMensal, 10:C2}";    
} // fim classe empregado
