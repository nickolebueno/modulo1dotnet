using System;

namespace IMC
{
    internal class Program
    {

        //Fazer um programa utilizando o Visual Studio, que Leia o nome, idade, altura e peso.
        //Em seguida calcule o IMC da pessoa. Mostre o resultado na tela. Não e necessário classificar por peso.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your height: ");
            float height = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight: ");
            float weight = (float)Convert.ToDouble(Console.ReadLine());

            // Equation: weight / (height * height) = w/h2
            float imc = weight / (height * height);
            if (imc >= 30)
            {
                Console.WriteLine($"Obesity, your imc is: {imc}");
            }
            else if (imc < 30 && imc >= 25)
            {
                Console.WriteLine($"Over weight, your imc is: {imc}");
            }
            else if (imc > 25 && imc >= 18.5)
            {
                Console.WriteLine($"Normal weight, your imc is: {imc}");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine($"Under weight, your imc is: {imc}");
            }
        }
    }
}
