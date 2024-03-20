//Crie um programa para calcular a média harmônica das notas de um Aluno

namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Esse comando limpa a tela
                Console.Clear();

                Console.WriteLine("PROGRAMA CALCULA MÉDIA DAS NOTAS");
                Console.WriteLine("Quantas notas deseja calcular? ");

                int quantidadeDeNotas = Convert.ToInt32(Console.ReadLine());
                double[] notas = new double[quantidadeDeNotas];
                double mediaHarmonica;
                int maiorNota = 0;
                int menorNota = 100;
                int[] notasInteiras = new int[quantidadeDeNotas];
                int minimoMultiploComum = 0;
                int[] auxiliarInteiros = new int[quantidadeDeNotas];
                int totalSomaDasNotas = 0;

                //Capta o valor de entrada digitado pelo usuário e atribui a uma posição do array
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    Console.Write("Digite a " + (i + 1) + "º nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }

                //Passa os valores do array decimal para um array inteiro
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    double auxiliar = notas[i] * 10;
                    notasInteiras[i] = Convert.ToInt32(auxiliar);
                }

                //Verifica qual o maior valor do array
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    if (notasInteiras[i] > maiorNota)
                    {
                        maiorNota = notasInteiras[i];
                    }
                }

                //Verifica qual o menor valor do array
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    if (notasInteiras[i] < menorNota)
                    {
                        menorNota = notasInteiras[i];
                    }
                }

                //Calcula o 'MMC' entre os valores atribuidos ao array
                minimoMultiploComum = maiorNota;
                int posicaoDoArray = 0;
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    if (minimoMultiploComum % notasInteiras[i] != 0)
                    {
                        minimoMultiploComum ++;
                        i = 0;
                    }
                }

                //Divide o 'MMC' pelo valor atribuido em cada posição do array e
                //atribui o resultado da divisão a posições de um array auxiliar
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    auxiliarInteiros[i] = minimoMultiploComum / notasInteiras[i];
                }

                //Soma os valores do array auxiliar e divide pelo valor do 'MMC'
                //dividido por '10' para igualar a mesma base numérica das notas
                for (int i = 0; i < quantidadeDeNotas; i++)
                {
                    totalSomaDasNotas = totalSomaDasNotas + auxiliarInteiros[i];
                }

                //Divide o 'MMC' por '10' para deixar o valor na mesma base numérica dos valores de entrada das notas
                minimoMultiploComum = minimoMultiploComum / 10;

                //Divide o 'MMC' pelo total da soma das notas e multiplica por '3' para de fato chegar a média harmônica
                mediaHarmonica = (minimoMultiploComum / totalSomaDasNotas) * 3;

                //Divide o valor da maior nota para deixar na mesma base numérica
                maiorNota = maiorNota / 10;

                //Divide o valor da menor nota para deixar na mesma base numérica
                menorNota = menorNota / 10;

                //Imprime no console os valores de saída
                Console.WriteLine();
                Console.WriteLine("A maior nota é = " + maiorNota);
                Console.WriteLine("A menor nota é = " + menorNota);
                Console.WriteLine("O MMC das notas é " + minimoMultiploComum);
                Console.WriteLine("'A MÉDIA HARMÔNICA É' = " + mediaHarmonica.ToString("F"));

                Console.ReadLine();
            }
        }
    }
}
