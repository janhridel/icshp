using System;
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
    public partial class CeleCisloDialog : Form
    {
        public CeleCisloDialog()
        {
            InitializeComponent();
        }

        public int Cislo { get; set; }

        private void CeleCisloDialog_Load(object sender, EventArgs e)
        {
            celeCisloTextBox.Text = Cislo.ToString();
        }

        private void CeleCisloDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && !e.Cancel)
            {
                int cislo;
                if (!int.TryParse(celeCisloTextBox.Text, out cislo))
                {
                    MessageBox.Show("Neplatné číslo", "chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void CeleCisloDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Cislo = int.Parse(celeCisloTextBox.Text);
            }
        }


    }
}
