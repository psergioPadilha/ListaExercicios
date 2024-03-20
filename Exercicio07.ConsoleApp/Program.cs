//Crie um programa para calcular o salário total de um vendedor
//Deverá ser informado o salário base e o total de vendas. A comissão é calculada com um percentual
//(informado pelo usuário) sobre o total de vendas.


namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase, totalVendas, salarioTotal, percentual;

            Console.WriteLine("Programa calcula salário");

            Console.WriteLine("Digite o salário base:");
            salarioBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas:");
            totalVendas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissionamento:");
            percentual = Convert.ToInt32(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * percentual / 100);

            Console.WriteLine("O salário total é: " +  salarioTotal);
        }
    }
}
