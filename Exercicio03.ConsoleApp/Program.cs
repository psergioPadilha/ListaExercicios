//Crie um programa para calcular o volume de um Cilindro
//V = PI * raio² x altura


using System.ComponentModel.Design;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double raio = 0;
                double altura = 0;

                string opcao = Menu();

                AnalizaOpcaoDeMenu(opcao);
                
                LerDadosDeEntrada(ref raio, ref altura);

                double volume = CalculaVolumeCilindrico(raio, altura);

                ApresentaVolume(volume);

            }

            #region Menu
            static string Menu() {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DO CILINDRO");
                Console.WriteLine();
                Console.WriteLine("Digite 'S' para sair e 'C' para continuar!");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();
                return opcao;
            }
            #endregion

            #region Analiza opção do menu
            static void AnalizaOpcaoDeMenu(string opcao)
            {
                while( (opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida...");
                    Console.Write("Opção: ");
                    opcao = Console.ReadLine();
                }
                if ((opcao == "S") || (opcao == "s"))
                {
                    if (ConfirmaSaida())
                        Environment.Exit(0);
                }
            }
            #endregion

            #region Confirmação para sair do sistema
            static bool ConfirmaSaida()
            {
                Console.WriteLine();
                Console.WriteLine("Deseja mesmo encerrar o sistema?");
                Console.WriteLine("Digite 'S' para sair e 'C' para continuar!");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                while ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida...");
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

            #region Ler dados de entrada
            static void LerDadosDeEntrada(ref double raio, ref double altura)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DO CILINDRO");
                Console.WriteLine();
                Console.Write("Raio do cilindro: ");
                raio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura do cilindro: ");
                altura = Convert.ToDouble(Console.ReadLine());
            }
            #endregion

            #region Calcula Volume do cilindro
            static double CalculaVolumeCilindrico(double r, double a)
            {
                return Math.PI * Math.Pow(r, 2) * a;
            }
            #endregion

            #region Apresenta calculo do volume
            static void ApresentaVolume(double volume)
            {
                Console.WriteLine("O volume do cilindro é " + volume.ToString("N4"));

                Console.ReadLine();
            }
            #endregion
        }
    }
}
