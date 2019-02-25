using System;
using System.Reflection.Metadata.Ecma335;

namespace Billetlibary
{
    public class MC : Køretøj

    {
   //  public string Nummerplade { get; set; }

   //  public DateTime dato { get; set; }

    public override decimal Pris()
    {
        return 125;

    }      

        public override string KøreTøj()
        {
            return "MC";
        }

        public override decimal prisMedBroBizz()
        {
            decimal rabat = 125 * 5 / 100;
            decimal brobizz = 125 - rabat;

            return brobizz;
        }
    }
}