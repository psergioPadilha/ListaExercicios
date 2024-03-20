//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
//Considere sempre anos completos, e que um ano possui 365 dias.
//Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
//diasDeVida = idade * 365

namespace Exercicio14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            String nome;
            int idade;
            int diasDeVida;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA IDADE");
                Console.WriteLine("Digite 'S' para sair");
                Console.WriteLine("Digite 'C' para continuar");
                opcao = Console.ReadLine();

                //Valida emtradas do menu
                if ((opcao == "S") || (opcao == "s"))
                {
                    //Confirmação para sair do siatema
                    Console.WriteLine("Tem certeza que quer sair do Sitema?");
                    Console.WriteLine("Digite 'S' para confirmar e 'N' para continuar!");
                    opcao = Console.ReadLine();

                    if (opcao == "S" || opcao == "s")
                    {
                        break;
                    }
                }
                else if ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine("Opção invalida, por favor digite novamente...");
                    Console.ReadLine();
                    continue;
                }
                else if ((opcao == "C") || (opcao == "c"))
                {
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite a idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    diasDeVida = idade * 365;

                    Console.WriteLine(nome + ", VOCÊ JÁ VIVEU " + diasDeVida + " DIAS!");
                    Console.ReadLine();
                }
            }
        }
    }
}
