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

        private Model.Banca banca = null;
        private string iban = "";
        /// <summary>
        /// passo l'istanza della banca che utilizzerò per le operazioni 
        /// </summary>
        /// <param name="banca_"></param>
        public void SetBanca(Model.Banca banca_)
        {
            banca = banca_;
        }

        public void SetIban(string iban_)
        {
            iban = iban_;
        }

        /// <summary>
        /// ha il caricamento del dialogo, viene generato l'evento load che utilizzo per inizializzare le componenti del dialogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatoCC_Load(object sender, EventArgs e)
        {
            // trovo tramite iban il conto corrente su cui voglio effettuare la visualizzazione dello stato
            // come già scritto in altri commenti iban è selezionato da una listview per cui non può essere sbagliato
            cc = banca.Get(iban);
            // visualizzo il saldo del conto corrente
            lblSaldo.Text = cc.Saldo().ToString();
            // aggiorno l'elenco
            aggiornaElencoCC();
        }

        /// <summary>
        /// aggiorno elenco dei movimento del conto corrente 
        /// </summary>
        private void aggiornaElencoCC()
        {
            // prende i movimenti del conto corrente
            var movimenti = cc.GetMovimenti();
            // azzerra la listview
            listMovimenti.Items.Clear();

            // scorre i movimenti del conto corrente
            foreach (var movimento in movimenti)
            {
                // prendo il tipo e l'importo dal movimento e lo aggiungo alla listview
                var item2 = new ListViewItem(new[] {
                    movimento.GetData().ToShortDateString() +" "+ movimento.GetData().ToShortTimeString(),
                    movimento.GetTipo(),
                    movimento.GetImporto().ToString()
                });
                listMovimenti.Items.Add(item2);
            }
        }
    }
}
