//Crie um programa para converter a temperatura de graus Celsius para graus Farenheit

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaFarenheit, temperaturaCelsius;
            Console.WriteLine("Programa Alterna Escalas de Temperatura");

            Console.WriteLine("Digite a temperatura na escala Celsius:");
            temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            temperaturaFarenheit = 9 / 5 * temperaturaCelsius + 32;

            Console.WriteLine("A temperatura " + temperaturaCelsius + "º C, " + 
                "Convertido para a escala Farenheit fica " + temperaturaFarenheit + "º F!");
        }
    }
}
