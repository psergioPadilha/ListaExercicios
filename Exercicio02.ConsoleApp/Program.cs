//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CONVERTE ESCALA DE GRAUS FAHRENHEIT PARA GRAUS CELSIUS");

                Console.Write("Digite o valor na escala fahrenheit: ");
                decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());

                decimal celsius = conversorEscalaFahrenheitParaCelsius(fahrenheit);

                Console.WriteLine("\n" + fahrenheit + "º convertidos para celsius equivala a " + celsius + "º.");

                Console.ReadLine();
            }

            static decimal conversorEscalaFahrenheitParaCelsius(decimal fahrenheit)
            {
                decimal n = (fahrenheit - 32) * 5 / 9;
                return n;
            }
        }
    }
}
