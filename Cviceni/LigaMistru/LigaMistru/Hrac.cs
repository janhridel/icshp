using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LigaMistru
{
    public class Hrac
    {
   #region Datové složky
        public const int MaxJmeno = 30;
        private string jmeno;
        private FotbalovyKlub klub;
   #endregion
        
#region Vlastnosti
        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length > MaxJmeno) jmeno = value.Substring(0, MaxJmeno);
                else jmeno = value;
            }
        }
        public FotbalovyKlub Klub
        {
            get { return klub; }
            set
            {
                if (Enum.IsDefined(value.GetType(), value)) klub = value;
                else klub = FotbalovyKlub.None;
            }
        }

        public int GolPocet { get; set; }
        
#endregion

    }
}
