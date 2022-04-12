using System;
using Polimorfismo.src;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Os animais possuem muitas ações parecidas, mas são considerados diferentes por algumas particularidades.
            //Construa uma aplicação que demonstra o Polimorfismo entre diferentes tipos de animais.

            Console.WriteLine("Fazendinha");

            Cachorro var1 = new Cachorro("Pandanás", "Cachorro Maléfico", "Dedos Humanos", "Ursinho de Pelúcia");
            var1.Comer();

            Jabuti var2 = new Jabuti("Sócrates", "Jabuti Canibal", "Bananinha B", "Bola de Capotão");
            var2.Comer();
            
    
            
        }
    }
}
