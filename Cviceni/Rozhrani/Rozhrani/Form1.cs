using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozhrani
{
    public partial class Form1 : Form
    {
        IntSeznam intSeznam = new IntSeznam();

        private void naplnListBox(IEnumerable kolekce)
        {
            celaCislaListBox.BeginUpdate();
            try
            {
                celaCislaListBox.Items.Clear();
                foreach (int item in kolekce)
                {
                    celaCislaListBox.Items.Add(item);
                }
            }
            finally
            {
                celaCislaListBox.EndUpdate();
            }
            pocetLabel.Text = celaCislaListBox.Items.Count.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void přidatNaZačátekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CeleCisloDialog dlg = new CeleCisloDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    intSeznam.PridejNaZacatek(dlg.Cislo);
                    celaCislaListBox.Items.Insert(0, dlg.Cislo);
                }
            }
            pocetLabel.Text = celaCislaListBox.Items.Count.ToString();
        }

        private void přidatNaKonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CeleCisloDialog dlg = new CeleCisloDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    intSeznam.PridejNaKonec(dlg.Cislo);
                    celaCislaListBox.Items.Add(dlg.Cislo);
                }
            }
            pocetLabel.Text = celaCislaListBox.Items.Count.ToString();
        }

        private void generovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                intSeznam.PridejNaKonec(rnd.Next(30));
            }
            naplnListBox(intSeznam);
        }

        private void vymazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (celaCislaListBox.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Nejsou vybrány prvky k odstranění!",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            celaCislaListBox.BeginUpdate();
            try
            {
                while (celaCislaListBox.SelectedItem != null)
                {
                    intSeznam.Vymaz((int)celaCislaListBox.SelectedItems[0]);
                    celaCislaListBox.Items.RemoveAt(celaCislaListBox.SelectedIndices[0]);
                }
            }
            finally
            {
                celaCislaListBox.EndUpdate();
            }
            pocetLabel.Text = celaCislaListBox.Items.Count.ToString();
        }

        private void OdstranDuplicitu(ISeznam seznam)
        {
            Seznam pomSeznam = new Seznam();
            int index1 = 0, index2;
            foreach (var item in seznam)
            {
                index2 = 0;
                foreach (var item2 in seznam)
                {
                    if (item.Equals(item2) && index1 < index2)
                    {
                        pomSeznam.PridejNaKonec(item);
                    }
                    index2++;
                }
                index1++;
            }

            foreach (var item in pomSeznam)
            {
                seznam.Vymaz(item);
            }
        }

        private void vymazatDuplicitníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdstranDuplicitu(intSeznam);
            naplnListBox(intSeznam);
        }

        private void seřaďToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intSeznam.Serad();
            naplnListBox(intSeznam);
        }

        private void konecProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Opravdu si přejete ukončit aplikaci?","",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
