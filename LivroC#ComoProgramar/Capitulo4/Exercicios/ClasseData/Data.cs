using System;

class Data
{
    // cria variáveis de instância
    private int dia;
    private int mes;
    private int ano;

    public Data( int dia, int mes, int ano )
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;

    } // fim construtor

    // cria o método mostra data
    public void MostraData( int dia, int mes, int ano )
    {
        // mostra data
        Console.WriteLine($"{dia}/{mes}/{ano}");
    } // fim método mostrar data

} // fim classe
