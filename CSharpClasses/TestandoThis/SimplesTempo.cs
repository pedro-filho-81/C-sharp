using System;

class SimplesTempo
{
    // cria variáveis de instância
    private int hora;
    private int minutos;
    private int segundos;

    // cria construtor
    public SimplesTempo( int hora, int minutos, int segundos )
    {
        this.hora = hora;
        this.minutos = minutos;
        this.segundos = segundos;
    } // fim construtor

    // usando explicto e implicitamente "this" para chamar ToUniversalString()
    // método construir string
    public string ConstruirString() => 
                $"{"this.ToUniversalString()", 24}:{this.ToUniversalString()}" +
                $"\n{"ToUniversalString()", 24}:{ToUniversalString()}";
    public string ToUniversalString() => 
                $"{this.hora:D2}:{this.minutos:D2}:{this.segundos:D2}";
} // fim classe
