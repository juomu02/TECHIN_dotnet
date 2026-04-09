using System;
using System.Xml;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateBMI();
        }
        static void CalculateBMI()
        {
            Console.WriteLine("KMI skaičiuoklė");
            var height = ReadPositiveNumber("Įveskite savo ūgį centimetrais:");
            var weight = ReadPositiveNumber("Įveskite savo svorį kilogramais:");
            double bmi = Math.Round((double)weight * 10000 / ((double)height * (double)height), 1);


            switch (bmi)
            {
                case < 18.5:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. Per mažas svoris/mitybos nepakankamumas");
                    break;
                case >= 18.5 and <= 24.9:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. Normalus svoris, normali kūno masė");
                    break;
                case >= 25.0 and <= 29.9:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. Antsvoris");
                    break;
                case >= 30 and <= 34.9:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. I laipsnio nutukimas");
                    break;
                case >= 35.0 and <= 39.9:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. II laipsnio nutukimas");
                    break;
                default:
                    Console.WriteLine($"Jūsų BMI yra {bmi}. III laipsnio nutukimas");
                    break;

            }

        }
        static int ReadPositiveNumber(string title)
        {
            Console.Write(title);
            var input = Console.ReadLine();
            bool correctInput = false;
            int output = 0;
            do
            {
                if (int.TryParse(input, out int inputNumber) && inputNumber > 0)
                {
                    correctInput = true;
                    output = inputNumber;
                }
                else
                {
                    Console.WriteLine($"Įvedėte neteisingą reikšmę. {title}");
                    input = Console.ReadLine();
                }
                ;
            } while (!correctInput);
            Console.WriteLine();
            return output;

        }
    }
}