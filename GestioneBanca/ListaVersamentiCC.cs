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
    public partial class ListaVersamentiCC : Form
    {
        ContoCorrente cc = null;
        Dictionary<string, List<Movimento>> elencoPerData;
        public ListaVersamentiCC()
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
        private void ListaVersamentiCC_Load(object sender, EventArgs e)
        {
            // trovo tramite iban il conto corrente su cui voglio effettuare la visualizzazione dello stato
            // come già scritto in altri commenti iban è selezionato da una listview per cui non può essere sbagliato
            cc = banca.Get(iban);
            // visualizzo il saldo del conto corrente
            lblSaldo.Text = cc.Saldo().ToString();

            // prende l'elenco dei movimenti del CC raggruppati per data
            elencoPerData = cc.GetMovimentiPerData();

            // ciclo l'elenco e prende la chiave del dictionary che corrisponde alla data del movimento/i
            foreach (var item in elencoPerData)
            {
                // aggiunge la data alla comboBox di visualizzazione
                cbDateMovimenti.Items.Add(item.Key);
            }
        }

        /// <summary>
        /// aggiorno elenco dei movimento del conto corrente 
        /// </summary>
        private void aggiornaElencoCC(List<Movimento> movimenti)
        {
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

        private void CbDateMovimenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox1 = (ComboBox)sender;

            string dataSelezionata = (string)ComboBox1.SelectedItem;

            if (elencoPerData.ContainsKey(dataSelezionata))
            {
                List<Movimento> items;

                // recupera l'elenco dei movimenti per quella data 
                if (elencoPerData.TryGetValue(dataSelezionata, out items))
                {
                    aggiornaElencoCC(items);
                }
            }
            else
            {
                // azzerra la listview
                listMovimenti.Items.Clear();
            }
        }
    }
}
