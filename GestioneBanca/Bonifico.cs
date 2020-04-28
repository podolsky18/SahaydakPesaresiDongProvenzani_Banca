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
    public partial class Bonifico : Form
    {
        ContoCorrente cc = null;
        public Bonifico()
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

        private void Bonifico_Load(object sender, EventArgs e)
        {
            cc = banca.Get(iban);
            aggiornaElencoCC();
        }

        /// <summary>
        /// aggiorno la listview dei conti correnti
        /// </summary>
        private void aggiornaElencoCC()
        {
            // azzerra la listview
            listCC.Items.Clear();

            // scorro l'elenco dei conti correnti presenti nella banca e aggiungo nella listview
            foreach (var item in banca.ListaContiCorrenti())
            {
                // non visualizzo il conto corrente di quello che fa il bonifico (per non fare un bonifico su se stesso)
                // per cui verifico che iban del conto corrente che aggiungo alla listview sia differente dall'iban 
                // del conto corrente che effettua il bonifico
                if (item.iban != iban)
                {
                    // prendo l'intestatario del conto corrente da poter utilizzare nella visualizzazione
                    var intestatario = item.GetIntestatario();
                    // creo l'oggetto che inserisco nella listview
                    var item2 = new ListViewItem(new[] { item.iban, intestatario.nomeCompleto });
                    listCC.Items.Add(item2);
                }
            }
        }

        /// <summary>
        /// effettuo il bonifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEffettuaBonifico_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // importo del bonifico
                var importo = Convert.ToDouble(txtBonifico.Text);
                // estraggo iban del destinatario dalla selezione attiva della listview
                var ibanDestinatario = items[0].SubItems[0].Text;
                // effettuo il bonifico 
                banca.Bonifico(iban, ibanDestinatario, importo);
                // esco dal dialogo assegnando il result ad ok 
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
