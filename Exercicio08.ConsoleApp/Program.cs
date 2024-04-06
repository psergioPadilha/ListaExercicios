//Crie um programa para calcular o volume de uma lata de óleo

namespace Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double raioLata = 0;
                double alturaLata = 0;
                double volumeLata = 0;

                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DA LATA DE ÓLEO");
                Console.WriteLine();

                EntradaDeDados(ref raioLata, ref alturaLata);

                volumeLata = CalcularVolume(ref raioLata, ref alturaLata);

                ImprimirVolume(volumeLata);

                Console.ReadLine();
            }
        }

        #region Entraada de dados
        static void EntradaDeDados(ref double raioLata, ref double alturaLata)
        {
            Console.Write("Informe o raio da lata: ");
            raioLata = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da lata:");
            alturaLata = double.Parse(Console.ReadLine());
        }
        #endregion

        #region Calcular volume
        static double CalcularVolume(ref double raio, ref double altura)
        {
            double volumeLata = Math.PI * Math.Pow(raio, 2) * altura;
            return volumeLata;
        }
        #endregion

        #region Imprimi volume
        static void ImprimirVolume(double volume)
        {
            Console.Write("O volume da lata é " + volume.ToString("F") + " cm³.");
        }
        #endregion
    }
}
