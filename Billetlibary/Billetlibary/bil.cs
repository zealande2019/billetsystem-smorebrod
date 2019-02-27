using System;
using System.Runtime.InteropServices;

namespace Billetlibary
{
    public class Bil : Køretøj
    {
        

        /// <summary>
        /// Metode til pris for en brobillet til en bil 
        /// </summary>
        /// <returns> Retunere prisen </returns>
        public override decimal Pris()
        {
            return 240m;
        }

    

        public override string KøreTøj()
        {
            return "bil";
        }



        // udregner prisen på brobillet med brobizz
        public override decimal prisMedBroBizz()
        {
            decimal rabat = Pris() * 5 / 100m;
            decimal brobizz = Pris() - rabat;

            return brobizz;
        }
        
        public decimal WeekendsRabat(DateTime day)
        {

            decimal result2 = Pris() * 0.95m;
            decimal result = Pris() * 0.80m;
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                return result;
            }
            else
            {
                return result2;
            }
        }

    }
}
