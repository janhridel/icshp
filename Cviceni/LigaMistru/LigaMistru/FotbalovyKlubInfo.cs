using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LigaMistru
{
    static class FotbalovyKlubInfo
    {
        public static readonly int Pocet;
        static FotbalovyKlubInfo()
        {
            Pocet = Enum.GetValues(typeof(FotbalovyKlub)).Length;
        }

        public static string DejNazev(FotbalovyKlub klub)
        {
            switch (klub)
            {
                case FotbalovyKlub.None:
                    return string.Empty;
                case FotbalovyKlub.Barcelona:
                case FotbalovyKlub.Arsenal:
                case FotbalovyKlub.Chelsea:
                    return klub.ToString();
                case FotbalovyKlub.RealMadrid:
                    return "Real Madrid";
                case FotbalovyKlub.FCPorto:
                    return "FC Porto";
                default: return null;
            }
        }

        public static int DejIndex(FotbalovyKlub klub)
        {
            return (int)klub;
        }

        public static FotbalovyKlub DejKlub(int index)
        {
            return (FotbalovyKlub)index;
        }
    }
}
