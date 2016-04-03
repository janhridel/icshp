using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    class Vlak
    {
        public void VypisNevirtualni() { Console.WriteLine("Vlak"); }
        public virtual void VypisVirtualni() { Console.WriteLine("Vlak"); }
    }
    class NakladniVlak : Vlak
    {
        public new void VypisNevirtualni()
        { Console.WriteLine("Nakladní vlak"); }
        public override void VypisVirtualni()
        { Console.WriteLine("Nakladní vlak"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vlak vlak1 = new Vlak();
            Vlak vlak2 = new NakladniVlak();
            vlak1.VypisNevirtualni();
            vlak2.VypisNevirtualni();
            vlak1.VypisVirtualni();
            vlak2.VypisVirtualni();
            Console.ReadKey();
        }
    }

}
