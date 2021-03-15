﻿using System;

namespace AulaDeClasse
{
  class Program
    {
        static void Main(string[] args)
        {
            // cria os objetos das classes Program
            Program programa = new Program();
            // cria objetos da classe Estudante
            Estudante aluno1 = new Estudante();
            // cria o objeto da classe Empregado
            Empregado func = new Empregado();

            /* atribuindo valores as propriedades
                da classe Estudante */
            aluno1.matricula = 123;        
            aluno1.nomeDoAluno = "Pedro Filho";
            
            // cabeçalho
            Console.WriteLine("Lista dos alunos:\n");

            // imprime os valores das propriedades da classe Estudante
            Console.WriteLine($"O aluno {aluno1.nomeDoAluno} tem a matricula número {aluno1.matricula}\n");
            
            // chama o método Display da classe Estudante
            // e atribui valores que será mostrado pelo mesmo
            aluno1.Display(321, "Cleonice Morais");
            aluno1.Display(789, "Tatiane Rainé");

            Console.WriteLine("Tem como funcionários:\n");
            // chama o método inserir dados da classe Empregado
            func.inserirDados(002, "Maria Batista", 500f);

            // cha o método mostrar dados da classe Empregado
            func.mostrarDados();

            // fim do programa
            Console.Write("Presione qualquer tecla para sair.");
            Console.ReadKey();

        } // fim main

    } // fim classe Program
    
} // fim nomespace
