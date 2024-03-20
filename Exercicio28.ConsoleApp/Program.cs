//Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10.
//Para isso, o programa deve gerar todas as combinações de multiplicação entre 1 e 10,
//exibindo o resultado de cada operação na tela.
//Desafio: Para cada número, tente separar em colunas.


namespace Exercicio28.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            for (int i = 1; i < 11; i++)
            {
                for (int n = 1; n < 11; n++)
                {
                    int multiplicacao = i * n;
                    Console.Write("{0} x {1} = {2}\t", n, i, multiplicacao  /* n + " x " + i + " = " + multiplicacao + "\t" */);
                }
                Console.Write("\n");
            }
        }
    }
}
