﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok2
{
    internal class Kor : Sikidom
    {
        double sugar;

        public Kor(double sugar,string tipus):base (tipus)
        {
            this.sugar = sugar;
        }

        public double Sugar { get => sugar; set => sugar = value; }

        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public override double Terület()
        {
            return sugar * sugar * Math.PI;
        }
    }
}
