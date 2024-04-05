//Crie um programa para calcular o volume de uma esfera
//V = 4 / 3 * PI * raio³

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = Menu();

                if(VerificaOpcaoDeMenu(opcao))
                    Environment.Exit(0);

                double raio = LerRaio();

                double volume = CalculaVolumeDaEsfera(raio);

                ApresentaVolumeDaEsfera(volume);
            }
        }

        #region Menu
        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA CALCULA VOLUME DE ESFERA");
            Console.WriteLine();
            Console.WriteLine("Digite 'S' para sair e 'C' para continuar!");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            return opcao;
        }
        #endregion

        #region Verifica opção de menu
        static bool VerificaOpcaoDeMenu(string opcao)
        {
            while( (opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c") )
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida digite novamente!");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
            }
            if ( (opcao == "S") || (opcao == "s") )
            {
                if(ConfirmaSairDoSistema())
                    return true;
                else return false;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Confirmação para sair do sistema
        static bool ConfirmaSairDoSistema()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja mesmo sair do sistema?");
            Console.WriteLine("Digite 'S' para sair e 'C' para continuar!");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            while ( (opcao != "S") && ( opcao != "s") && (opcao != "C") && (opcao != "c"))
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida...");
                Console.WriteLine();
                Console.WriteLine("Digite 'S' para sair e 'C' para continuar!");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
            }
            if ( (opcao == "S") || (opcao == "s") )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Ler raio
        static double LerRaio()
        {
            Console.WriteLine();
            Console.Write("Raio: ");
            string valor = Console.ReadLine();
            double raio = VerificaEntrada(valor);
            return raio;
        }
        #endregion

        static double VerificaEntrada(string valor)
        {
            while (!double.TryParse(valor, out var r))
            {
                Console.WriteLine("Valor inválido por favor digite novamente!");
                Console.Write("Raio: ");
                valor = Console.ReadLine();
            }
            return double.Parse(valor);
        }

        #region Calculo do volume da esfera
        static double CalculaVolumeDaEsfera(double r)
        {
            return 4 /3 * Math.PI * Math.Pow(r,3);
        }
        #endregion

        #region
        static void ApresentaVolumeDaEsfera(double volume)
        {
            Console.WriteLine();
            Console.WriteLine("O volume da esfera é " + volume.ToString("F"));
            Console.ReadLine();
        }
        #endregion
    }
}
