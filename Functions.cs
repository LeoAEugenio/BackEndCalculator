using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Calculator
{
    class Functions
    {
        CalculatorServices calculatorServices = new CalculatorServices();

        public void CalculatorHeader()
        {
            string header = @"
            #########################
            #       Calculator      #
            #########################
            ";
            Console.WriteLine(header);
        }

        public void OptionSelected()
        {
            CalculatorHeader();

            int input;
            do
            {
                Console.WriteLine("Welcome!\n Select an option from those available to:\n \n Sum = 0,\n Subtract = 1,\n Multiple = 2,\n or Divide = 3:  ");
                input = int.Parse(Console.ReadLine());

                if (int.IsNegative(input))
                {
                    Console.WriteLine("Enter a valid option, please...\n");
                }
            } while (int.IsNegative(input));


            Console.WriteLine($"Option selected: {input}\n");

            Opcoes OpcaoSelecionada = (Opcoes)input;

            switch (OpcaoSelecionada)
            {
                case Opcoes.Sum:
                    calculatorServices.SumMethod();
                    break;
                case Opcoes.Subtract:
                    calculatorServices.SubMethod();
                    break;
                case Opcoes.Multiple:
                    calculatorServices.MultMethod();
                    break;
                case Opcoes.Divide:
                    calculatorServices.DivMethod();
                    break;
                default:
                    Console.WriteLine("Option not found...");
                    break;
            }
        }
    }
} 