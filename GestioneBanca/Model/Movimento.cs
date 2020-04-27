using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBanca.Model
{
    public class Movimento
    {
        protected DateTime data { get; set; } // data di quando è stato fatto il movimento
        protected string Tipo { get; set; }
        protected double Importo { get; set; } // importo della transazione

        /// <summary>
        /// costruttore
        /// </summary>
        /// <param name="data_"></param>
        public Movimento(DateTime data_, string tipo_, double importo_)
        {
            data = data_;
            Tipo = tipo_;
            Importo = importo_;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public double GetImporto()
        {
            return Importo;
        }

        public DateTime GetData()
        {
            return data;
        }
    }
}
