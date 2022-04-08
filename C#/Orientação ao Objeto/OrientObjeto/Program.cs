using System;
using OrientObjeto.src;

namespace OrientObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amor harry = new Amor("comfortable", "husband", "in love");
            Amor songs = new Amor("as it was", "watermelon sugar", "falling");
            Amor gossip = new Amor("one direction", "louis", "never go out of style");
            Amor about = new Amor("bi", "handsome", "mine");

            Console.WriteLine("leitura de objetos");
            harry.Exibir();
            songs.Exibir();
            gossip.Exibir();
            about.Exibir();

   

        }
    }
}
