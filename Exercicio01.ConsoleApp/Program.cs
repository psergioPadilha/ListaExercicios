//Crie um programa para calcular o volume de uma caixa retangular
//Volume = comprimento*largura*altura

using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA VOLUME DA CAIXA");
                Console.WriteLine();

                decimal comprimento = obterNumeroDecimal("Digite o comprimento da caixa: ");

                decimal largura = obterNumeroDecimal("Digite a largura da caixa: ");

                decimal altura = obterNumeroDecimal("Digite a altura da caixa: ");

                decimal volume = calcularVolume(comprimento, largura, altura);

                Console.WriteLine("\nO volume da caixa é " + volume);

                Console.ReadLine();
            }

            static decimal obterNumeroDecimal(String texto)
            {
                Console.Write(texto);
                decimal numeroDecimal = Convert.ToDecimal(Console.ReadLine());
                return numeroDecimal;
            }

            static decimal calcularVolume(decimal comprimento, decimal larrgura, decimal altura)
            {
                return comprimento * larrgura * altura;
            }
        }
    }
}
