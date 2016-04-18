using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani
{
    interface ISeznam : ICollection
    {
        void Pridej(object prvek);
        void Vymaz(object prvek);
        void VymazVse();

    }
}
