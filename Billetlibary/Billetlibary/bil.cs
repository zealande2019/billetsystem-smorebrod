using System;

namespace Billetlibary
{
    public class bil
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }


        public decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }

    }
}
