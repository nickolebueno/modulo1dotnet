using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientObjeto.src
{
    public class Amor
    {
        public string Sentimento { get; set; }
        public string Familia { get; set; }
        public string Sensação  { get; set; }

        public Amor() { }
        public Amor(string sensação, string familia, string sentimento) 
        
        {
            Sensação = sensação;
            Familia = familia;
            Sentimento = sentimento;
        }

        public void Sentir (string Emoção)
        {

            Console.WriteLine($"Você está sentindo:{Emoção} ");
        }

        public void Exibir () 
        {
            Console.WriteLine($"sentimento: {Sentimento}");
            Console.WriteLine($"familia: {Familia}");
            Console.WriteLine($"sensação: {Sensação}");

        }
    }
}
