using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Bokning
    {
        private Bok bok;
        private Medlem medlem;
        public int bokningsNr;
        private DateTime starttidBokning;
        RepositoryBokningar rb = new RepositoryBokningar();

        public Bokning(Bok b, Medlem m)
        {
            bok = b;
            medlem = m;
            bokningsNr = new Random().Next(10000);
            starttidBokning = DateTime.Now;
        }

        public void BokaBok(Bokning b)
        {
            //Bokning b = new Bokning(ISBN, m);
            
            rb.Bokningar.Add(b);
        }
    }
}
