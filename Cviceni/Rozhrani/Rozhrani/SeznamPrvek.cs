using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani
{
    class SeznamPrvek
    {
        public SeznamPrvek Naslednik { get; internal set; }
        public SeznamPrvek Predchudce { get; internal set; }
        public object Hodnota { get; set; }

        internal SeznamPrvek(SeznamPrvek naslednik, SeznamPrvek predchudce, object hodnota)
        {
            this.Naslednik = naslednik;
            this.Predchudce = predchudce;
            this.Hodnota = hodnota;
        }
    }
}
