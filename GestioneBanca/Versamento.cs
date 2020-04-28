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
    /// <summary>
    /// versamento
    /// </summary>
    public partial class Versamento : Form
    {
        public Versamento()
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
        /// aggiungo soldi sul conto corrente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAggiungiSoldi_Click(object sender, EventArgs e)
        {
            // prendo l'importo dell'operazione
            var importo = Convert.ToDouble(txtCredito.Text);

            // se l'importo è maggiore di 0 effettuo l'operazione
            if (importo > 0)
            {
                // prendo tramite l'iban il conto corrente su cui effettuare l'operazione
                var cc = banca.Get(iban);
                // effettuo il versamento
                cc.Versamento(importo);
                // chiudo il dialogo
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
