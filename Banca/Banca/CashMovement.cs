using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class CashMovement : Movement
    {
        public string Esecutore { get; set; }

        #region COSTRUTTORE

        public CashMovement(string esecutore, decimal importo, DateTime dataMov)
            :base(importo, dataMov)
        {
            Esecutore = esecutore;
        }

        #endregion

        public override string ToString()
        {
            return $" Esecutore: {Esecutore} - {base.ToString()}";
        }
    }
}
