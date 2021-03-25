using System;
/*
 2.16 (Comparando inteiros) Escreva um aplicativo que solicite ao usuário inserir 
    dois inteiros, obtenha dele esses números e exiba o número  maior seguido pelas 
    palavras “is larger". Se os números forem iguais, imprima a mensagem “These 
    numbers are equal". Utilize  as técnicas mostradas na Figura 2.15. 
    Deitel, Paul; Deitel, Harvey. Java: como programar (p. 52). Edição do Kindle. * 
    
 */
namespace ComparandoInteiros2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int num1, num2;

            // cabeçalho
            Console.ForegroundColor = ConsoleColor.White; // letras brancas
            Console.BackgroundColor = ConsoleColor.DarkBlue; // fundo azul
            Console.WriteLine("COMPARANDO NÚMEROS INTEIROS");
            Console.ResetColor(); 

            // entrada de dados
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);

            // cabeçalho resultado
            Console.ForegroundColor = ConsoleColor.Green; // letras brancas
            Console.BackgroundColor = ConsoleColor.Yellow; // fundo azul
            Console.WriteLine("COMPARANDO NÚMEROS INTEIROS");
            Console.ResetColor();

            // condições de verificação
            if ( num1 > num2)
            {
                Console.WriteLine($"[{num1, -5}] é maior que [{num2, 5}]");
            }
            if(num1 < num2)
            {
                Console.WriteLine($"{num1} é menor que {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} é igual a {num2}");
            }
            
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
