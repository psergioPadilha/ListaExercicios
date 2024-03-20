//A imobiliária Imóbilis vende apenas terrenos retangulares.
//Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

namespace Exercicio12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            double largura, comprimento, area;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA ÁREA DE TERRENO RETANGULAR");
                Console.WriteLine();
                Console.WriteLine("Digite 'C' para calcular");
                Console.WriteLine("Digite 'S' para sair do sistema");
                opcao = Console.ReadLine();

                if ((opcao == "S") || (opcao == "s"))
                {
                    break;
                }
                else if ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine("Opção inválida, por favor tecle 'ENTER' e digite novamente...");
                    Console.ReadLine();
                    continue;
                }
                else if ((opcao == "C") || (opcao == "c"))
                {
                    Console.Write("Largura do terreno: ");
                    largura = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Comprimento do terreno: ");
                    comprimento = Convert.ToDouble(Console.ReadLine());
                    
                    area = largura * comprimento;

                    Console.WriteLine("A área total do terreno é " + area);
                    Console.ReadLine();
                }
            }
        }
    }
}
