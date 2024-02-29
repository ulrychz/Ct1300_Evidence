namespace Ct1300_Evidence.Models
{
    public class Polozky
    {
		private DateOnly datum;

		public DateOnly Datum
		{
			get { return datum; }
			set { datum = value; }
		}

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

	}
}
