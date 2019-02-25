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
    }
}