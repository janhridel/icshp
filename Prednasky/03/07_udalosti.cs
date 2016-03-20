using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    public delegate void ZmenaSouradnicEventHandler(object sender, EventArgs e);
    class Bod
    {
        private int x;
        private int y;
        public event ZmenaSouradnicEventHandler ZmenaSouradnic;
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
        public Bod(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected virtual void OnZmenaSouradnic(EventArgs e)
        {
            ZmenaSouradnicEventHandler handler = ZmenaSouradnic;
            if (handler != null) handler(this, e);
        }
    }

    class Obrazek
    {
        public static void ZmenaSouradnic(object sender, EventArgs e)
        {
            Console.WriteLine("Došlo ke změně souřadnic bodu");
            Console.WriteLine("Nové souřadnice bodu jsou: x = {0}, y = {1}", (sender as Bod).X, (sender as Bod).Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bod bod = new Bod(10, 20);
            bod.ZmenaSouradnic += new ZmenaSouradnicEventHandler(Obrazek.ZmenaSouradnic);
            // dtto od verze .NET 2.0:
            // bod.ZmenaSouradnic += Obrazek.ZmenaSouradnic;
            bod.X = 30;
            // Chyba - nelze volat událost mimo její třídu:
            // bod.ZmenaSouradnic(typeof(Program), new EventArgs());
            Console.ReadKey();
        }
    }


}
