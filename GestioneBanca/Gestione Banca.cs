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

        private void aggiornaElencoCC()
        {
            listCC.Items.Clear();
            foreach (var item in banca.ListaContiCorrenti())
            {
                var intestatario = item.GetIntestatario();
                var item2 = new ListViewItem(new[] { item.iban, intestatario.nomeCompleto });
                listCC.Items.Add(item2);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // istanzio la form
            using (var modal = new addCC())
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

        private void Button2_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                const string message = "Vuoi rimuovere il conto corrente selezionato?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var iban = items[0].SubItems[0].Text;
                    banca.Remove(iban);
                    aggiornaElencoCC();
                }
            }
        }

        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new StatoCC())
                {
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
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
        }

        private void AddSoldi_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new AddSoldi())
                {
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
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
        }

        private void RmvSoldi_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new RemoveSoldi())
                {
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
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
        }

        private void BtnBonifico_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                // istanzio la form
                using (var modal = new Bonifico())
                {
                    var iban = items[0].SubItems[0].Text;
                    // passo l'istanza della banca
                    modal.SetBanca(banca);
                    modal.SetIban(iban);
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
        }
    }
}
