using System;
using Areas.src;

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Na matemática existem diferentes formas geométricas, mas todas elas possuem fórmula para encontrar suas áreas.
            // Represente uma aplicação utilizando polimorfismo.E demostre como encontrar área de um retângulo, quadrado e um triangulo.

            Quadrado quadrado = new Quadrado(40);
            quadrado.CalculateArea();

            Retangulo retangulo = new Retangulo(20, 40);
            retangulo.CalculateArea();

            Triangulo triangulo = new Triangulo(60, 35);
            triangulo.CalculateArea();

        }
    }
}
