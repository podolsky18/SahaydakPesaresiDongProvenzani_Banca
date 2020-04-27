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

        private void Bonifico_Load(object sender, EventArgs e)
        {
            cc = banca.Get(iban);
            aggiornaElencoCC();
        }

        private void aggiornaElencoCC()
        {
            listCC.Items.Clear();
            foreach (var item in banca.ListaContiCorrenti())
            {
                if (item.iban != iban)
                {
                    var intestatario = item.GetIntestatario();
                    var item2 = new ListViewItem(new[] { item.iban, intestatario.nomeCompleto });
                    listCC.Items.Add(item2);
                }
            }
        }

        private void BtnEffettuaBonifico_Click(object sender, EventArgs e)
        {
            var items = listCC.SelectedItems;

            if (items.Count > 0)
            {
                var importo = Convert.ToDouble(txtBonifico.Text);
                var ibanDestinatario = items[0].SubItems[0].Text;
                banca.Bonifico(iban, ibanDestinatario, importo);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
