using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiApp.Model
{

    public class Ayakkabi
    {
        public Ayakkabi()
        {

        }
        public Ayakkabi(string marka, string numara, string barkod)
        {
            Marka = marka;
            Numara = numara;
            Barkod = barkod;


        }

        public Ayakkabi(int ayakkabiId, string marka, string numara, string barkod)
        {
            AyakkabiId = ayakkabiId;
            Marka = marka;
            Numara = numara;
            Barkod = barkod;
           
        }

        public int AyakkabiId { get; set; }
        public string Marka { get; set; }
        public string Numara { get; set; }
        public string Barkod { get; set; }

    }

}
