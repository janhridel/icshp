using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contmp
{
    interface IVypisovací
    {
        void Vypis();
    }
    class A : IVypisovací
    {
        public void Vypis()
        {
            Console.WriteLine("Výpis údajů třídy A");
        }
    }
    class B : A, IVypisovací
    {
        public new void Vypis()
        {
            Console.WriteLine("Výpis údajů třídy B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new B();
            IVypisovací ia = a;
            IVypisovací ib = b;
            a.Vypis();
            b.Vypis();
            ia.Vypis();
            ib.Vypis();
            Console.ReadKey();
        }
    } 
}
