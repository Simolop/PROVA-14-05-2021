using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class TransfertMovement : Movement
    {
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        #region COSTRUTTORE
        public TransfertMovement(string bancaOr, string bancaDest, decimal importo, DateTime dataMov)
            : base(importo, dataMov)
        {
            BancaOrigine = bancaOr;
            BancaDestinazione = bancaDest;
        }
        #endregion

        public override string ToString()
        {
            return $"{base.ToString()} - Banca d'origine: {BancaOrigine} - Banca di destinazione: {BancaDestinazione}";
        }
    }
}
