//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

using System.ComponentModel.Design;

namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            String opcao;
            int valorUm = 0;
            int valorDois = 0;
            int valorTres = 0;

            while (true)
            {
                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA ANALISA E ORGANIZA NÚMEROS");
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

                for (int i = 1; i < 4; i++)
                {
                    String auxiliar;
                    Console.Write("Entre com o " + i + "º termo: ");
                    auxiliar = Console.ReadLine();
                    //Verifica se o valor de entrada é inteiro
                    while (!auxiliar.All(char.IsDigit))
                    {
                        Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                        Console.Write("Entre com o " + i + "º termo: ");
                        auxiliar = Console.ReadLine();
                    }
                    if (i == 1)
                    {
                        valorUm = Convert.ToInt32(auxiliar);
                    }
                    else if (i == 2)
                    {
                        valorDois = Convert.ToInt32(auxiliar);
                        if (valorDois == valorUm)
                        {
                            Console.WriteLine("O valor digitado deve ser diferente do 1º termo!");
                            i = 1;
                        }
                    }
                    else if (i == 3)
                    {
                        valorTres = Convert.ToInt32(auxiliar);
                        if (valorTres == valorUm)
                        {
                            Console.WriteLine("O valor digitado deve ser diferente do 1º termo!");
                            i = 2;
                        }
                        else if (valorTres == valorDois)
                        {
                            Console.WriteLine("O valor digitado deve ser diferente do 2º termo!");
                            i = 2;
                        }
                    }
                }

                if (valorUm > valorDois)
                {
                    if (valorDois > valorTres)
                    {
                        Console.WriteLine(valorUm + ";\n" + valorDois + ";\n" + valorTres + ".");
                    }
                    else if (valorTres > valorDois)
                    {
                        Console.WriteLine(valorUm + ";\n" + valorTres + ";\n" + valorDois + ".");
                    }
                }
                else if (valorDois > valorTres)
                {
                    if (valorTres > valorUm)
                    {
                        Console.WriteLine(valorDois + ";\n" + valorTres + ";\n" + valorUm + ".");
                    }
                    else if (valorUm > valorTres)
                    {
                        Console.WriteLine(valorDois + ";\n" + valorUm + ";\n" + valorTres + ".");
                    }
                }
                else if (valorTres > valorDois)
                {
                    if (valorDois > valorUm)
                    {
                        Console.WriteLine(valorTres + ";\n" + valorDois + ";\n" + valorUm + ".");
                    }
                    else if (valorUm > valorDois)
                    {
                        Console.WriteLine(valorTres + ";\n" + valorUm + ";\n" + valorDois + ".");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
