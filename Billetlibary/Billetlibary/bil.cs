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
            return 240;
        }

    

        public override string KøreTøj()
        {
            return "bil";
        }



        // udregner prisen på brobillet med brobizz
        public override decimal prisMedBroBizz()
        {
            decimal rabat = 240 * 5 / 100;
            decimal brobizz = 240 - rabat;

            return brobizz;
        }
        
        public double WeekendsRabat(DateTime day)
        {

            var result2 = 240 * 0.95;
            var result = 240 * 0.80;
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
