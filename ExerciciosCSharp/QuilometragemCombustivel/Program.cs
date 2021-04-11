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
            int quantidadeDeCombustivel = 0;
            int consumo = 0;
            float mediaDeConsumo = 0;
            int continuaViagem = 1;

            // enquanto a viagem continuar faça -1 encerra a viagem
            while( continuaViagem != -1 )
            {
                // entrada de dados
                Console.Write("Quantos Km você dirigiu? ");
                quilometrosDirigido = int.Parse(Console.ReadLine());
                Console.Write("Quantos litros de combustível: ");
                quantidadeDeCombustivel = int.Parse(Console.ReadLine());

                // cálculos
                consumo = quilometrosDirigido / quantidadeDeCombustivel;
                
            }




            Console.WriteLine("Hello World!");
        }
    }
}
