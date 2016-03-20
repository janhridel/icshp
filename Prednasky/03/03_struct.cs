using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    struct Struktura
    {
        public int x;
        public void SetX(int x) { this.x = x; }
    }
    class Trida
    {
        public readonly int[] pole = new int[] { 1, 2 };
        public readonly Struktura b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trida a = new Trida();
            a.pole[0] = 5; // OK 
            //a.b.x = 20; // Chyba 
            a.b.SetX(20); // OK 
        }
    } 

}
