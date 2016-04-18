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
    public partial class Form1 : Form
    {
        private Hraci hraci = new Hraci();
        public Form1()
        {
            InitializeComponent();
        }

        private void NastavHrace(Hrac hrac, ListViewItem lvi)
        {
            lvi.SubItems[0].Text = hrac.Jmeno;
            lvi.SubItems[1].Text = FotbalovyKlubInfo.DejNazev(hrac.Klub);
            lvi.SubItems[2].Text = hrac.GolPocet.ToString();
        }

        private void pridejButton_Click(object sender, EventArgs e)
        {
            using (HracDialog dlg = new HracDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    hraci.Pridej(dlg.Hrac);
                    ListViewItem lvi = new ListViewItem(new string[3]);
                    NastavHrace(dlg.Hrac, lvi);
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void vymazButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Není vybrán žádný hráč", "chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView1.BeginUpdate();
            try
            {
                while (listView1.SelectedIndices.Count > 0)
                {
                    hraci.Vymaz(listView1.SelectedIndices[0]);
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                }
            }
            finally
            {
                listView1.EndUpdate();
            }
        }

        private void upravButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Není vybrán jeden hráč", "chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (HracDialog dlg = new HracDialog())
            {
                int selectedIndex = listView1.SelectedIndices[0];
                dlg.Hrac = hraci.DejHrace(selectedIndex);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    NastavHrace(dlg.Hrac, listView1.SelectedItems[0]);
                }
            }
        }

        private void konecProgramu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nejlepsiButton_Click(object sender, EventArgs e)
        {
            FotbalovyKlub[] kluby;
            int golPocet;
            hraci.NajdiNejlepsiKluby(out kluby, out golPocet);
            using (NejlepsiKlubyDialog dlg = new NejlepsiKlubyDialog())
            {
                dlg.Kluby = kluby;
                dlg.GolPocet = golPocet;
                dlg.ShowDialog();
            }
        }

        void hraci_PocetZmenen(object sender, PocetEventArgs e)
        {
            protokolTextBox.Text += "Změněn počet hráčů. Původní počet: " + e.Pocet + ", nový počet: " + hraci.Pocet + "\r\n";
        }

        private void registrovatButton_Click(object sender, EventArgs e)
        {
            
            hraci.PocetZmenen += new PocetZmenenEventHandler(hraci_PocetZmenen);
            protokolTextBox.Text += "Registrován handler události\r\n";
        }

        private void zrusitButton_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen -= new PocetZmenenEventHandler(hraci_PocetZmenen);
            protokolTextBox.Text += "Handler události zrušen\r\n";
        }

        private void protokolTextBox_TextChanged(object sender, EventArgs e)
        {
            protokolTextBox.SelectionStart = protokolTextBox.Text.Length;
            protokolTextBox.SelectionLength = 0;
            protokolTextBox.ScrollToCaret();
        }

    }
}
