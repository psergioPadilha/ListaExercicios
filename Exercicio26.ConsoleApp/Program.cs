namespace Exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String opcao;

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

                Console.ReadLine();
            }
        }
    }
}
