//Escreva um programa que imprima os números de 1 a 100 em ordem crescente,
//substituindo os números múltiplos de 3 pela palavra "Fizz"
//e os múltiplos de 5 pela palavra "Buzz".
//Para números que são múltiplos de ambos, use "FizzBuzz".

using System;

namespace Exercicio27.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contFizzBuzz = 0;
            int contFizz = 0;
            int contBuzz = 0;
            int cont = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    contFizzBuzz ++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    contFizz ++;
                }
                else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                    contBuzz ++;
                }
                else
                {
                    Console.WriteLine(i);
                    cont ++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("De '0' a '100' temos:");
            Console.WriteLine();
            Console.WriteLine(contFizzBuzz + " números são multiplos de 3 e multiplos de 5 simultaneamente!");
            Console.WriteLine(contFizz + " números são multiplos de 3!");
            Console.WriteLine(contBuzz + " números são multiplos de 5!");
            Console.WriteLine(cont + " não são multiplos nem de 3, nem de 5 e nem simultaneamente!");
            Console.ReadLine();
        }
    }
}
