namespace Ct1300_Evidence.Models
{
    public class Evidence
    {
        public List<Polozky> Polozky { get; set; } = new List<Polozky>();
        public Polozky Polozka { get; set; } = new Polozky();
        public string Vypis { get; set; }
        public void Pridat()
        {
            //Polozky.Add(Polozka);
            //Polozka = new Polozky();

            Polozky.Add(new Polozky(datum: Polozka.Datum, Polozka.Naklady, Polozka.Vynosy));
        }

        public void ZobrazPocetZaznamu()
        {
            Vypis = $"Počet záznamů je {Polozky.Count}";
        }
        public void ZobrazitZaznamy()
        {
            Vypis = $"Jednotlivé záznamy: <br> {string.Join("<br>", Polozky)}";
        }
    }
}
