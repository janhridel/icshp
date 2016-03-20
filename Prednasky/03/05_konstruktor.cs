using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    class Matice
    {
        double[,] a; public Matice(int m, int n) { a = new double[m, n]; }
        public Matice(int m, int n, double hodnota)
            : this(m, n)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++) a[i, j] = hodnota;
            }
        }
        public void Výpis() { ... }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matice matice = new Matice(3, 2);
            matice.Výpis();
            matice = new Matice(3, 2, 10.54);
            matice.Výpis();
            // Matice matice2 = new Matice(); 
            // Chyba - třída nemá implicitní konstruktor 
        }
    } 



}
