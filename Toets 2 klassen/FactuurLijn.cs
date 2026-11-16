using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Web;

namespace Toets_2_klassen
{
    internal class FactuurLijn

    { public int Aantal { get; set; }


        public double Prijs { get; set; }

        public string ProductNaam { get; set; }


        public FactuurLijn()
        {
            Aantal = 0;
            Prijs = 0;

        }

        public FactuurLijn(int aantal, string productNaam, double prijs)
        {
            Aantal = aantal;
            Prijs = prijs;
            ProductNaam = productNaam;


        }

        public string Tostring()
        {
            ProductNaam.ToString();
            return ProductNaam;
            

    }
            

        
    }
}
