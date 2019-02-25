namespace Billetlibary
{
    public class MC
    {
        public string Nummerplade { get; set; }

        public DateTime dato { get; set; }

        public decimal pris()
        {
            return 125;

        }

        public string køretøj()
        {
            return "MC";
        }
    }
}