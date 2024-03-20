//Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.
//Mostre a tabuada na forma: 
//0 x N = 0,
//1 x N = 1N,
//2 x N = 2N,
//.
//.
//.  
//10 x N = 10N.

namespace Exercicio24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            String auxiliar;
            int numero;

            while (true)
            {
                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA TABUADA");
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

                Console.Write("Digite o número para gerar a tabuada: ");
                auxiliar = Console.ReadLine();

                while (!auxiliar.All(char.IsDigit))
                {
                    Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                    Console.Write("Digite o número para gerar a tabuada: ");
                    auxiliar = Console.ReadLine();
                }

                numero = Convert.ToInt32(auxiliar);

                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(i + " x " + numero + " = " + i * numero);
                }

                Console.ReadLine();
            }
        }
    }
}
