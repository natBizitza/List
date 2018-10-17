using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FamousSinger
    {
        private string name, bestSellingAlbum;


        public FamousSinger(string name, string bestSellingAlbum)
        {
            this.name = name;
            this.bestSellingAlbum = bestSellingAlbum;
        }

        // Get and Set methods
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetBestSellingAlbum()
        {
            return this.bestSellingAlbum;
        }
        public void SetbestSellingAlbum(string bestSellingAlbum)
        {
            this.bestSellingAlbum = bestSellingAlbum;
        }

    }
}
