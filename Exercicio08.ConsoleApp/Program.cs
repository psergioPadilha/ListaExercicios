//Crie um programa para calcular o volume de uma lata de óleo

namespace Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raioLata, alturaLata, volumeLata;

            Console.WriteLine("PROGRAMA CALCULA VOLUME DA LATA DE ÓLEO");
            Console.WriteLine("Informe o raio da lata:");
            
            raioLata = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata:");
            alturaLata = double.Parse(Console.ReadLine());

            volumeLata = Math.PI * Math.Pow(raioLata, 2) * alturaLata;

            Console.WriteLine("O volume da lata é " + volumeLata + "!");
        }
    }
}
