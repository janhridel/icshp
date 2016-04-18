using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
 * Je dán výčtový typ FotbalovyKlub s konstantami:
 * None, Barcelona, Arsenal, Chelsea, Real Madrid, FC Porto
 * Je dána statická třída FotbalovyKlubInfo, poskytující informace
 * k výčtovému typu FotbalovyKlub:
 * - readonly datová složka Pocet - počet výčtových konstant
 * - metoda DejNazev - vrací název výčtové konstanty
 * Je dána třída Hrac:
 * - konstantu MaxJmeno - maximální možná délka jména
 * - vlastnost Jmeno
 * - vlastnost Klub
 * - vlastnost GolPocet
 * Je dána třída Hraci, která zapouzdřuje pole hráčů s implicitní kapacitou
 * - vlastnost Pocet - kolik je hracu v poli
 * - metoda Pridej
 * - metoda Vymaz
 * - metoda DejHrace
 * - metoda NajdiNejlepsiKluby(kluby, golPocet) - hledá kluby s největším
 * počtem nastřílených gólů. V parametru kluby vrací pole klubů. V parametru
 * golPocet vrací počet gólů.
 * - udalost PocetZmenen - vyvolá se, pokud dojde ke změně počtu hráčů. Parametrem
 * události bude původní počet hráčů.
 * Formulářová aplikace bude obsahovat tyto prvky
 * - seznam hráčů
 * - tláčítka Přidat, Vymazat, Upravit, Nejlepší klub, Registrovat (událost),
 *   Zrušit registraci, Konec
 *   
 * 
 */
namespace LigaMistru
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
