using System;

class Viagens
{
    // cria variáveis de instância
    private int quilometragemDaViagem;
    private int quantidadeDeCombustivel;
    private float consumo = 0;

    // cria construtor
    public Viagens( int quilometragemDaViagem, int quantidadeDeCombustivel )
    {
        this.quilometragemDaViagem = quilometragemDaViagem;
        this.quantidadeDeCombustivel = quantidadeDeCombustivel;
    } // fim construtor

    // cria propriedade Quilometragem da viagem
    public int QuilometragemDaViagem
    {
        get
        {
            return quilometragemDaViagem;
        } // fim get
        set
        {
            if( value > 0 )
            {
                quilometragemDaViagem = value;
            } // fim if

        } // fim set
    } // fim propriedade
    
    // cria propriedade quantidade de combustível
    public int QuantidadeDeCombustivel
    {
        get
        {
            return quantidadeDeCombustivel;
        } // fim get
        set
        {
            if( value > 0 )
            {
                quantidadeDeCombustivel = value;
            } // fim if
        } // fim set
    } // fim propriedade

    public float Consumo()
    {
        consumo = (float) quilometragemDaViagem / quantidadeDeCombustivel;
        return consumo;
    } // fim método consumo

}// fim classe viagens
