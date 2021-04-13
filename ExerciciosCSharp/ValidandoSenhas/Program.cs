using System;

namespace ValidandoSenhas
{
    class Program
    {
        /*
            4.24 (Validando entrada de usuário) Modifique o programa na Figura 4.12 para 
            validar suas entradas. Para qualquer entrada, se o valor  entrado for diferente 
            de 1 ou 2, continue o loop até o usuário inserir um valor correto. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 115). Edição do Kindle. 
            Autor: Pedro Filho, 13/04/2021.
        */

        static void Main(string[] args)
        {
            // cria variável
            int senha = 0;
            // enquanto senha diferente de 123456 faça
            while( senha != 123456)
            {
                // imprima
                System.Console.WriteLine("Digite a senha correta: ");
                senha = int.Parse(Console.ReadLine());
                // se senha diferente de 123456
                if( senha != 123456 )
                {
                    // imprima
                    System.Console.WriteLine("Senha não confere!");
                } // fim if
            } // fim while

            Console.WriteLine("Senha correta.");
            Console.ReadKey();
            Console.Clear();
            
        } // fim main
    } // fim classe
} // fim namespace
