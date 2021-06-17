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

            // cria variáveis
            float totalDoConsumo = 0;
            float mediaDeConsumo = 0;
            int totalDeQuilometrosRodados = 0;
            int totalDeAbastecimentos = 0;
            int quantidadeAbastecida = 1;
            int quilometrosRodados = 0;
            int abastecimentos = 0;

            // cabeçalho
            WriteLine("QUILOMETRAGEM DE COMBUSTÍVEL" );
            
            // cria o objeto da classe viagens
            Viagens minhaViagem = new Viagens( 150, 50 );
            // soma a quilometragem
            totalDeQuilometrosRodados += minhaViagem.QuilometragemDaViagem;
            // soma o abastecimento
            totalDeAbastecimentos += minhaViagem.QuantidadeDeCombustivel;
            // soma o consumo
            totalDoConsumo += minhaViagem.Consumo();
            // mostra a mensagem
            MostrarMensagem(minhaViagem);

            // entrada de dados
            Write("Informe a quilometragem rodada: ");
            // entrada do usuário
            quilometrosRodados = int.Parse(ReadLine());
            // propriedade da classe recebe a quilometragem rodada
            minhaViagem.QuilometragemDaViagem = quilometrosRodados;

            Write("Informe quantidade de combustível: " );
            abastecimentos = int.Parse(ReadLine());
            quantidadeAbastecida++;
            minhaViagem.QuantidadeDeCombustivel = abastecimentos;

            MostrarMensagem( minhaViagem );
            totalDeQuilometrosRodados += minhaViagem.QuilometragemDaViagem;
            totalDeAbastecimentos += minhaViagem.QuantidadeDeCombustivel;
            totalDoConsumo += minhaViagem.Consumo();
            mediaDeConsumo = totalDoConsumo / ( quantidadeAbastecida );

            // cabeçalho
            WriteLine("RESUMO DAS VIAGENS");

            // resumo das viagens
            WriteLine($"Total de quilômetros rodados {totalDeQuilometrosRodados} Km\n" +
                        $"Total de Abastecimentos {totalDeAbastecimentos} litros");

            WriteLine($"Total do consumo {totalDoConsumo:f} Km/l\n" +
                        $"Média do consumo é {mediaDeConsumo} Km/l");

        } // fim main

        // cria o método mostrar mensagens
        public static void MostrarMensagem(Viagens mostrarMensagem )
        {
            WriteLine($"Quilometragem rodada {mostrarMensagem.QuilometragemDaViagem}Km" +
                        $"\nLitros abastecidos {mostrarMensagem.QuantidadeDeCombustivel}L" +
                        $"\nConsumo {mostrarMensagem.Consumo():f} Km/l\n");               
        } // fim método

    } // fim classe
} // fim namespace
