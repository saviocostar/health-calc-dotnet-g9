
using Health_Calc_Pack.Entities.Enums;
using Health_Calc_Pack.Implementations;
using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Olá, seja bem vindo a sua calculadora de IMC e Macronutrientes.\n");
                Console.WriteLine("Selecione a opção desejada:.\n");
                Console.WriteLine("1. Calcular IMC.\n");
                Console.WriteLine("2. Calcular Macronutrientes.\n");
                Console.WriteLine("9. Sair.\n");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CalculateIMC();
                        break;
                    case "2":
                        CalculateMacronutrients();
                        break;
                    case "9":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.ReadKey();
            }
        }

        private static void CalculateIMC()
        {
            IIMC imcCalculator = new IMC();
            double weight;
            double height;

            Console.WriteLine("Informe seu peso em kg: ");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Valor inválido. Informe seu peso em kg: ");
            }

            Console.WriteLine("Informe sua altura em metros: ");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Valor inválido. Informe sua altura em metros: ");
            }

            double imc = imcCalculator.CalcIMC(height, weight);
            Console.WriteLine($"Seu IMC é: {imc}");
        }

        private static void CalculateMacronutrients()
        {
            double weight;

            Console.WriteLine("Informe seu peso em kg: ");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Valor inválido. Informe seu peso em kg: ");
            }

            Console.WriteLine("Informe seu objetivo:\n");
            Console.WriteLine("1. Ganhar massa muscular.\n");
            Console.WriteLine("2. Manter peso.\n");
            Console.WriteLine("3. Perder peso.\n");
            Console.WriteLine("9. Voltar.\n");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CalculateMacronutrientsResult(EnumWeightObjective.Gain, weight);
                    break;
                case "2":
                    CalculateMacronutrientsResult(EnumWeightObjective.Maintain, weight);
                    break;
                case "3":
                    CalculateMacronutrientsResult(EnumWeightObjective.Lose, weight);
                    break;
                case "9":
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }


        }

        private static void CalculateMacronutrientsResult(EnumWeightObjective gain, double weight)
        {
            IMacroNutrientes macroNutrientesCalculator = new MacroNutrientes();

            var result = macroNutrientesCalculator.GetMacroNutrientes(weight, gain);

            Console.WriteLine($"Seu consumo diário deve ser:\n Carboidrato: {result.Carbohydrates}.\n Proteínas: {result.Proteins}.\n Gorduras: {result.Fats}");
        }
    }
}
