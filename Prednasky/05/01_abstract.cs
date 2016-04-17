using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contmp
{
    abstract class A
    {
        public abstract int X { get; set; }
        public abstract void f();
    }
    abstract class B : A // musí být abstraktní
    {
        private int x;
        public override int X
        {
            get { return x; }
            set { x = value; }
        }
        public void g() { Console.WriteLine("Metoda g třídy B"); }
    }
    class C : B
    {
        public override void f() { Console.WriteLine("Metoda f třídy C"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new C();
            a.X = 10; // zavolá přístupovou metodu vlastnosti X třídy B
            a.f(); // zavolá metodu f() třídy C
            Console.ReadKey();
        }
    }

}