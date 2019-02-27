using System;
using System.Security.Cryptography.X509Certificates;

namespace Billetlibary
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        public string nummerplade
        {
            get { return nummerplade; }

            set {
                  if (nummerplade.Length > 7)
                  {
                    throw new  Exception();
                  }
                }
        }


        /// <summary>
        /// Metode til pris for brobillet, skal overrides 
        /// </summary>
        /// <returns>Prisen på en brobillet</returns>
        public abstract decimal Pris();

        public abstract string KøreTøj();

        public abstract decimal prisMedBroBizz();
    }
}