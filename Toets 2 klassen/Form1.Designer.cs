namespace Toets_2_klassen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMaakFactuurAan = new Button();
            txtFactuurID = new TextBox();
            txtNaamKlant = new TextBox();
            txtKlantNummer = new TextBox();
            lstFactuur = new ListBox();
            label4 = new Label();
            label5 = new Label();
            l = new Label();
            label7 = new Label();
            label8 = new Label();
            btnMaakFactuurLijnAan = new Button();
            lstFactuurLijn = new ListBox();
            txtProduct = new TextBox();
            txtAantal = new TextBox();
            txtPrijs = new TextBox();
            lblFactuurTotaal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "FactuurID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 79);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Naam klant:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 123);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Klantnummer:";
            // 
            // btnMaakFactuurAan
            // 
            btnMaakFactuurAan.Location = new Point(142, 170);
            btnMaakFactuurAan.Name = "btnMaakFactuurAan";
            btnMaakFactuurAan.Size = new Size(151, 29);
            btnMaakFactuurAan.TabIndex = 3;
            btnMaakFactuurAan.Text = "Maak factuur aan";
            btnMaakFactuurAan.UseVisualStyleBackColor = true;
            btnMaakFactuurAan.Click += btnMaakFactuurAan_Click;
            // 
            // txtFactuurID
            // 
            txtFactuurID.Location = new Point(142, 39);
            txtFactuurID.Name = "txtFactuurID";
            txtFactuurID.Size = new Size(125, 27);
            txtFactuurID.TabIndex = 4;
            // 
            // txtNaamKlant
            // 
            txtNaamKlant.Location = new Point(142, 79);
            txtNaamKlant.Name = "txtNaamKlant";
            txtNaamKlant.Size = new Size(125, 27);
            txtNaamKlant.TabIndex = 5;
            // 
            // txtKlantNummer
            // 
            txtKlantNummer.Location = new Point(142, 123);
            txtKlantNummer.Name = "txtKlantNummer";
            txtKlantNummer.Size = new Size(125, 27);
            txtKlantNummer.TabIndex = 6;
            // 
            // lstFactuur
            // 
            lstFactuur.FormattingEnabled = true;
            lstFactuur.Location = new Point(91, 231);
            lstFactuur.Name = "lstFactuur";
            lstFactuur.Size = new Size(150, 104);
            lstFactuur.TabIndex = 7;
            lstFactuur.SelectedIndexChanged += lstFactuur_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(35, 9);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Factuur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(535, 9);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Factuurlijn";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(535, 39);
            l.Name = "l";
            l.Size = new Size(63, 20);
            l.TabIndex = 10;
            l.Text = "Product:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(535, 79);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 11;
            label7.Text = "Aantal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 123);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 12;
            label8.Text = "Prijs:";
            // 
            // btnMaakFactuurLijnAan
            // 
            btnMaakFactuurLijnAan.Location = new Point(535, 177);
            btnMaakFactuurLijnAan.Name = "btnMaakFactuurLijnAan";
            btnMaakFactuurLijnAan.Size = new Size(217, 29);
            btnMaakFactuurLijnAan.TabIndex = 13;
            btnMaakFactuurLijnAan.Text = "Maak factuurlijn aan";
            btnMaakFactuurLijnAan.UseVisualStyleBackColor = true;
            btnMaakFactuurLijnAan.Click += button1_Click;
            // 
            // lstFactuurLijn
            // 
            lstFactuurLijn.FormattingEnabled = true;
            lstFactuurLijn.Location = new Point(602, 231);
            lstFactuurLijn.Name = "lstFactuurLijn";
            lstFactuurLijn.Size = new Size(150, 104);
            lstFactuurLijn.TabIndex = 14;
            lstFactuurLijn.SelectedIndexChanged += lstFactuurLijn_SelectedIndexChanged;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(641, 32);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 27);
            txtProduct.TabIndex = 15;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(641, 76);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 16;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(641, 120);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 17;
            // 
            // lblFactuurTotaal
            // 
            lblFactuurTotaal.AutoSize = true;
            lblFactuurTotaal.Location = new Point(86, 409);
            lblFactuurTotaal.Name = "lblFactuurTotaal";
            lblFactuurTotaal.Size = new Size(0, 20);
            lblFactuurTotaal.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFactuurTotaal);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(lstFactuurLijn);
            Controls.Add(btnMaakFactuurLijnAan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(l);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstFactuur);
            Controls.Add(txtKlantNummer);
            Controls.Add(txtNaamKlant);
            Controls.Add(txtFactuurID);
            Controls.Add(btnMaakFactuurAan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMaakFactuurAan;
        private TextBox txtFactuurID;
        private TextBox txtNaamKlant;
        private TextBox txtKlantNummer;
        private ListBox lstFactuur;
        private Label label4;
        private Label label5;
        private Label l;
        private Label label7;
        private Label label8;
        private Button btnMaakFactuurLijnAan;
        private ListBox lstFactuurLijn;
        private TextBox txtProduct;
        private TextBox txtAantal;
        private TextBox txtPrijs;
        private Label lblFactuurTotaal;
    }
}
