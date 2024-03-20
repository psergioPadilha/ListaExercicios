//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
//média ponderada = ((peso1 * nota1) + (peso2 * nota2)) / peso1 + peso2 

namespace Exercicio10ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;
            double mediaPonderada;
            double peso1, peso2;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA MÉDIA PONDERADA");
                Console.WriteLine();
                Console.WriteLine("Digite 'C' para 'CALCULAR':");
                Console.WriteLine("Digite 'S' para 'SAIR':");
                String opcao = Console.ReadLine();
                Console.WriteLine();

                if ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine("Opação inválida, por favor digite novamente!");
                    Console.ReadLine();
                    continue;
                }
                else if ((opcao == "S") || (opcao == "s"))
                {
                    break;
                }
                else if ((opcao == "C") || (opcao == "c"))
                {

                    Console.Write("Digite o valor da prova 1: ");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do peso 1: ");
                    peso1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o valor da prova 2: ");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do peso 2: ");
                    peso2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    mediaPonderada = (((peso1 * nota1) + (peso2 * nota2)) / peso1 + peso2);
                    Console.WriteLine("A média ponderada é = " + mediaPonderada);
                    Console.ReadLine();
                }
            }
        }
    }
}
