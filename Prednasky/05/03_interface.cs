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
    interface IBod : IVypisovací
    {
        int X { get; set; }
        int Y { get; set; }
        event EventHandler ZmenaSouradnic;
    } 

    class Bod : IBod
    {
        int x, y;
        public int X
        {
            get { return x; }
            set
            {
                if (x != value)
                {
                    x = value;
                    OnZmenaSouradnic(EventArgs.Empty);
                }
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (y != value)
                {
                    y = value;
                    OnZmenaSouradnic(EventArgs.Empty);
                }
            }
        }
        public event EventHandler ZmenaSouradnic;
        public void Vypis()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        protected virtual void OnZmenaSouradnic(EventArgs e)
        {
            EventHandler handler = ZmenaSouradnic;
            if (handler != null) handler(this, e);
        }
    } // konec Bod 

    class Sestava : IVypisovací
    {
        public void Vypis()
        {
            Console.WriteLine("Výpis údajů sestavy");
        }
    }

    class Program
    {
        static void ProvedVypis(IVypisovací iv)
        {
            iv.Vypis();
        }
        static double VzdalenostBodu(IBod bodA, IBod bodB)
        {
            return Math.Sqrt(Math.Pow(bodA.X - bodB.X, 2) + Math.Pow(bodA.Y - bodB.Y, 2));
        }
        static void Main(string[] args)
        {
            Bod bodA = new Bod();
            bodA.X = 10; bodA.Y = 20;
            Bod bodB = new Bod();
            bodB.X = 30; bodB.Y = 40;
            Sestava sestava = new Sestava();
            ProvedVypis(sestava);
            ProvedVypis(bodA);
            ProvedVypis(bodB);
            Console.WriteLine("Vzdálenost bodů je {0}",
            VzdalenostBodu(bodA, bodB));
            Console.ReadKey();
        }
    }
}
