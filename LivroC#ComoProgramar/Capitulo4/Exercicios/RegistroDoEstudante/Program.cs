using System;
using static System.Console;

namespace RegistroDoEstudante
{
    class Program
    {
        /*
            4.10 (Classe de registro do aluno) Crie uma classe chamada Aluno que um instituto 
            possa usar para representar um registro para os alunos que se qualificam no instituto. 
            Um registro do aluno deve incluir cinco informações como variáveis ​​de instância ou 
            propriedades implementadas automaticamente: o id do aluno (tipo string), 
            o nome do aluno (tipo string) e três variáveis ​​separadas para pontuações em três disciplinas 
            (tipo decimal). Sua classe deve ter um construtor que inicializa os cinco valores. 
            Fornece uma propriedade com um acessador get e set para quaisquer variáveis ​​de instância. 
            Para as pontuações em assuntos, se o valor passado para o acessador definido for negativo, 
            o valor da variável de instância deve ser deixado inalterado. Além disso, forneça métodos 
            chamados GetAggregate e GetPercentage que calculam as marcas agregadas nos três assuntos 
            (soma de três marcas de assunto) e a porcentagem (ou seja, soma dividida pelas notas máximas, 
            50 e, em seguida, multiplicada por 100), e então retorna agregado e porcentagem como valor decimal. 
            Escreva um aplicativo de teste chamado StudentRecordTest que demonstra os recursos do aluno da classe
            Autor: Pedro Filho, 24/07/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            Console.WriteLine("Hello World!");
        }
    }
}
