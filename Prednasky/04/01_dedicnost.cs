using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class A
    {
        public void f() { Console.WriteLine("Výpis z metody A.f()"); }
        public void g() { Console.WriteLine("Výpis z metody A.g()"); }
    }
    class B : A
    {
        public new void f() // zastiňující metoda
        {
            base.f(); // volá se metoda f() předka
            Console.WriteLine("Výpis z metody B.f()");
        }
        public void g(int i)
        {
            Console.WriteLine("Výpis z metody B.g(int i) => {0}", i);
        } // OK – new se neuvádí - v A je jiná signatura!
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.f();
            // b.base.f(); // Chyba
            ((A)b).f(); // OK - volá se metoda f třídy A
            b.g(); // #1 - v C# OK, v C++ chyba
            b.g(10); // #2 – OK v C# i C++
            Console.ReadLine();
        }
    }

}
