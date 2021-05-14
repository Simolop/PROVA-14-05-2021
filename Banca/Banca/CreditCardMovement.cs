using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public enum Tipo
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }

    public class CreditCardMovement : Movement
    {
        public int NumeroCarta { get; set; }
        public Tipo tipo { get; set; }

        #region COSTRUTTORE

        public CreditCardMovement(int numCarta, Tipo tipocard, decimal importo, DateTime dataMov)
            : base(importo, dataMov)
        {
            NumeroCarta = numCarta;
            tipo = tipocard;
        }

        #endregion

        public override string ToString()
        {
            return $" Numero Carta: {NumeroCarta} - Tipo Carda {tipo} - {base.ToString()}";
        }
    }
}
