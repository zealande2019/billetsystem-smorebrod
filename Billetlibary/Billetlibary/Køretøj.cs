using System;
using System.Security.Cryptography.X509Certificates;

namespace Billetlibary
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        public abstract decimal Pris();

        public abstract string KøreTøj();
    }
}