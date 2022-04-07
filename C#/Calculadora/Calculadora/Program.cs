using System;
 
namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Mallu estava na escolinha, e sua professora estava para aplicar uma prova de matemática com operações básicos. 
             * A professora falou que seria possível utilizar uma calculadora. Então Malluzinha começou a imaginar como seria
             desenvolver uma calculadora com os seguintes requisitos:
               1. Ter operadores aritméticos básicos: soma, subtração, multiplicação e divisão;
               2. A calculadora deve ter um botão para ligar e desligar, não pode parar de rodar
               enquanto o botão de desligar não for ativado;*/

            int y = 0;
            int x = 0;
            bool on = true;

            while (on)
            {
                Console.WriteLine("set the first number:");
                x = int.Parse( Console.ReadLine());
                Console.WriteLine("set the operator:");
                string operators = Console.ReadLine();

                Console.WriteLine("set the second number:");
                y = int.Parse(Console.ReadLine());
                

                switch (operators)
                {
                    case "+":
                        Console.WriteLine($"the sum result is {Sum(x, y)}");
                        break;

                    case "-":
                        Console.WriteLine($"the sum result is {Sub(x, y)}");
                        break;

                    case "*":
                        Console.WriteLine($"the sum result is {Mul(x, y)}");
                        break;
                    case "/":
                        Console.WriteLine($"the sum result is {Div(x, y)}");
                        break;
                }
   
                    

                

                Console.WriteLine("are you sure u wanna quit calculator?");
                string condition = Console.ReadLine();
                if (condition == "yes")
                {
                on = false;
                }
                else
                {
                on = true;

                }
            }
            }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
