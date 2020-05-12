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
    public partial class Banca : Form
    {
        /// <summary>
        /// banca su cui farò le operazioni..conti e bonifici..
        /// </summary>
        private Model.Banca banca = null;
        public Banca()
        {
            InitializeComponent();

            // inizializzo la banca su cui farò le operazioni di creazione conti e bonifici..
            banca = new Model.Banca("Banca Malatestiana", "Via Pinco Pallino, 22");
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
                // prendo l'intestatario del conto corrente da poter utilizzare nella visualizzazione
                var intestatario = item.GetIntestatario();
                // creo l'oggetto che inserisco nella listview
                var item2 = new ListViewItem(new[] { item.iban, intestatario.nomeCompleto });
                listCC.Items.Add(item2);
            }
        }

        /// <summary>
        /// crea conto corrente nella banca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // istanzio la form
            using (var modal = new CreaCC())
            {
                // passo l'istanza della banca
                modal.SetBanca(banca);
                // chiamo la form
                modal.ShowDialog();

                if (modal.DialogResult == DialogResult.OK)
                {
                    aggiornaElencoCC();
                }
                else if (modal.DialogResult == DialogResult.Cancel)
                {

                }
            }
        }

        /// <summary>
        /// rimuovo un conto corrente dalla banca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                const string message = "Vuoi rimuovere il conto corrente selezionato?";
                const string caption = "Form Closing";

                // visualizzo una message box di conferma per la rimozione del conto corrente
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // se torna Yes rimuovo il conto corrente
                if (result == DialogResult.Yes)
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // rimuovo il conto corrente dalla banca
                    banca.Remove(iban);
                    // aggiorna la listview dei conti correnti
                    aggiornaElencoCC();
                }
            }
        }

        /// <summary>
        /// visualizza la situazione del conto corrente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new StatoCC())
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
                    // chiamo la form
                    modal.ShowDialog();

                    // se non vi sono errori aggiorno l'elenco
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        aggiornaElencoCC();
                    }
                    else if (modal.DialogResult == DialogResult.Cancel)
                    {

                    }
                }
            }
        }

        /// <summary>
        /// versamento sul conto corrente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSoldi_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new Versamento())
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
                    // chiamo la form
                    modal.ShowDialog();

                    // se non vi sono errori aggiorno l'elenco
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        aggiornaElencoCC();
                    }
                    else if (modal.DialogResult == DialogResult.Cancel)
                    {

                    }
                }
            }
        }

        /// <summary>
        /// prelievo sul conto corrente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RmvSoldi_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new Prelievo())
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
                    // chiamo la form
                    modal.ShowDialog();

                    // se non vi sono errori aggiorno l'elenco
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        aggiornaElencoCC();
                    }
                    else if (modal.DialogResult == DialogResult.Cancel)
                    {

                    }
                }
            }
        }

        /// <summary>
        /// bonifico sul conto corrente verso un altro conto corrente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBonifico_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new Bonifico())
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
                    // chiamo la form
                    modal.ShowDialog();

                    // se non vi sono errori aggiorno l'elenco
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        aggiornaElencoCC();
                    }
                    else if (modal.DialogResult == DialogResult.Cancel)
                    {

                    }
                }
            }
        }

        private void BtnListaVersamenti_Click(object sender, EventArgs e)
        {
            // prendo la selezione attiva nella listview 
            var items = listCC.SelectedItems;

            // se vi è una selezione attiva, proseguo
            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new ListaVersamentiCC())
                {
                    // estraggo iban dalla selezione corrente della listview
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
                    // chiamo la form
                    modal.ShowDialog();

                    // se non vi sono errori aggiorno l'elenco
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        aggiornaElencoCC();
                    }
                    else if (modal.DialogResult == DialogResult.Cancel)
                    {

                    }
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // istanzio la form
            using (var modal = new ListaVersamentiBanca())
            {
                // passo l'istanza della banca
                modal.SetBanca(banca);
                // chiamo la form
                modal.ShowDialog();

                // se non vi sono errori aggiorno l'elenco
                if (modal.DialogResult == DialogResult.OK)
                {
                    aggiornaElencoCC();
                }
                else if (modal.DialogResult == DialogResult.Cancel)
                {

                }
            }
        }
    }
}
