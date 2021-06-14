using System;
using static System.Console;


namespace QuilometragemDeCombustiveis
{
    class Program
    {
        /*
            4.17 (Quilometragem de combustível) Os motoristas se preocupam com a quilometragem 
            obtida por seus automóveis. Um motorista monitorou várias viagens registrando 
            a quilometragem dirigida e a quantidade de combustível em litros utilizados para 
            cada tanque cheio.  Desenvolva um aplicativo Java que receba como entrada os quilômetros 
            dirigidos e os litros de gasolina consumidos (ambos como inteiros)  para cada viagem. 
            O programa deve calcular e exibir o consumo em quilômetros/litro para cada viagem e imprimir 
            a quilometragem  total e a soma total de litros de combustível consumidos até esse ponto para 
            todas as viagens. Todos os cálculos de média devem produzir  resultados de ponto flutuante. 
            Utilize classe Scanner e repetição controlada por sentinela para obter os dados do usuário. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 114). Edição do Kindle.
            Autor: Pedro Filho, 11/06/2021 
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("QUILOMETRAGEM DE COMBUSTÍVEL" );

            // cria o objeto da classe viagens
            Viagens minhaViagem = new Viagens( 150, 50 );
            MostrarMensagem(minhaViagem);

            Viagens minhaViagem1 = new Viagens( 200, 55 );
            MostrarMensagem( minhaViagem1 );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método mostrar mensagens
        public static void MostrarMensagem(Viagens mostrarMensagem )
        {
            WriteLine($"Quilometragem rodada {mostrarMensagem.QuilometragemDaViagem}Km" +
                        $"\nLitros abastecidos {mostrarMensagem.QuantidadeDeCombustivel}L" +
                        $"\nConsumo {mostrarMensagem.Consumo():f}\n");
        } // fim método

    } // fim classe
} // fim namespace
