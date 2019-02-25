using System;

namespace Billetlibary
{
    public class bil : Køretøj
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
    }
}
