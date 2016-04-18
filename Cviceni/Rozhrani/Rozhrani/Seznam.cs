﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani
{
    class Seznam : ISeznam, IEnumerable
    {
        private int pocet;

        public SeznamPrvek Prvni { get; private set; }
        public SeznamPrvek Posledni { get; private set; }

        public IEnumerable SeznamPrvky {
            get {
                SeznamPrvek prvek = Prvni;
                while (prvek != null)
                {
                    yield return prvek;
                    prvek = prvek.Naslednik;
                }
            } 
        }

        public Seznam() { }

        public Seznam(IEnumerable kolekce)
        {
            foreach (object item in kolekce)
            {
                PridejNaKonec(item);                
            }
        }

        public void PridejNaKonec(object data)
        {
            SeznamPrvek seznamPrvek = new SeznamPrvek(null, Posledni, data);
            if (Posledni != null) Posledni.Naslednik = seznamPrvek;
            else Prvni = seznamPrvek;
            Posledni = seznamPrvek;
            pocet++;
        }

        public void PridejNaZacatek(object data)
        {
            SeznamPrvek seznamPrvek = new SeznamPrvek(Prvni, null, data);
            if (Prvni != null) Prvni.Predchudce = seznamPrvek;
            else Posledni = seznamPrvek;
            Prvni = seznamPrvek;
            pocet++;
        }

        public void PridejPred(SeznamPrvek prvek, SeznamPrvek pozice)
        {
            prvek.Naslednik = pozice;
            prvek.Predchudce = pozice.Predchudce;

            if (pozice.Predchudce != null) pozice.Predchudce.Naslednik = prvek;
            else Prvni = prvek;
            pozice.Predchudce = prvek;
            pocet++;
        }

        public void Serad()
        {
            if (pocet < 2) return;
            SeznamPrvek prvek = Prvni.Naslednik;
            while (prvek != null)
            {
                SeznamPrvek prvek2 = Prvni;
                while (prvek != prvek2)
                {
                    if (((IComparable)prvek.Hodnota).CompareTo(prvek2.Hodnota)
                        < 0)
                    {
                        Vymaz(prvek);
                        PridejPred(prvek, prvek2);
                        break;
                    }
                    prvek2 = prvek2.Naslednik;
                }
                prvek = prvek.Naslednik;
            }
        }

        public void Vymaz(SeznamPrvek prvek)
        {
            if (prvek.Naslednik != null)
                prvek.Naslednik.Predchudce = prvek.Predchudce;
            else
                Posledni = prvek.Predchudce;

            if (prvek.Predchudce != null)
                prvek.Predchudce.Naslednik = prvek.Naslednik;
            else
                Prvni = prvek.Naslednik;
            pocet--;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (SeznamPrvek item in SeznamPrvky)
            {
                yield return item.Hodnota;
            }
        }


        public void Pridej(object prvek)
        {
            PridejNaKonec(prvek);
        }

        public void Vymaz(object prvek)
        {
            foreach (SeznamPrvek item in SeznamPrvky)
            {
                if (item.Hodnota.Equals(prvek))
                {
                    Vymaz(item);
                    return;
                }
            }
        }

        public void VymazVse()
        {
            Prvni = null;
            Posledni = null;
            pocet = 0;
        }

        public void CopyTo(Array array, int index)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (index < 0) throw new ArgumentOutOfRangeException("index");
            if (array.Rank > 1) throw new ArgumentException("Pole je vícerozměrné", "array");
            if (index + pocet > array.Length) throw new ArgumentException("Nedostatečně velké pole", "array");

            foreach (object item in this)
            {
                array.SetValue(item, index++);
            }
        }

        public int Count
        {
            get { return pocet; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

    }
}
