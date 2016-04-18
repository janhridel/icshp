using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LigaMistru
{
    public partial class HracDialog : Form
    {
        private class FotbalovyKlubNazev
        {
            public FotbalovyKlub Klub { get; set; }
            public string Nazev { get; set; }
        }

        public Hrac Hrac { get; set; }

        public HracDialog()
        {
            InitializeComponent();
            jmenoTextBox.MaxLength = Hrac.MaxJmeno;
            foreach (FotbalovyKlub item in Enum.GetValues(typeof(FotbalovyKlub)))
            {
                if (item != FotbalovyKlub.None)
                {
                    FotbalovyKlubNazev klubNazev = new FotbalovyKlubNazev();
                    klubNazev.Klub = item;
                    klubNazev.Nazev = FotbalovyKlubInfo.DejNazev(item);

                    klubComboBox.Items.Add(klubNazev);
                }
            }
            klubComboBox.DisplayMember = "Nazev";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Hrac == null)
            {
                jmenoTextBox.Clear();
                golyTextBox.Clear();
                klubComboBox.SelectedIndex = -1;
            }
            else
            {
                jmenoTextBox.Text = Hrac.Jmeno;
                golyTextBox.Text = Hrac.GolPocet.ToString();
                foreach (FotbalovyKlubNazev item in klubComboBox.Items)
                {
                    if (item.Klub == Hrac.Klub)
                    {
                        klubComboBox.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void ChyboveHlaseni(string text, Control control)
        {
            MessageBox.Show(text,"Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
            return;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (DialogResult == DialogResult.Cancel || e.Cancel)
                return;
            
            e.Cancel = true;

            if (string.IsNullOrEmpty(jmenoTextBox.Text))
            {
                ChyboveHlaseni("Jméno není vyplněno",jmenoTextBox);
                return;
            }
            if (klubComboBox.SelectedItem == null)
            {
                ChyboveHlaseni("Není vybrán klub", klubComboBox);
                return;
            }
            if (string.IsNullOrEmpty(golyTextBox.Text))
            {
                ChyboveHlaseni("Není vyplněn počet gólů",golyTextBox);
                return;
            }

            int golPocet;
            if (!int.TryParse(golyTextBox.Text, out golPocet) || golPocet < 0)
            {
                ChyboveHlaseni("Neplatný počet gólů", golyTextBox);
                return;
            }
            e.Cancel = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
            if (Hrac == null)
            {
                Hrac = new Hrac();
            }
            Hrac.Jmeno = jmenoTextBox.Text;
            Hrac.GolPocet = int.Parse(golyTextBox.Text);
            Hrac.Klub = ((FotbalovyKlubNazev)klubComboBox.SelectedItem).Klub;
        }
    }
}
