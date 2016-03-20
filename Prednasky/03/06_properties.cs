using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    class KomplexCislo
    {
        private int real;
        private int imag;

        public KomplexCislo(int real, int imag)
        {
            this.real = real;
            this.imag = imag;
        }
        public int Real
        {
            get { return real; }
            set { real = value; }
        }
        public int Imag
        {
            get { return imag; }
            set { imag = value; }
        }
        public double Abs
        {
            get { return Math.Sqrt(Real * Real + Imag * Imag); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KomplexCislo kc = new KomplexCislo(10, 20);
            Console.WriteLine("Absolutní hodnota čísla ({0} + {1}i) je {2:F1}", kc.Real, kc.Imag, kc.Abs);
            kc.Real = 3;
            kc.Imag = 4;
            Console.WriteLine("Absolutní hodnota čísla ({0} + {1}i) je {2:F1}", kc.Real, kc.Imag, kc.Abs);
            Console.ReadKey();
        }
    } 

}
