using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok2
{
    abstract class Sikidom
    {
        readonly string alakzatTipus;

        protected Sikidom(string alakzatTipus)
        {
            this.alakzatTipus = alakzatTipus;
        }

        public string AlakzatTipus => alakzatTipus;


        public abstract double Kerulet();

     public abstract double Terület();
    }
}
