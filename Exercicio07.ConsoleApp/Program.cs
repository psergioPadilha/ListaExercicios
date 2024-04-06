//Crie um programa para calcular o salário total de um vendedor
//Deverá ser informado o salário base e o total de vendas. A comissão é calculada com um percentual
//(informado pelo usuário) sobre o total de vendas.
//Saláriototal = saláriobase + (totaldevendas * (comissão/100))


namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double salarioBase = 0;
                double totalDeVendas = 0;
                double salarioTotal = 0;
                int comissao = 0;

                LerEntradasDoUsuario(ref salarioBase, ref totalDeVendas, ref comissao);

                salarioTotal = CalcularSalarioTotal(salarioBase, totalDeVendas, comissao);

                ImprimirSalarioTotal(salarioTotal);

                Console.ReadLine();
            }
        }

        #region Informações de entrada
        static void LerEntradasDoUsuario(ref double salarioBase, ref double totalDeVendas, ref int comissao)
        {
            Console.Write("Salário base: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Total de vendas: ");
            totalDeVendas = double.Parse(Console.ReadLine());

            Console.Write("Percentual de comissionamento: ");
            comissao = int.Parse(Console.ReadLine());
        }
        #endregion

        #region Calcula o salário final
        static double CalcularSalarioTotal(double salarioBase, double totalDeVendas, int comissao)
        {
            double salrioTotal = salarioBase + (totalDeVendas * comissao / 100);
            return salrioTotal;
        }
        #endregion

        #region Imprime o salário final
        static void ImprimirSalarioTotal(double salarioTotal)
        {
            Console.WriteLine("O salário final é R$" +  salarioTotal + ".");
        }
        #endregion
    }
}
