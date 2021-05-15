using System;
using static System.Console;

namespace ReferenciaParametroDeSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variáveis
            int y = 5;
            int z = 3;

            // mostra os valores de y e \
            WriteLine($"int y = {y}\nint z = {z}" );

            // passando y e z por referência
            QuadradoComRef( ref y );
            QuadradoComOut( out z );

            // mostra os valores de y e z após sere modificados
            // pelos métodos QuadradoComRef() e QuadradoComOut();
            Console.WriteLine($"Valor de y após QuadradoComRef() = {y}");
            Console.WriteLine($"Valor de z após QuadradoComRef() = {z}");

            // passando y e z por valor
            // após os métodos QuadradocomRef() e QuadradoComOut()
            Quadrado( y );
            Quadrado( z );

            // mostra os valores de y e z após apassagem por valor
            WriteLine($"\nValor de y após o método Quadrado() = {y}" );
            WriteLine($"Valor de z após o método Quadrado() = {z}" );

        } // fim de main

        // cria o método Quadrado por referência
        static void QuadradoComRef( ref int y )
        {
             y = y * y;
        } // fim método

        // cria o método Quadrado com out
        static void QuadradoComOut( out int z )
        {
            z = 6;
            z = z * z;
        } // fim método

        static void Quadrado( int a )
        {
                a = a * a;
        } // fim método
    } // fim classe
} // fim nome space
