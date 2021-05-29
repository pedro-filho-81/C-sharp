using System;
using static System.Console;

namespace TesteAcessandoMembros
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa tela
            Clear();
            // cria objeto da classe tempo1
            var hora = new Tempo1();

            hora.Hora = 7;
            hora.Minutos = 15;
            hora.Segundos = 30;

            WriteLine($"Hora modificada: {hora.FormatoHoraUniversal()}");
            WriteLine($"hora = {hora.ToString()}");

            Console.WriteLine("Hello World!");
        }
    }
}
