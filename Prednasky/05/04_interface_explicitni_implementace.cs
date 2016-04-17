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
        void IVypisovací.Vypis() // explicitní implementace
        {
            Console.WriteLine("Výpis údajů třídy B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Vypis(); // metoda A.Vypis
            ((IVypisovací)b).Vypis(); // metoda B.Vypis
            Console.ReadKey();
        }
    }
}
