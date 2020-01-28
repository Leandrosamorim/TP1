using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracao das variaveis que guardarão os valores
            int x = 0; 
            int y = 0;

            //armazenamento do input do usuario, com conversao explicita
            try
            {
            Console.WriteLine("Insira o primeiro numero: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o primeiro numero: ");
            y = Convert.ToInt32(Console.ReadLine());
            }

            //tratamento de exceção, caso seja inserido valor não numérico
            catch(FormatException)
            {
            Console.WriteLine("Formato inválido. Use somente numeros inteiros.");
            return;
            }

            //soma dos valores e exibição do resultado
            int resultado = x + y;
            Console.WriteLine("O resultado da adição dos números é {0} ", resultado);
        }
    }    
}
