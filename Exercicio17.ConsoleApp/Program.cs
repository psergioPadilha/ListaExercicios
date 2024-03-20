//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

namespace Exercicio17.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de varáveis
            double a, b, c, ab;
            String opcao;

            while (true)
            {
                //Comando para limpar a tela e menu
                Console.Clear();
                Console.WriteLine("PROGRAMA VERIFICA VALORES");
                Console.WriteLine("Para continuar digite 'C;");
                Console.WriteLine("Para sair digite 'S';");

                //Entrada de dados
                opcao = Console.ReadLine();

                //Verificação e validação de menu
                if ((opcao == "S") || (opcao == "s"))
                {
                    Console.WriteLine("Para confirmar a saida do sistema pressione 'S'!");
                    opcao = Console.ReadLine();

                    if ((opcao == "S") || (opcao == "s"))
                    {
                        break;
                    }
                }
                else if ((opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine("Opção inválida, por favor digite novamente...");
                    Console.ReadLine();
                    continue;
                }
                else if ((opcao == "C") || (opcao == "c"))
                {
                    //Entrada de dados
                    Console.Write("Digite o valor de 'A': ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o valor de 'B': ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o valor de 'C': ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    //Saída de informações
                    Console.WriteLine("A = " + a.ToString("F") + ";");
                    Console.WriteLine("B = " + b.ToString("F") + ";");
                    Console.WriteLine("C = " + c.ToString("F") + ";");

                    //Soma de variáveis
                    ab = a + b;

                    //Saída do resultado da soma
                    Console.WriteLine("A + B = " + ab.ToString("F") + ".");
                    Console.WriteLine();

                    //Saídas e verificação do resultado
                    if (ab < c)
                    {
                        Console.WriteLine("O resultado da adição de 'A' " + a.ToString("F") + " e 'B' " + b.ToString("F") +
                            " é " + ab.ToString("F") + " , portanto 'MENOR' que 'C' " + c.ToString("F") +".");
                    }
                    else if (ab > c)
                    {
                        Console.WriteLine("O resultado da adição de 'A' " + a.ToString("F") + " e 'B' " + b.ToString("F") +
                            " é " + ab.ToString("F") + " , portanto 'MAIOR' que 'C' " + c.ToString("F") + ".");
                    }
                    else
                    {
                        Console.WriteLine("O resultado da adição de 'A' " + a.ToString("F") + " e 'B' " + b.ToString("F") +
                            " é " + ab.ToString("F") + " , portanto 'IGUAL' a 'C' " + c.ToString("F") + ".");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
