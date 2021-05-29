using System;

class Tempo1
{
    // cria propriedades da classe
    public int Hora { get; set; }
    public int Minutos { get; set; }
    public int Segundos { get; set; }

    // cria método configura tempo
    public void TempoAtual( int hora, int minutos, int segundos )
    {
        // se tempo 
        if( (hora < 0 || hora > 24) || (minutos < 0 || minutos > 60) || (segundos < 0 || segundos > 60) )
        {
            throw new ArgumentOutOfRangeException();
        } // fim if

        // porpriedade da classe recebe variáveis
        Hora = hora;
        Minutos = minutos;
        Segundos = segundos;
    } // fim método

    // convertendo string hora no formato universao (HH:MM:SS)
    public string FormatoHoraUniversal() =>
        $"{Hora:D2}:{Minutos:D2}:{Segundos:D2}";

    // imprime a hora universal
    public override string ToString() => $"{Hora == 0 || Hora == 12} ? 12 : {Hora % 12}:" +
                                        $"{Minutos:D2}:{Segundos:D2} {(Hora < 12 ? "AM":"PM")}";    

} // fim da classe {}
