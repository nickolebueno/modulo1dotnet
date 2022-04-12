using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{
    internal class Cachorro : Bichinhos
    {
        public Cachorro (string nome, string espécie, string snackFavorito, string brinquedoFavorito)
        {

            Nome = nome;
            Espécie = espécie;
            SnackFavorito = snackFavorito;
            BrinquedoFavorito = brinquedoFavorito;

        }

        public override void Comer()
        {
            base.Comer();

            Console.WriteLine("O cachorro comeu.");

        }
    }
}
