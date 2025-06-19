using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Calculator
{
    class CalculatorServices
    {

    public double SumMethod()
    {
        int num;
        do
        {
            Console.WriteLine("How many numbers would you like to enter? ");
            num = int.Parse(Console.ReadLine());

            if (int.IsNegative(num) || num == 0)
            {
                Console.WriteLine("Enter a valid number, please..");
            }

        } while (int.IsNegative(num) || num == 0);

        int[] numSum = new int[num];
        for (var i = 0; i < num; i++)
        {
            Console.WriteLine($"Great!\n Enter the number: {i + 1}");
            numSum[i] = (int.Parse(Console.ReadLine()));
        }

        int sumDigits = numSum.Sum();

        Console.WriteLine($"The result to your operation is {sumDigits}");

        Console.ReadKey();

        return sumDigits;
    }

            public double SubMethod()
            {
                int num2;
                do
                {
                    Console.WriteLine("Enter how many number you would like to subtract: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (int.IsNegative(num2) || num2 == 0)
                    {
                        Console.WriteLine("Enter a valid number, please..");
                    }
                } while (int.IsNegative(num2) || num2 == 0);

                int[] numSub = new int[num2];

                for (int j = 0; j < num2; j++)
                {
                    Console.WriteLine($"Great!\n Enter the number: {j + 1}");
                    numSub[j] = int.Parse(Console.ReadLine());
                }

                int result = numSub[0];

                for (int h = 1; h < numSub.Length; h++)
                {
                    result -= numSub[h];
                }

                Console.WriteLine($"The result to your operation is {result}");

                Console.ReadKey();

                return result;
            }


            public double MultMethod()
            {
                int Multnum;
                do
                {
                    Console.WriteLine("Enter how many number you would like to multiple: ");
                    Multnum = int.Parse(Console.ReadLine());

                    if (int.IsNegative(Multnum) || Multnum == 0)
                    {
                        Console.WriteLine("Enter a valid number, please..");
                    }
                } while (int.IsNegative(Multnum) || Multnum == 0);

                int[] numMult = new int[Multnum];

                for (int k = 0; k < Multnum; k++)
                {
                    Console.WriteLine($"Enter the number {k + 1}: ");
                    numMult[k] = int.Parse(Console.ReadLine());
                }

                int resultMult = numMult[0];

                for (int l = 1; l < numMult.Length; l++)
                {
                    resultMult *= numMult[l];
                }

                Console.WriteLine($"The result to your operation is {resultMult}.");

                Console.ReadKey();

                return resultMult;
            }

            public double DivMethod()
            {
                int Divnum;
                do
                {
                    Console.WriteLine("Enter how many numbers you would like to divide: ");
                    Divnum = int.Parse(Console.ReadLine());

                    if (int.IsNegative(Divnum) || Divnum == 0)
                    {
                        Console.WriteLine("Enter a valid number, please..");
                    }
                } while (int.IsNegative(Divnum) || Divnum == 0);

                int[] numDiv = new int[Divnum];

                for (int m = 0; m < Divnum; m++)
                {
                    Console.WriteLine($"Enter the number {m + 1}: ");
                    numDiv[m] = int.Parse(Console.ReadLine());
                }

                int resultDiv = numDiv[0];

                for (int n = 1; n < numDiv.Length; n++)
                {
                    resultDiv /= numDiv[n];
                }

                Console.WriteLine($"The result to your operation is {resultDiv}.");

                Console.ReadKey();

                return resultDiv;
            }
    }
}