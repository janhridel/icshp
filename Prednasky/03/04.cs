using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    class TridaA
    {
        public int x, y;
        public TridaA(int x, int y) { this.x = x; this.y = y; }
    }
    struct StrukturaB
    {
        public int x, y;
        public StrukturaB(int x, int y) { this.x = x; this.y = y; }
    }
    class Program
    {
        static void f(TridaA a1, TridaA a2, StrukturaB b)
        {
            a1.x = b.x; // složka x se ve skutečném parametru změní
            a2 = a1; // skutečný parametr se nezmění
            b.y = a1.y; // skutečný parametr se nezmění
        }
        static void Main(string[] args)
        {
            TridaA a1 = new TridaA(10, 20), a2 = new TridaA(30, 40);
            StrukturaB b = new StrukturaB(50, 60);
            f(a1, a2, b);
            // změna pouze u složky a1.x = 50
        }
    }


}
