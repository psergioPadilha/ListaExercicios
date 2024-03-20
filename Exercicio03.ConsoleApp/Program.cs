//Crie um programa para calcular o volume de um Cilindro
//V = PI * raio² x altura


namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DO CILINDRO");

                Console.Write("Raio do cilindro: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura do cilindro: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double volume = calculaVolumeCilindrico(raio, altura);

                Console.WriteLine("O volume do cilindro é " + volume);

                Console.ReadLine();
            }

            static double calculaVolumeCilindrico(double r, double a)
            {
                return Math.PI * Math.Pow(r, 2) * a;
            }
        }
    }
}
