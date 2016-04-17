using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contmp
{
    static class A
    {
        static private int x;
        // void g() { } // Chyba - třída je statická 
        static public int X
        {
            get { return x; }
            set { x = value; }
        }
        public static void f()
        {
            Console.WriteLine("x = " + x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // A a = new A(); // Chyba - nelze vytvořit instanci statické třídy 
            A.X = 10;
            A.f();
            Console.ReadKey();
        }
    } 

}
