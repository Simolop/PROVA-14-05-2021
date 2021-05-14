using System;

namespace Banca
{
    public abstract class Movement
    {
        #region PROPRIETA'
        public decimal Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        #endregion

        #region COSTRUTTORE

        public Movement (decimal importo, DateTime dataMov)
        {
            Importo = importo;
            DataMovimento = dataMov;
        }

        #endregion

        public override string ToString()
        {
            return $" Importo: {Importo} - Data Movimento: {DataMovimento.ToShortDateString()}";
        }
 
    }
}