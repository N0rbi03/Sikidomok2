using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok2
{
    internal class Negyzet : Sikidom
    {
        double elsooldal;

        public Negyzet(double elsooldal,string tipus):base(tipus)
        {
            this.elsooldal = elsooldal;
        }

        public double Elsooldal { get => elsooldal; set => elsooldal = value; }

        public override double Kerulet()
        {
            return elsooldal * 4;
        }

        public override double Terület()
        {
            return elsooldal * elsooldal;
        }
    }
}
