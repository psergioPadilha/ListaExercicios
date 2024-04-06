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
                //Apresenta opções de continuar ou de sair do sistema
                string opcao = Menu();

                //Verifica se o usuário entrou com as opções corretas
                ValidaOpcaoMenu(opcao);

                //Capta os valores referentes as provas e seus pesos respectivos
                EntrarComValorDasNotas(out nota1, out nota2, out peso1, out peso2);

                //Calcula o valor da média e atribui a variável correspondente
                mediaPonderada = CalcularMedia(nota1, nota2, peso1, peso2);

                //Apresenta o resultado
                ApresentaMedia(mediaPonderada);

                Console.ReadLine();
            }
        }

        #region Apresenta o resultado da média das provas
        private static void ApresentaMedia(double mediaPonderada)
        {
            Console.WriteLine("A média ponderada é = " + mediaPonderada);
        }
        #endregion

        #region Calcula a média das provas
        private static double CalcularMedia(double nota1, double nota2, double peso1, double peso2)
        {
            return (((peso1 * nota1) + (peso2 * nota2)) / peso1 + peso2);
        }
        #endregion

        #region Entrada dos valores das notas e pesos
        private static void EntrarComValorDasNotas(out double nota1, out double nota2, out double peso1, out double peso2)
        {
            Console.Write("Digite o valor da prova 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do peso 1: ");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da prova 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do peso 2: ");
            peso2 = Convert.ToDouble(Console.ReadLine());
        }
        #endregion

        #region Menu
        private static string Menu()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA CALCULA MÉDIA PONDERADA");
            Console.WriteLine();
            Console.WriteLine("Digite 'C' para 'CALCULAR' e 'S' para 'SAIR'!");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();
            return opcao;
        }
        #endregion

        #region Validar opção do menu
        static void ValidaOpcaoMenu(string opcao)
        {
            if ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
            {
                Console.WriteLine("Opação inválida, por favor digite novamente!");
                Console.ReadLine();
            }
            else if ((opcao == "S") || (opcao == "s"))
            {
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
