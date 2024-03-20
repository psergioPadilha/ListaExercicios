//Crie um programa para calcular o consumo de combustível por Km.
//Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo.
//Deverá ser informado o Consumo de Combustível

using System.Reflection.Metadata.Ecma335;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double kmInicial = 0;
            double kmFinal = 0;
            double litros = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CALCULA CONSUMO");
                Console.WriteLine();

                kmInicial = obtemNumeroDouble("Digite a km inicial: ");
                kmFinal = obtemNumeroDouble("Digite a km final: ");
                kmInicial = verificaValoresDaKilometragem(kmInicial, kmFinal);
                litros = obtemNumeroDouble("Digite quantos litros: ");

                double consumo = calculaConsumo(kmInicial, kmFinal, litros);

                //Output
                Console.WriteLine("O consumo de combústivel neste percurso foi de " + consumo + " kilômetros por litro!");

                Console.ReadLine();
            }

            #region Imput
            static double obtemNumeroDouble(String mensagem)
            {
                Console.Write(mensagem);
                double numeroDouble = Convert.ToDouble(Console.ReadLine());
                return numeroDouble;
            }
            #endregion

            #region Verifica se a kilometragem foi digitada corretamente
            static double verificaValoresDaKilometragem(double inicial, double final)
            {
                while (inicial > final)
                {
                    Console.WriteLine("A kilometragem inicial não pode ser maior que a kilometragem final!");
                    inicial = obtemNumeroDouble("Digite a km inicial: ");
                }
                return inicial;
            }
            #endregion

            #region Processamento
            static double calculaConsumo(double inicial, double final, double litros)
            {
                return (final - inicial) / litros;
            }
            #endregion
        }
    }
}
