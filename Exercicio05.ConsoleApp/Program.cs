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
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DE ESFERA");
                Console.WriteLine();

                Console.Write("Raio: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                double volume = calculaVolumeDaEsfera(raio);

                Console.WriteLine("O volume da esfera é " + volume.ToString("F"));

                Console.ReadLine();
            }
        }

        static double calculaVolumeDaEsfera(double r)
        {
            return 4 /3 * Math.PI * Math.Pow(r,3);
        }
    }
}
