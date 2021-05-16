using System;
using static System.Console;

namespace PassandoVetorParaMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            // cria um vetor original e atribui valores
            int[] vetorOriginal = { 1, 2, 3, 4, 5, 6 };

            // cabeçalho
            WriteLine("PASSAGEM DE VETOR E ELEMENTO POR REFERÊNCIA PARA MÉTODO" );
            
            // imprime
            Console.WriteLine("Efeitos da passagem de um vetor por referência.");
            WriteLine("O valor do vetor original é: " );
    
            // loop para mostrar os valores do vetor original
            foreach( var mostraValor in vetorOriginal )
            {
                // mostra os valores
                Write($" {mostraValor}" );
            } // fim foreach

            // chama o método modificar vetor e passa o vetor original
            ModificarVetor( vetorOriginal );

            // mostra os valores do vetor modificado
            WriteLine("\nMostra os valores do vetor após a modificação." );

            // loop para mostrar os valores modificado no vetor
            foreach( var valoresModificados in vetorOriginal )
            {
                // imprime os valores modificados
                Write( $" {valoresModificados}" );
            } // fim foreach

            // imprime
            WriteLine("\nEfeitos da passagem de um elemento do vetor." +
                    $"\nO elemento da posição vetorOriginal[3] \nantes da modificação é: {vetorOriginal[3]}" );
 
            // chama o método modificar elemento e atribui o vetorOriginal[3]
            ModificarElementos( vetorOriginal[3] );

        } // fim main

        // cria método modificar vetor
        static void ModificarVetor( int[] vetor1 )
        {
            // loop para modificar os valores do vetor original
            for( int i = 0; i < vetor1.Length; i++ )
            {
                // multiplica os valores do vator na posição i po 2
                vetor1[ i ] *= 2; 
            } // fim for
        } // fim método

        // cria o método modificar elemento
        static void ModificarElementos( int elemento )
        {
            // o elemento e multiplicado por 3
            elemento *= 3;

            // imprime o elemento modificado
            WriteLine($"O elemento da posição vetorOriginal[3] agora vale: {elemento}" );
        } // fim método

    } // fim classe
} // fim namespace
