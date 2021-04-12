using System;

namespace QuilometragemCombustivel
{
    class Program
    {
        /*
            4.17 (Quilometragem de combustível) Os motoristas se preocupam com a quilometragem 
            obtida por seus automóveis. Um motorista monitorou várias viagens registrando 
            a quilometragem dirigida e a quantidade de combustível em litros utilizados para cada 
            tanque cheio.  Desenvolva um aplicativo Java que receba como entrada os quilômetros 
            dirigidos e os litros de gasolina consumidos (ambos como inteiros)  para cada viagem. 
            O programa deve calcular e exibir o consumo em quilômetros/litro para cada viagem e 
            imprimir a quilometragem  total e a soma total de litros de combustível consumidos 
            até esse ponto para todas as viagens. Todos os cálculos de média devem produzir  
            resultados de ponto flutuante. Utilize classe Scanner e repetição controlada por 
            sentinela para obter os dados do usuário. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 114). Edição do Kindle. 
            Autor: Pedro Filho, 11/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int quilometrosDirigido = 0;
            int totalDirigido = 0;
            int quantidadeDeCombustivel = 0;
            int totalDeCombustivel = 0;
            int consumo = 0;
            int totalConsumido = 0;
            float mediaDeConsumo = 0;
            int continuaViagem = 1;

            // enquanto a viagem continuar faça -1 encerra a viagem
            while( continuaViagem != -1 )
            {                
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("ENTRADA DE DADOS DA VIAGEM");
                Console.ResetColor();

                // entrada de dados
                Console.Write("Quantos Km você dirigiu? ");
                // aguarda entrada do usuário
                quilometrosDirigido = int.Parse(Console.ReadLine());
                // soma a quilometragem
                totalDirigido += quilometrosDirigido;

                // entrada de combustível
                Console.Write("Quantos litros de combustível: ");
                // aguarda entrada do usuário
                quantidadeDeCombustivel = int.Parse(Console.ReadLine());
                // soma o combustível abastecido
                totalDeCombustivel += quantidadeDeCombustivel;

                // cálculos
                consumo = totalDirigido / totalDeCombustivel;
                // armazena o total do consumo de cumbustível
                totalConsumido += consumo;

                // pula linha
                System.Console.WriteLine();

                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("RELATÓRIO DA VIAGEM");
                Console.ResetColor();
            
                // mostrar resultado
                System.Console.WriteLine($"Distância percorrida {quilometrosDirigido} Km ");
                System.Console.WriteLine($"Total de combustível abastecidos {quantidadeDeCombustivel}");
                System.Console.WriteLine($"Total do consumo de combustivel {consumo:f2} Km/litros"); 
                
                // pergunta se quer continuar a viagem
                Console.Write("Deseja continuar a viagem [ 1-Sim / -1-Não ] ");
                // aguarda a entrada do usuário
                continuaViagem = int.Parse(Console.ReadLine());

                Console.Clear(); // limpa a tela
                
            } // fim while

            

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("RELATÓRIO DA VIAGEM");
            Console.ResetColor();
            
            // mostrar resultado
            System.Console.WriteLine($"Distância percorrida {totalDirigido} Km ");
            System.Console.WriteLine($"Total de combustível abastecidos {totalDeCombustivel}");
            System.Console.WriteLine($"Total do consumo de combustivel {totalConsumido:f2} Km/litros");
            System.Console.WriteLine($"Média do consumo: {mediaDeConsumo}");    
           
            // final do programa
            Console.WriteLine("Pressione qualquer tecla para terminar.");
            Console.ReadKey();
            Console.Clear();
        } // fim main
    } // fim classe
} // fim namespace
