using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a horse with a capacity of 20 warriors.
            CaballoDeTroya c1 = new CaballoDeTroya(20);
            //Create 3 Greek warriors (Achilles, Agamenon, and Ajax). 
            Griego g1 = new Griego("Achilles", 30, 6);
            Griego g2 = new Griego("Agamenon", 32, 6);
            Griego g3 = new Griego("Ajax", 31, 6);

            //and mount them on the horse
            Griego.AddGriegoInHorse(g1);


        }
    }
}
