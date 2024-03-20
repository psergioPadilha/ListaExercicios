//O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde
//para dar uma indicação sobre a condição de peso de uma pessoa adulta.
//A fórmula é IMC = peso / (altura) ².
//Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
//IMC em adultos Condição
//Abaixo de 18,5
//Abaixo do peso
//Entre 18,5 e 25 Peso normal
//Entre 25 e 30
//Acima do peso
//Acima de 30 obeso


namespace Exercicio19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;
            String opcao;
            String pessoa;
            while (true)
            {
                //Limpa tela e apresenta menu
                Console.Clear();
                Console.WriteLine("PROGRAMA ÍNDICE DE MASSA CORPORAL");
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

                Console.Write("Pessoa: ");
                pessoa = Console.ReadLine();

                Console.Write("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                imc = peso / (Math.Pow(altura, 2));

                Console.WriteLine("O IMC do " + pessoa + " é : " + imc + ".");

                if (imc < 18.5)
                {
                    Console.WriteLine("O " + pessoa + " está abaixo do peso indicado pela 'OMC'!");
                }
                else if ((imc > 18.5) && (imc <= 30))
                {
                    Console.WriteLine("Parabéns " + pessoa + " você está dentro do peso indicado pela 'OMC'!");
                }
                else if (imc > 30)
                {
                    Console.WriteLine("O " + pessoa + " está acima do peso indicado pela 'OMC'!");
                }

                Console.ReadLine();
            }
        }
    }
}
