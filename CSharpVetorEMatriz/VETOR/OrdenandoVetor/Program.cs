using System;
using static System.Console;

namespace OrdenandoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um vetor
            int[] vetor = {5, 3, 4, 9, 10, 25, 0, 1, 6, 8, 7, 2 };

            // mostrar
            WriteLine("MOSTRA O VETOR ORIGINAL" );

            // chama o método mostrar vetor
            MostrarVetor( vetor );

            Console.WriteLine("MOSTRA O VETOR ORGANIZADO");
            
            // chama o método organizar vetor
            OrganizarVetor( vetor );

            // chama o método mostrar vetor
            MostrarVetor( vetor );

        } // fim main

        // cria o método mostrar vetor
        static void MostrarVetor( int[] vet )
        {            
            // mostra vetor
            Write("int vetor = {" );

            // loop para mostra os elementos do vetor
            foreach( var numero in vet )
            {
                // mostra os elementos
                Write($" {numero}" );
            } // fim foreach

            Write(" };\n\n" ); // fim vetor
        } // fim método mostrar vetor

        // cria o método Organizar vetor
        static void OrganizarVetor( int[] vet )
        {
            // loop para a passagem dos elementos
            for( int passagem = 1; passagem < vet.Length; passagem++ )
            {
                for( int organizar = 0; organizar < vet.Length - 1; organizar++ )
                {
                    if( vet[ organizar ] > vet[ organizar + 1 ] )
                    {
                        Trocar( vet, organizar );
                    } // fim if

                } // fim for interno
            } // fim for externo
        } // fim método organizer vetor

        // cria o método trocar
        static void Trocar( int[] vet, int size )
        {
            // cria a variável
            int auxiliar;

            auxiliar = vet[ size ];
            vet[ size ] = vet[ size + 1 ];
            vet[ size + 1 ] = auxiliar;

        } // fim método trocar
    } // fim classe
} // fim namespace
