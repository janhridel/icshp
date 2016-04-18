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
    public partial class NejlepsiKlubyDialog : Form
    {
        public int GolPocet { get; set; }
        public FotbalovyKlub[] Kluby { get; set; }

        public NejlepsiKlubyDialog()
        {
            InitializeComponent();
        }

        private void NejlepsiKlubyDialog_Load(object sender, EventArgs e)
        {
            golPocetTextBox.Text = GolPocet.ToString();
            foreach (var item in Kluby)
            {
                klubyListBox.Items.Add(FotbalovyKlubInfo.DejNazev(item));
            }
        }

    }
}
