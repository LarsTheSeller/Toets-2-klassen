namespace Toets_2_klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaakFactuurAan_Click(object sender, EventArgs e)
        {
            //Een nieuwe variabel aanmaken en invullen, daarna zal deze variabel in de listbox toegevoegd worden.
            Factuur factuur = new Factuur(Convert.ToInt32(txtFactuurID.Text), Convert.ToInt32(txtKlantNummer.Text), txtNaamKlant.Text);

            //toevoegen van item aan lst
            lstFactuur.Items.Add(factuur);

            txtFactuurID.Text = "";
            txtNaamKlant.Text = "";
            txtKlantNummer.Text = "";
        }
        private void TonenInListBox()
        {
            //Casten naar de listbox?

        }
        private void lstFactuur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Zorgen dat wanneer je een item selecteert, de gegevens ervan kan lezen
            FactuurLijn factuur = (FactuurLijn)lstFactuur.SelectedItem;
            factuur.Tostring();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aanmaken van factuurlijn per geselecteerde klant.
            FactuurLijn factuurLijn = new FactuurLijn(Convert.ToInt32(txtPrijs.Text), txtProduct.Text, Convert.ToInt32(txtAantal.Text));

            Factuur factuur = (Factuur)lstFactuur.SelectedItem;
            factuur.VoegFactuurToe(Convert.ToInt32(txtPrijs.Text), txtProduct.Text, Convert.ToInt32(txtAantal.Text));


        }

        private void lstFactuurLijn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Zorgen dat wanneer de factuurlijn van de klant geselecteerd is dat het label factuurtotaal
            //het totaal toont van de factuur. Of zo iets in die trend.
            FactuurLijn factuurLijn = (FactuurLijn)lstFactuur.SelectedItem;
            factuurLijn.Tostring();

            Factuur factuur = (Factuur)lstFactuur.SelectedItem;
            lblFactuurTotaal.Text = $"{factuur.BerekenFactuurTotaal()}";
        }
    }
}
