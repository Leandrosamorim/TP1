using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; 
            int y = 0;
            try
            {
            Console.WriteLine("Insira o primeiro numero: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o primeiro numero: ");
            y = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
            Console.WriteLine("Formato inválido. Use somente numeros inteiros.");
            return;
            }
            int resultado = x + y;
            Console.WriteLine("O resultado da adição dos números é {0} ", resultado);
        }
    }    
}
