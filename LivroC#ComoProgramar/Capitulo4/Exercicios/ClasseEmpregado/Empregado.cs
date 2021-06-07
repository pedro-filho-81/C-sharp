using System;

class Empregado
{
    // cria variáveis de instância
    public string primeiroNome;
    public string ultimoNome;
    private decimal salarioMensal;

    // cria o construtor
    public Empregado( string primeiroNome, string ultimoNome, decimal salarioMensal )
    {
        this.primeiroNome = primeiroNome;
        this.ultimoNome = ultimoNome;
        SalarioMensal = salarioMensal;
    } // fim construtor

    // cria propriedade Salário mensal
    public decimal SalarioMensal
    {
        get
        {
            return salarioMensal;
        } // fim get
        set
        {
            if( value > 0.0m)
            {
                salarioMensal = value;
            } // fim if
        } // fim set    
    } // fim propriedade

    // cria método salário anual
    public decimal SalarioAnual( decimal salarioMensal )
    {
        return salarioMensal * 12;
    } // fim método salário anual

} // fim classe empregado
