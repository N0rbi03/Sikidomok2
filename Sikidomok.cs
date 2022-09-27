using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok2
{
    class Sikidomok
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidoms = new List<Sikidom>();

            sikidoms.Add(new Kor(2.5,"Kör"));
            sikidoms.Add(new Kor(5.1,"Kör"));
            sikidoms.Add(new Negyzet(2.5,"Négyzet"));
            sikidoms.Add(new Negyzet(5.1,"Négyzet"));
            foreach (Sikidom item in sikidoms)
            {
                
                if (item.GetType().Equals(typeof (Kor)))
                {
                    
                    Kor kor = (Kor)item;
                    Console.WriteLine($"{kor.AlakzatTipus}\tKerület:{item.Kerulet():N2} \tTerület: {item.Terület():N2} \t A körnek a sugara:{kor.Sugar:N2}");
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"{negyzet.AlakzatTipus}\tKerület:{item.Kerulet():N2} \tTerület: {item.Terület():N2} \t A négyzetnek az oldala: {negyzet.Elsooldal}");
                }

            }

            Console.WriteLine("\n Program vége");

            Console.ReadKey();
        }
    }
}
