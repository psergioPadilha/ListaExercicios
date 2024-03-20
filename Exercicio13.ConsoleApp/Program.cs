//A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
//Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
//Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
//e quanto deve guardar numa conta de poupança (10% do total arrecadado).
//Você foi contratado para fazer os cálculos para o dono.
//Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.

//1º - ler a quantidade de pães vendidas;
//2º - ler a quantidade de broas vendidas;
//3º - calcular quanto faturou com a venda dos pães e broas;
//4º - apresentar o valor faturado e quanto deve ser depositado na poupança
//obs: pão custa R$0,12 e a broa R$1,50, o valor a ser depositado é de 10% do faturamento

namespace Exercicio13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            double valorTotalEmPao, valorTotalEmBroa, totalDoFaturamento, valorDoDeposito;
            int quantidadeDePaes, quantidadeDeBroas;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA FATURAMENTO DA PADARIA");
                Console.WriteLine("Digite 'S' para sair");
                Console.WriteLine("Digite 'C' para continuar");
                opcao = Console.ReadLine();

                //Valida emtradas do menu
                if ((opcao == "S") || (opcao == "s"))
                {
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
                else if((opcao == "C") || (opcao == "c"))
                {
                    //Entradas de dados
                    Console.Write("Quantidade de 'PÃES' vendidos: ");
                    quantidadeDePaes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Quantidade de 'BROAS' vendidas: ");
                    quantidadeDeBroas = Convert.ToInt32(Console.ReadLine());

                    //Processamento
                    valorTotalEmPao = quantidadeDePaes * 0.12;
                    valorTotalEmBroa = quantidadeDeBroas * 1.50;
                    totalDoFaturamento = valorTotalEmPao + valorTotalEmBroa;
                    valorDoDeposito = totalDoFaturamento * 10 / 100;

                    //Saída de dados
                    Console.WriteLine();
                    Console.WriteLine("O total faturado em 'PÃO', foi: R$ " + valorTotalEmPao.ToString("F") + ";");
                    Console.WriteLine("O total faturado em 'BROA', foi: R$ " + valorTotalEmBroa.ToString("F") + ";");
                    Console.WriteLine("O faturamento total foi: R$ " + totalDoFaturamento.ToString("F") + ";");
                    Console.WriteLine("O valor a ser depositado é : R$ " + valorDoDeposito.ToString("F") + ";");
                    Console.ReadLine();
                }
            }
        }
    }
}
