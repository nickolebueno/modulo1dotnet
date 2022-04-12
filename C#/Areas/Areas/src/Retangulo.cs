using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.src
{
    internal class Retangulo : BaseForm, ICalculateArea
    {

        private float height; 

        public Retangulo(float _base, float _height) : base(_base)
        {
            Base = _base;
            height = _height;
            

        }

        public void CalculateArea()
       {
            Console.WriteLine($"retangleArea = {Base * height}");
            {
    }
        }
    }
}


