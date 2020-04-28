using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBanca.Model
{
    public class ContoCorrenteOnline : ContoCorrente
    {
        private double maxPrelievo { get; set; } // prelievo massimo dal conto corrente 

		/// <summary>
		/// costruttore della classe
		/// </summary>
		/// <param name="maxPrelievo_"></param>
		/// <param name="saldo_"></param>
		/// <param name="maxMovimenti_"></param>
		public ContoCorrenteOnline(double maxPrelievo_, double saldo_, int maxMovimenti_) :
            base(saldo_, maxMovimenti_)
        {
            maxPrelievo = maxPrelievo_;
            online = true; // imposto il flag che indica il conto corrente è di tipo online
        }

        /// <summary>
        /// saldo del conto corrente
        /// </summary>
        /// <returns></returns>
        public double saldoContoCorrente()
        {
            return 0;
        }

        /// <summary>
        /// prelievo di una somma dal conto corrente con verifica di non superare l'importo massimo
        /// </summary>
        /// <param name="sommaDaPrelevare"></param>
        /// <returns></returns>
        public override double Prelievo(double sommaDaPrelevare)
        {
            if (sommaDaPrelevare > maxPrelievo)
            {
                return 0;
            }
            return Prelievo(sommaDaPrelevare);
        }

        /// <summary>
        /// permette di archiviare un bonifico nel conto corrente 
        /// </summary>
        /// <param name="bonifico_"></param>
        public override void Add(Bonifico bonifico_)
        {
            bonifico_.SetOnline();
            Add(bonifico_);
        }
    }
}
