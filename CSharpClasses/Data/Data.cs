using System;
using static System.Console;

class Data
{
    // cria variáveis
    private int mes; // 1 a 12
    private int dia; // 1 a 31
    
    // cria a propriedade ano
    public int ano { get; private set; } // auto inplemanta

    // cria o construtor
    public Data( int mes, int dia, int ano )
    {
        Mes = mes;
        Dia = dia;
        Ano = ano;

        WriteLine( $"O construtor para data: {this}" );

    } // fim construtor

    // cria a propriedade que retorna e configura o mês
    public int Mes
    {
        get
        {
            return mes;
        } // fim get
        // cria configuração
        private set
        {
            // se o valor for menor ou igual a zero ou maior ou igual a doze
            if( value <= 0 || value >= 12 )
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(Mes)} mês deve ser entre 1 - 12" );
            } // fim if

            // mês recebe o valor
            mes = value;

        } // fim set
    } // fim propriedade

    // cria a propriedade que retorna e configura o dia
    public int Dia
    {
        get
        {
            // retorna o valor do dia
            return dia;
        } // fim get
        // configura o dia
        private set
        {
            // cria o vetor para dias do mês
            int[] diasDoMes = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // verifica se o dia está dentro do intervalo do mês
            if( value <= 0 || value >= diasDoMes[Mes] )
            {
                // motre o aviso
                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(Dia)} Dia do mês inválido, " + 
                "verifique se o mês/ano está correto." );
            } // fim if

            // dia recebe o valor
            dia = value;

        } // fim set dia

    }
} // fim classe
