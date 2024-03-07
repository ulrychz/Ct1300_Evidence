namespace Ct1300_Evidence.Models
{
    public class Evidence
    {
        public List<Polozky> Polozky { get; set; } = new List<Polozky>();
        public Polozky Polozka { get; set; } = new Polozky();

        public void Pridat()
        {
            //Polozky.Add(Polozka);
            //Polozka = new Polozky();

            Polozky.Add(new Polozky(datum: Polozka.Datum, Polozka.Naklady, Polozka.Vynosy));
        }
    }
}
