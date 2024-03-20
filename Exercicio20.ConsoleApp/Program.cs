//Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

namespace Exercicio20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao = null;
            int numero;
            String auxiliar = null;

            while (true)
            {
                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA VERIFICADOR DE NÚMERO PAR OU IMPAR");
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

                Console.Write("Número: ");
                auxiliar = Console.ReadLine();
                while (!auxiliar.All(char.IsDigit))
                {
                    Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                    Console.Write("Número: ");
                    auxiliar = Console.ReadLine();
                }

                numero = Convert.ToInt32(auxiliar);

                if ((numero % 2 == 0) || (numero == 0))
                {
                    Console.WriteLine("O número " + numero + " é par!");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " é impar!");
                }

                Console.ReadLine();
            }
        }
    }
}
