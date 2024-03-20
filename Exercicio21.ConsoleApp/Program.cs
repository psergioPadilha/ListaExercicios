//Faça um algoritmo que leia dois valores inteiros A e B,
//se os valores forem iguais deverá se somar os dois,
//caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

namespace Exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            String auxiliar;
            double numero1;
            double numero2;
            double resultado;

            while (true)
            {
                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA ANALISADOR DE NÚMEROS");
                Console.WriteLine();
                Console.WriteLine("Para sair digite 'S';");
                Console.WriteLine("Para continuar digite 'C';");
                opcao = Console.ReadLine();

                //Verifica e valida menu
                while ((opcao != "C") && (opcao != "c") && (opcao != "S") && (opcao != "s"))
                {
                    Console.WriteLine("Opção inválida, por favor digite novamente...");
                    opcao = Console.ReadLine();
                }

                if ((opcao == "S") || (opcao == "s"))
                {
                    Console.WriteLine("Digite 'S' para confirmar e 'C' para cancelar!");
                    opcao = Console.ReadLine();

                    while ((opcao != "C") && (opcao != "c") && (opcao != "S") && (opcao != "s"))
                    {
                        Console.WriteLine("Opção inválida, por favor digite novamente...");
                        opcao = Console.ReadLine();
                    }
                    if ((opcao == "S") || (opcao == "s"))
                    {
                        break;
                    }
                }

                Console.Write("Primeiro número: ");
                auxiliar = Console.ReadLine();

                while (!auxiliar.All(char.IsDigit))
                {
                    Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                    Console.Write("Primeiro Número: ");
                    auxiliar = Console.ReadLine();
                }

                numero1 = Convert.ToInt32(auxiliar);

                Console.Write("Segundo número: ");
                auxiliar = Console.ReadLine();

                while (!auxiliar.All(char.IsDigit))
                {
                    Console.WriteLine("O valor digitado não é um número inteiro, por favor digite novamente!");
                    Console.Write("Segundo Número: ");
                    auxiliar = Console.ReadLine();
                }

                numero2 = Convert.ToInt32(auxiliar);

                if (numero1 == numero2)
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine("Os números são iguais, portanto o resultado da soma é " + resultado);
                }
                else
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine("Os números são diferentes, portanto o resultado da multiplicação é " + resultado);
                }

                Console.ReadLine();
            }
        }
    }
}
