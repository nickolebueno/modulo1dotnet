using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.src
{
    internal class Triangulo : BaseForm, ICalculateArea
    {

        private float height;

        public Triangulo(float _base, float _height) : base(_base)
        {
            Base = _base;
            height = _height;


        }

        public void CalculateArea()
        {
            Console.WriteLine($"triangleArea = {(Base * height) / 2}");
          
        }
    }
}
