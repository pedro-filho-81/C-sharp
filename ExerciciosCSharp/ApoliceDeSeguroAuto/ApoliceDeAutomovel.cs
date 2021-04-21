using System;

class ApoliceDeAutomovel
{
    // variáveis
    private int numeroDaConta;
    private string modeloDoCarro;
    private string estadoOndeFica;

    // construtor
    public ApoliceDeAutomovel(int numeroDaConta, string modeloDoCarro, string estadoOndeFica )
    {
        this.numeroDaConta = numeroDaConta;
        this.modeloDoCarro = modeloDoCarro;
        this.estadoOndeFica = estadoOndeFica;
    } // fim construtor

    public int NumeroDaConta
    {
        get
        {
            return numeroDaConta;
        } // fim get
    } // fim propriedade

    public string ModeloDoCarro
    {
        get
        {
            return modeloDoCarro;
        }
    } // fim propriedade Modelo

    public string EstadoOndeFica
    {
        get
        {
            return estadoOndeFica;
        }
    }

} // fim da classe
