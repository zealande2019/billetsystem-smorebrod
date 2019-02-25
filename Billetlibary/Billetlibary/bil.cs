using System;

namespace Billetlibary
{
    public class Bil : Køretøj
    {
        // public string Nummerplade { get; set; }

       // public DateTime Dato { get; set; }


        public override decimal Pris()
        {
            return 240;
        }

    

        public override string KøreTøj()
        {
            return "bil";
        }

        public override decimal prisMedBroBizz()
        {
            decimal rabat = 240 * 5 / 100;
            decimal brobizz = 240 - rabat;

            return brobizz;
        }
    }
}
