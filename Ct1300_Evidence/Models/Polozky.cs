namespace Ct1300_Evidence.Models
{
    public class Polozky
    {
		public Polozky() 
		{
            Datum = DateOnly.FromDateTime(DateTime.Now);
        }
        public Polozky(DateOnly datum, double naklady, double vynosy)
        {
			Datum = datum;
			Naklady = naklady;
			Vynosy = vynosy;
        }
        public DateOnly Datum { get; set; }// = DateOnly.FromDateTime(DateTime.Now);

		private double naklady;

		public double Naklady
		{
			get { return naklady; }
			set { naklady = Math.Abs(value); }
		}

		private double vynosy;

		public double Vynosy
		{
			get { return vynosy; }
			set { vynosy = Math.Abs(value); }
		}

		public double Zisk => Vynosy - Naklady;

        public override string ToString()
        {
			return $"Datum: {Datum} - Náklady: {Naklady} - Výnosy: {Vynosy} - Zisk: {Zisk}";
        }
    }
}
