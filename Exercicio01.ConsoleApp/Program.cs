//Crie um programa para calcular o volume de uma caixa retangular
//Volume = comprimento*largura*altura

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("PROGRAMA CALCULA VOLUME DA CAIXA");
                Console.ReadLine();

                Console.WriteLine("Digite o comprimento da caixa!");
                int comprimento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Comprimento = " + comprimento);
                Console.ReadLine();

                Console.WriteLine("Digite a largura da caixa!");
                int largura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Largura = " + largura);
                Console.ReadLine();

                Console.WriteLine("Digite a altura da caixa!");
                int altura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Altura = " + altura);
                Console.ReadLine();

                int volume = comprimento * largura * altura;
                Console.WriteLine("O volume da caixa é " + volume);

                Console.ReadKey();
            }
        }
    }
}
