using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Medlem
    {
        private string namn;
        public string Namn 
        {
            get { return namn; }
            set { namn = value; }
        }

        private string medlemsNr;
        public string MedlemsNr
        {
            get { return medlemsNr; }
            set { medlemsNr = value; }
        }

        public string telefonNr { get; set; }
        public string epost { get; set; }

        private Bokning bokningMedlem; 



        /*public Medlem(string förnamn, string efternamn, int lösenord)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Id = new Random().Next(1000);
            Lösenord = lösenord;    
        }*/

    }
}
