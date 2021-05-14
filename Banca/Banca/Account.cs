using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class Account
    {
        #region PROPRIETA'

        public int NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Movement> ListaMovimenti { get; } = new List<Movement>();

        #endregion

        #region COSTRUTTORE
        public Account (int numConto, string nomeBanc, decimal saldo, DateTime dataUltimaOp)
        {
            NumeroConto = numConto;
            NomeBanca = nomeBanc;
            Saldo = saldo;
            DataUltimaOperazione = dataUltimaOp;
        }

        #endregion

        #region OVERLOAD

        #endregion

        #region METODI

        public override string ToString()
        {
            return $"{NumeroConto} => Banca: {NomeBanca} - Saldo: {Saldo} - Data dell'ultima operazione: {DataUltimaOperazione}";
        }

        public static string Statement(Account conto)
        {
            foreach (var movim in conto.ListaMovimenti)
            {
                Console.WriteLine(movim.ToString());
            }

            return conto.ToString();
        }


        //movimenti attivi
        public static bool operator +(Account conto, Movement mov)
        {
            conto.ListaMovimenti.Add(mov);
            conto.Saldo += mov.Importo;
            return true;
        }


        //movimenti passivi
        public static bool operator -(Account conto, Movement mov)
        {
            conto.ListaMovimenti.Add(mov);
            conto.Saldo -= mov.Importo;
            return true;
        }

       

        #endregion
    }
}
