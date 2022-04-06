using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
            Console.WriteLine($"{i} x {input} = {i * input}");
            }

        }
    }
}
