//Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três
//e que se encontram no conjunto dos números de 1 até 500.

namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;


            Console.WriteLine("PROGRAMA GERADOR DE SOMADOR DE NÚMEROS ÍMPARES E MÚLTIPOS DE '3' ENTRE '1' E '500'");

            for (int i = 0; i < 501; i++)
            {
                if ((i % 2 != 0) && (i % 3 == 0))
                {
                    soma = i + soma;
                }
            }
            Console.WriteLine("Resultado da soma: " + soma);

        }
    }
}
