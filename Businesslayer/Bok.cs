using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Bok
    {
        private int isbn;

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        
        //public bool bokad = false;

        /*public Bok(int isbn, string titel)
        {
            ISBN = isbn;    
            Titel = titel;
        }*/
       
    }
}
