//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
//Após o aumento, desconte 8% de impostos.
//Imprima o salário inicial, o salário com o aumento e o salário final

namespace Exercicio15ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase;
            double salarioComAumento;
            double valorDoDesconto;
            double salarioFinal;
            String opcao;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA SALÁRIO DO FUNCIONÁRIO");
                Console.WriteLine("Digite 'S' para sair do sistema;");
                Console.WriteLine("Digite 'C' para calcular o salário do funcionário;");
                opcao = Console.ReadLine();

                //Validação de menu
                if ((opcao == "S") || (opcao == "s"))
                {
                    //Confirmação para sair do sistema
                    Console.WriteLine("Tem certeza que quer sair do sistema?");
                    Console.WriteLine("'S' confirmar e 'N' continuar");
                    opcao = Console.ReadLine();

                    if ((opcao == "S") || (opcao == "s"))
                    {
                        break;
                    }
                }
                else if ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine("Opção inválida, por favor digite novamente...");
                    Console.ReadLine();
                    continue;
                }
                else if((opcao == "C") || (opcao == "c"))
                {
                    Console.Write("Digite o salário base: ");
                    salarioBase = Convert.ToDouble(Console.ReadLine());
                    salarioComAumento = salarioBase + (salarioBase * 0.15);
                    //ATENÇÃO! - o enunciado pedi para aumentar 15% e após descontar 8% em impostos, mas a fórmula diz que
                    //deve ser descontado 8% do salário
                    valorDoDesconto = salarioBase * 0.08;
                    salarioFinal = salarioComAumento - (valorDoDesconto);
                    Console.WriteLine("O salário inicial é R$ " + salarioBase.ToString("F") + ";");
                    Console.WriteLine("O salário com o aumento é R$ " + salarioComAumento.ToString("F") + ";");
                    Console.WriteLine("O salário final é R$ " + salarioFinal.ToString("F") + ";");
                    Console.ReadLine();
                }
            }
        }
    }
}
