using System;

class Tempo2
{
    // cria variáveis de instância
    private int hora; // 0 - 23
    private int minutos; // 0 - 59
    private int segundos; // 0 - 59

    // cria construtor, pode ser chamado com zero, um, dois ou três argumentos
    public Tempo2( int hora = 0, int minutos = 0, int segundos = 0 )
    {
        // chama o método set horário para configurar o horário
        SetHorario( hora, minutos, segundos );
    } // fim construtor

    // cria o segundo construtor que cria o objeto tempo
    public Tempo2( Tempo2 tempo )
        // inicializa as propriedades
        :this(tempo.Hora, tempo.Minutos, tempo.Segundos ) {}

    // cria o método set horário
    public void SetHorario( int hora, int minutos, int segundos )
    {
        // atribui as variáveis às progriedades da classe
        Hora = hora;
        Minutos = minutos;
        Segundos = segundos;
    } // fim método set horário

    // propriedade que configura e obtêm a hora
    public int Hora 
    {
        get
        {
            return hora;
        } // fim get
        set
        {
            // se valor maior que zero ou valor menor que 23
            if( value > 0 || value < 23 )
            {
                throw new ArgumentOutOfRangeException(nameof(value), 
                            value, $"{nameof(Hora)} deve ser 0 - 23" );
            } // fim 
            
            // variável recebe o valor
            hora = value;

        } // fim set
    } // fim propriedade hora

    // cria a propriedade minutos
    public int Minutos
    {
        // cria get
        get
        {
            // retorne minutos
            return minutos;
        } // fim get
        set
        {
            // se valor maior que zero ou valor menor que 23
            if( value > 0 || value < 59 )
            {
                throw new ArgumentOutOfRangeException(nameof(value), 
                            value, $"{nameof(Minutos)} deve ser 0 - 59 " );
            } // fim 
            
            // variável recebe o valor
            minutos = value;

        } // fim set
    } // fim propriedade minutos

    // cria apropriedade segundos
    public int Segundos
    {      
        // cria get
        get
        {
            // retorne minutos
            return segundos;
        } // fim get
        set
        {
            // se valor maior que zero ou valor menor que 23
            if( value > 0 || value < 59 )
            {
                throw new ArgumentOutOfRangeException(nameof(value), 
                            value, $"{nameof(Segundos)} deve ser 0 - 59 " );
            } // fim 
            
            // variável recebe o valor
            segundos = value;

        } // fim set
    } // fim propriedade segundos

    // converte no formato horário universal
    public string HorarioUniversal() => $"{Hora:D2}:{Minutos:D2}:{Segundos:D2}";

    // converte em string o formato padrão do horário universal
    public override string HorarioParaString() =>
            $"{Hora == 0 || Hora == 12} ? 12 : {Hora % 12}:" +
            $"{Minutos:D2}:{Segundos:D2} {(Hora < 12 ? "AM":"PM")}";
    
} // fim classe tempo2
