using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.src
{
    internal class Quadrado : BaseForm, ICalculateArea
    {
        public Quadrado(float _base) : base(_base)
        {
            Base = _base;

        }

        public void CalculateArea()
        {
            Console.WriteLine($"squareArea = {Base * Base}");

        }
    }
}
