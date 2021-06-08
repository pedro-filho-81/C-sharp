using System;

class Data
{
    // cria variáveis de instância
    private int dia;
    private int mes;
    private int ano;

    public Data( int dia, int mes, int ano )
    {
        this.Dia = dia;
        this.Mes = mes;
        this.Ano = ano;

    } // fim construtor

    // cria a propriedade dia
    public int Dia
    {
        get
        {
            return dia;
        } // fim get
        set
        {
            if( value > 0 )
            {
            
                if( value < 32 )
                {
                    dia = value;
                } // fim if interno
                
            } // fim if
            
            if( value >= 32 )
            {
                dia = 00;
            } // fim if interno 2
 
        } // fim set

    } // fim propriedade dia

    public int Mes
    {
        get
        {
            return mes;
        } // fim get

        set
        {
            if( value > 0 )
            {
                if (value < 13 )
                {
                    mes = value;
                } // fim if interno
            } // fim if externo
            
            if( value > 13 )
            {
                mes = 00;
            } // fim if 
        } // fim set
    } // fim propriedade mês

    public int Ano
    {
        get
        {
            return ano;
        } // fim get

        set
        {
            if( value > 1900 )
            {
                if( value <= 3000 )
                {
                    ano = value;
                } // fim if interno
            } // if externo

            if (value >= 3000 )
            {
                ano = 0000;
            } // fim if
        } // fim set
    } // fim propriedade ano

    // cria o método mostra data
    public void MostraData()
    {
        // mostra data
        Console.WriteLine($"{Dia}/{Mes}/{Ano}");
    } // fim método mostrar data

} // fim classe
