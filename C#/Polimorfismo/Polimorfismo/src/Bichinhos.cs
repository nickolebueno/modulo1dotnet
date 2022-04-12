using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{
    internal abstract class Bichinhos
    {
        public string Nome { get; set; }
        public string Espécie { get; set; }

        public string SnackFavorito { get; set; }

        public string BrinquedoFavorito { get; set; }

        public Bichinhos() { }

        public Bichinhos (string nome, string espécie, string snackFavorito, string brinquedoFavorito) { 
        
            Nome = nome;
            Espécie = espécie;
            SnackFavorito = snackFavorito;
            BrinquedoFavorito = brinquedoFavorito;

        }

       public virtual void Comer() {
            Console.WriteLine($"O {Nome} comeu");

        
        }

    }
}
