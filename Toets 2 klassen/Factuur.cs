using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace Toets_2_klassen
{
    internal class Factuur
    {

        private List <FactuurLijn> factuur = new List<FactuurLijn>();



        public List<FactuurLijn> Factuuren
        {
         get { return factuur; }
        }

        public int FactuurID { get; set; }

        public int KlantID { get; set; }

        public string KlantNaam { get; set; }


        public Factuur()
        {

        }

        public Factuur(int factuurID, int klantID, string naamKlant)
        {
            FactuurID = factuurID;

            KlantID = klantID;

            KlantNaam = naamKlant;

        }
        public double BerekenFactuurTotaal()
        {
            double totaal;
            int aaantal = 0;
            string productnaam = " ";
            double prijs = 0;
            FactuurLijn factuurLijnen = new FactuurLijn(aaantal,productnaam, prijs);
            totaal = aaantal * prijs;
            return totaal;
        }

        public string ToString()
        {
            KlantNaam.ToString();
            return KlantNaam;
            
        }


        public void VoegFactuurToe(int aantal, string productNaam, double prijs)
        {

            FactuurLijn factuur = new FactuurLijn(aantal, productNaam, prijs);

           
            
        }
    }
}
