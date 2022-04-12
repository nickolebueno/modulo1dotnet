using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{
    internal class Jabuti : Bichinhos
    {
        public Jabuti (string nome, string espécie, string snackFavorito, string brinquedoFavorito)
        {

            Nome = nome;
            Espécie = espécie;
            SnackFavorito = snackFavorito;
            BrinquedoFavorito = brinquedoFavorito;

        }

        public override void Comer()
        {
            base.Comer();

            Console.WriteLine("O jabuti comeu.");

        }
    }
    
    }
