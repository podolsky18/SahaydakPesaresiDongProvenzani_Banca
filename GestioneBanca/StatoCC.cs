using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioneBanca.Model;

namespace GestioneBanca
{
    public partial class StatoCC : Form
    {
        ContoCorrente cc = null;
        public StatoCC()
        {
            InitializeComponent();
        }

        private Banca banca = null;
        private string iban = "";
        /// <summary>
        /// passo l'istanza della banca che utilizzerò per le operazioni 
        /// </summary>
        /// <param name="banca_"></param>
        public void SetBanca(Banca banca_)
        {
            banca = banca_;
        }

        public void SetIban(string iban_)
        {
            iban = iban_;
        }

        private void StatoCC_Load(object sender, EventArgs e)
        {
            cc = banca.Get(iban);
            lblSaldo.Text = cc.Saldo().ToString();
            aggiornaElencoCC();
        }

        /// <summary>
        /// aggiorno elenco dei movimento del conto corrente 
        /// </summary>
        private void aggiornaElencoCC()
        {
            var movimenti = cc.GetMovimenti();
            listMovimenti.Items.Clear();
            foreach (var movimento in movimenti)
            {
                // prendo il tipo e l'importo dal movimento e lo aggiungo alla listview
                var item2 = new ListViewItem(new[] { movimento.GetData().ToShortDateString() +" "+ movimento.GetData().ToShortTimeString(), movimento.GetTipo(), movimento.GetImporto().ToString()});
                listMovimenti.Items.Add(item2);
            }
        }
    }
}
