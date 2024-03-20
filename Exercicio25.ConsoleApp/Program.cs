//Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.

//Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120

using System;

namespace Exercicio25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String opcao;
                String valor;
                int contador = 0;
                int fatorial = 0;

                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA FATORIAL");
                Console.WriteLine();
                Console.WriteLine("Para sair digite 'S';");
                Console.WriteLine("Para continuar digite 'C';");
                opcao = Console.ReadLine();

                //Verifica e valida menu
                while ((opcao != "C") && (opcao != "c") && (opcao != "S") && (opcao != "s"))
                {
                    Console.WriteLine("Opção inválida, por favor digite novamente...");
                    opcao = Console.ReadLine();
                }

                if ((opcao == "S") || (opcao == "s"))
                {
                    Console.WriteLine("Digite 'S' para confirmar e 'C' para cancelar!");
                    opcao = Console.ReadLine();

                    while ((opcao != "C") && (opcao != "c") && (opcao != "S") && (opcao != "s"))
                    {
                        Console.WriteLine("Opção inválida, por favor digite novamente...");
                        opcao = Console.ReadLine();
                    }
                    if ((opcao == "S") || (opcao == "s"))
                    {
                        break;
                    }
                }

                Console.Write("Digite o número: ");
                valor = Console.ReadLine();

                while (!valor.All(char.IsDigit))
                {
                    Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                    Console.Write("Digite o número: ");
                    valor = Console.ReadLine();
                }

                fatorial = Convert.ToInt32(valor);

                for (int i = fatorial - 1; i > 0; i--)
                {
                    fatorial = fatorial * i;
                }

                Console.WriteLine("O resultado de " + valor + " fatorial é " + fatorial + ".");

                Console.ReadLine();
            }
        }
    }
}
