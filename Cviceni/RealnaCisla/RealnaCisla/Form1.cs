using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealnaCisla
{
    public partial class Form1 : Form
    {

        private ArrayList cisla = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void naplnListBox()
        {
            cislaListBox.BeginUpdate();
            try
            {
                cislaListBox.Items.Clear();
                foreach (double item in cisla)
                {
                    // https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
                    // "N" - Number
                    // "C" - Currency
                    cislaListBox.Items.Add(item.ToString("N"));
                }
            }
            finally
            {
                cislaListBox.EndUpdate();
            }
        }

        private void ulozTxtSoubor(string soubor)
        {
            using(StreamWriter sw = new StreamWriter(File.Open(soubor,
                FileMode.Create, FileAccess.Write)))
            {
                foreach (double item in cisla)
                {
                    sw.WriteLine(item.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        private void ulozBinSoubor(string soubor)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create(soubor)))
            {
                foreach (double item in cisla)
                {
                    bw.Write(item);
                }
            }
        }

        private void nactiTxtSoubor(string soubor)
        {
            string retezec;
            using (StreamReader sr = new StreamReader(File.OpenRead(soubor)))
            {
                while (!sr.EndOfStream)
                {
                    retezec = sr.ReadLine();
                    cisla.Add(double.Parse(retezec, CultureInfo.InvariantCulture));
                }
            }
        }

        private void nactiBinSoubor(string soubor)
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(soubor)))
            {
                int pocet;
                pocet = (int)(br.BaseStream.Length / 8);
                cisla.Capacity = pocet;
                for (int i = 0; i < pocet; i++)
                {
                    cisla.Add(br.ReadDouble());
                }
            }
        }

        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    default:
                    case 1:
                        ulozTxtSoubor(saveFileDialog.FileName);
                        break;
                    case 2:
                        ulozBinSoubor(saveFileDialog.FileName);
                        break;
                }

            }
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cisla.Clear();
                try
                {
                    switch (openFileDialog.FilterIndex)
                    {
                        case 1:
                            nactiTxtSoubor(openFileDialog.FileName);
                            break;
                        case 2:
                            nactiBinSoubor(openFileDialog.FileName);
                            break;
                    }
                }
                catch (Exception)
                {
                    cisla.Clear();
                    throw;
                }
                naplnListBox();
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int pocet = 20;
            const int minHodnota = 100;
            const int maxHodnota = 10000;

            cisla.Clear();
            cisla.Capacity = pocet;
            Random rnd = new Random();
            for (int i = 0; i < pocet; i++)
            {
                cisla.Add(rnd.NextDouble() * (maxHodnota - minHodnota) + minHodnota);
            }
            naplnListBox();
        }

        private void výchozíWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture =
                        InputLanguage.DefaultInputLanguage.Culture;
            naplnListBox();
        }

        private void češtinaČeskáRepublikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CultureInfo seznam
            // https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo(vs.71).aspx
            Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");
            naplnListBox();
        }

        private void angličtinaVelkáBritánieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            naplnListBox();
        }

        private void angličtinaSpojenéStátyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            naplnListBox();
        }

        private void portugalštinaPortugalskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-PT");
            naplnListBox();
        }

        private void portugalštinaBrazílieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            naplnListBox();
        }
    }
}
