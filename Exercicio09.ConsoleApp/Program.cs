//Crie um programa para calcular a média harmônica das notas de um Aluno

namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int quantidadeDeNotas = Menu();

                double[] notas = new double[quantidadeDeNotas];
                double mediaHarmonica;
                int maiorNota = 0, menorNota = 100, totalSomaDasNotas = 0, minimoMultiploComum = 0;
                int[] notasInteiras = new int[quantidadeDeNotas];
                int[] auxiliarInteiros = new int[quantidadeDeNotas];

                //Capta o valor de entrada digitado pelo usuário e atribui a uma posição do array
                EntrarComAsNotas(quantidadeDeNotas, notas);

                //Passa os valores do array decimal para um array inteiro
                PassarArrayDecimalParaArrayInteiro(quantidadeDeNotas, notas, notasInteiras);

                //Verifica qual o maior valor do array
                maiorNota = VerificarMaiorValorDoArray(quantidadeDeNotas, maiorNota, notasInteiras);

                //Verifica qual o menor valor do array
                menorNota = VerificarMenorValorDoArray(quantidadeDeNotas, menorNota, notasInteiras);

                //Calcula o 'MMC' entre os valores atribuidos ao array
                minimoMultiploComum = CalcularMmc(quantidadeDeNotas, maiorNota, notasInteiras);

                //Divide o 'MMC' pelo valor atribuido em cada posição do array e
                //atribui o resultado da divisão a posições de um array auxiliar
                DividirMmcPelasNotasInteiras(quantidadeDeNotas, notasInteiras, minimoMultiploComum, auxiliarInteiros);

                //Soma os valores do array auxiliar
                totalSomaDasNotas = SomarValoresDoArrayAux(quantidadeDeNotas, auxiliarInteiros, totalSomaDasNotas);

                //Iguala as bases numéricas para apresentar a média na mesma base de entrada
                mediaHarmonica = IgualarBasesNumericas(ref maiorNota, ref menorNota, ref minimoMultiploComum, totalSomaDasNotas);

                //Imprime no console os valores de saída
                ImprimirResultados(mediaHarmonica, maiorNota, menorNota, minimoMultiploComum);

                Console.ReadLine();
            }

        }

        #region Menu
        static int Menu()
        {
            Console.Clear();

            Console.WriteLine("PROGRAMA CALCULA MÉDIA DAS NOTAS");
            Console.WriteLine();
            Console.WriteLine("Quantas notas deseja calcular?");
            Console.Write("Número de notas: ");
            int quantidadeDeNotas = Convert.ToInt32(Console.ReadLine());
            return quantidadeDeNotas;
        }
        #endregion

        #region Entrada das notas do aluno
        private static void EntrarComAsNotas(int quantidadeDeNotas, double[] notas)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                Console.Write("Digite a " + (i + 1) + "º nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        #endregion

        #region Passa os valores do array decimal para inteiro e atribui a um novo array
        private static void PassarArrayDecimalParaArrayInteiro(int quantidadeDeNotas, double[] notas, int[] notasInteiras)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                double auxiliar = notas[i] * 10;
                notasInteiras[i] = Convert.ToInt32(auxiliar);
            }
        }
        #endregion

        #region Verifica o maior valor do array
        private static int VerificarMaiorValorDoArray(int quantidadeDeNotas, int maiorNota, int[] notasInteiras)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                if (notasInteiras[i] > maiorNota)
                {
                    maiorNota = notasInteiras[i];
                }
            }

            return maiorNota;
        }
        #endregion

        #region Verifica o menor valor do array
        private static int VerificarMenorValorDoArray(int quantidadeDeNotas, int menorNota, int[] notasInteiras)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                if (notasInteiras[i] < menorNota)
                {
                    menorNota = notasInteiras[i];
                }
            }

            return menorNota;
        }
        #endregion

        #region Calcula o MMC
        private static int CalcularMmc(int quantidadeDeNotas, int maiorNota, int[] notasInteiras)
        {
            int minimoMultiploComum = maiorNota;
            int posicaoDoArray = 0;
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                if (minimoMultiploComum % notasInteiras[i] != 0)
                {
                    minimoMultiploComum++;
                    i = 0;
                }
            }

            return minimoMultiploComum;
        }
        #endregion

        #region Dividi o valor do MMC pelo valor atribuido em cada posição do array
        private static void DividirMmcPelasNotasInteiras(int quantidadeDeNotas, int[] notasInteiras, int minimoMultiploComum, int[] auxiliarInteiros)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                auxiliarInteiros[i] = minimoMultiploComum / notasInteiras[i];
            }
        }
        #endregion

        #region Soma valores do array auxiliar
        private static int SomarValoresDoArrayAux(int quantidadeDeNotas, int[] auxiliarInteiros, int totalSomaDasNotas)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                totalSomaDasNotas = totalSomaDasNotas + auxiliarInteiros[i];
            }

            return totalSomaDasNotas;
        }
        #endregion

        #region Iguala as bases numéricas
        private static double IgualarBasesNumericas(ref int maiorNota, ref int menorNota, ref int minimoMultiploComum, int totalSomaDasNotas)
        {
            double mediaHarmonica;
            //Divide o 'MMC' por '10' para deixar o valor na mesma base numérica dos valores de entrada das notas
            minimoMultiploComum = minimoMultiploComum / 10;

            //Divide o 'MMC' pelo total da soma das notas e multiplica por '3' para de fato chegar a média harmônica
            mediaHarmonica = (minimoMultiploComum / totalSomaDasNotas) * 3;

            //Divide o valor da maior nota para deixar na mesma base numérica
            maiorNota = maiorNota / 10;

            //Divide o valor da menor nota para deixar na mesma base numérica
            menorNota = menorNota / 10;
            return mediaHarmonica;
        }
        #endregion

        #region Imprimi os resultados
        private static void ImprimirResultados(double mediaHarmonica, int maiorNota, int menorNota, int minimoMultiploComum)
        {
            Console.WriteLine();
            Console.WriteLine("A maior nota é = " + maiorNota);
            Console.WriteLine("A menor nota é = " + menorNota);
            Console.WriteLine("O MMC das notas é " + minimoMultiploComum);
            Console.WriteLine("'A MÉDIA HARMÔNICA É' = " + mediaHarmonica.ToString("F"));
        }
        #endregion
    }
}
