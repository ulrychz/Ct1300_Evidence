namespace Ct1300_Evidence.Models
{
    public class Evidence
    {
        public List<Polozky> Polozky { get; set; } = new List<Polozky>();
        public Polozky Polozka { get; set; } = new Polozky();
        public string Vypis { get; set; }
        public bool IsEditace { get; set; } = false;
        public void Pridat()
        {
            //Polozky.Add(Polozka);
            //Polozka = new Polozky();

            Polozky.Add(new Polozky(datum: Polozka.Datum, Polozka.Naklady, Polozka.Vynosy));
        }

        public void Editace(Polozky pol)
        {
            Polozka = pol;
            IsEditace = true;
        }
        public void UkonciEditaci()
        {
            IsEditace=false;
            Polozka = new Polozky();
        }
        public void ZobrazPocetZaznamu()
        {
            Vypis = $"Počet záznamů je {Polozky.Count}";
        }
        public void ZobrazitZaznamy()
        {
            Vypis = $"Jednotlivé záznamy: <br> {string.Join("<br>", Polozky)}";
        }

        public void ZobrazStatistiky()
        {
            Vypis = "";
            Vypis += $"Minimum: {Minimum()} <br>";
            Vypis += $"Maximum: {Maximum()} <br>";
            Vypis += $"Průměr: {Prumer()}";
        }

        private double Minimum()
        {
            if (Polozky.Count == 0)
            {
                return double.NaN;
            }
            else
            {
                return Polozky.Min(pol=>pol.Zisk);
            }
        }
        private double Maximum()
        {
            if (Polozky.Count == 0)
            {
                return double.NaN;
            }
            else
            {
                return Polozky.Max(pol => pol.Zisk);
            }
        }

        private double Prumer()
        {
            if (Polozky.Count == 0)
            {
                return double.NaN;
            }
            else
            {
                return Polozky.Average(pol => pol.Zisk);
            }
        }
    }
}
