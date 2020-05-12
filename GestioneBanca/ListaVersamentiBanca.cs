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
    public partial class ListaVersamentiBanca : Form
    {
        public ListaVersamentiBanca()
        {
            InitializeComponent();
        }

        private Model.Banca banca = null;

        /// <summary>
        /// elenco dei movimenti giornalieri 
        /// </summary>
        private Dictionary<string, List<string>> elencoCCPerData = new Dictionary<string, List<string>>();

        /// <summary>
        /// passo l'istanza della banca che utilizzerò per le operazioni 
        /// </summary>
        /// <param name="banca_"></param>
        public void SetBanca(Model.Banca banca_)
        {
            banca = banca_;
        }

        /// <summary>
        /// ha il caricamento del dialogo, viene generato l'evento load che utilizzo per inizializzare le componenti del dialogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListaVersamentiBanca_Load(object sender, EventArgs e)
        {

            // prendo l'elenco dei CC della banca
            var ccs = banca.ListaContiCorrenti();

            foreach (var cc in ccs)
            {
                // prende l'elenco dei movimenti del CC raggruppati per data
                var elencoPerData = cc.GetMovimentiPerData();

                // ciclo l'elenco e prende la chiave del dictionary che corrisponde alla data del movimento/i
                foreach (var item in elencoPerData)
                {
                    // verifico se nell'elenco movimentiPerData è già stata inserita 
                    // una data corrispondente alla data del movimento che devo inserire
                    if (elencoCCPerData.ContainsKey(item.Key))
                    {
                        List<string> items;

                        // recupera l'elenco dei movimenti per quella data 
                        if (elencoCCPerData.TryGetValue(item.Key, out items))
                        {
                            // aggiunge il nuovo movimento 
                            items.Add(cc.iban);
                        }
                    }
                    else
                    {
                        // creo un elenco movimenti nuovo
                        var items = new List<string>();
                        // aggiungo il movimento
                        items.Add(cc.iban);
                        // aggiungo all'elenco movimentiPerData l'elenco movimento associandolo alla data
                        elencoCCPerData.Add(item.Key, items);
                    }
                }
            }

            foreach (var item in elencoCCPerData)
            {
                cbDateMovimenti.Items.Add(item.Key);
            }
        }

        /// <summary>
        /// aggiorno elenco movimenti
        /// </summary>
        /// <param name="elencoIban">elenco dei conto correnti che contengono movimenti alla data specificata</param>
        /// <param name="dataGiornaliera">data specificata di cui voglio vedere i movimenti</param>
        private void aggiornaElenco(List<string> elencoIban, string dataGiornaliera)
        {
            // azzerra la listview
            listMovimenti.Items.Clear();

            // scorro l'elenco dei CC
            foreach (var iban in elencoIban)
            {
                // recupero il CC dalla banca
                var cc = banca.Get(iban);

                // recupero l'elenco per data del CC selezionato 
                var elencoPerData = cc.GetMovimentiPerData();

                // di supporto
                List<Movimento> items;

                // recupera l'elenco dei movimenti per quella data 
                if (elencoPerData.TryGetValue(dataGiornaliera, out items))
                {
                    // scorro i movimenti del CC nella data selezionata
                    foreach (var movimento in items)
                    {
                        // prendo il tipo e l'importo dal movimento e lo aggiungo alla listview
                        var item2 = new ListViewItem(new[] {
                            iban,
                            movimento.GetData().ToShortDateString() +" "+ movimento.GetData().ToShortTimeString(),
                            movimento.GetTipo(),
                            movimento.GetImporto().ToString()
                        });
                        listMovimenti.Items.Add(item2);
                    }
                }
            }
        }

        private void CbDateMovimenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox1 = (ComboBox)sender;
            string dataSelezionata = (string)ComboBox1.SelectedItem;

            // prendo l'elenco dei CC che hanno i movimenti nella data selezionata
            if (elencoCCPerData.ContainsKey(dataSelezionata))
            {
                List<string> items;

                // recupera l'elenco dei movimenti per quella data 
                if (elencoCCPerData.TryGetValue(dataSelezionata, out items))
                {
                    aggiornaElenco(items, dataSelezionata);
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
