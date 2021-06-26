using System;

class Horas
{
    // cria variáveis
    private int horas;
    private int minutos;
    private int segundos;

    // cria o construtor
    public Horas()
    {
        ConfigurarHora( 0, 0, 0 );
    } // fim construtor
    //cria método configura hora
    public void ConfigurarHora( int valorDaHora, int valorDoMinuto, int valorDoSegundo )
    {
        horas = ( valorDaHora >= 0 && valorDaHora < 24 ) ? valorDaHora : 0;
        minutos = ( valorDoMinuto >= 0 && valorDoMinuto < 60 ) ? valorDoMinuto : 0;
        segundos = ( valorDoSegundo >= 0 && valorDoSegundo < 60 ) ? valorDoSegundo : 0;

    } // fim método configurar hora

    // método string hora universal
    public string HoraUnuversal()
    {
        return String.Format($"{horas}:{minutos}:{segundos}" );
    } // fim hora universal

    public void MostraHoras()
    {
        Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}" );
    } // fim mostra horas

} // fim classe horas
