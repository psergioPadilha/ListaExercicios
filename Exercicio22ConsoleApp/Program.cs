//Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

namespace Exercicio22ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;

            Console.WriteLine("PROGRAMA GERADOR DE NÚMEROS IMPARES ENTRE '100' E '200'");

            for (i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 199)
                    {
                        n = n + 1;
                        Console.WriteLine("O " + n + "º número impar entre '100' e '200' é " + i + ".");
                    }
                    else
                    {
                        n = n + 1;
                        Console.WriteLine("O " + n + "º número impar entre '100' e '200' é " + i + ";");
                    }
                }
            }
        }
    }
}
