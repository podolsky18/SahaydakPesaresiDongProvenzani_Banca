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
    public partial class AddSoldi : Form
    {
        public AddSoldi()
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

        private void BtnAggiungiSoldi_Click(object sender, EventArgs e)
        {
            var credito = txtCredito.Text;

            if (credito.Length > 0)
            {
                var cr = Convert.ToDouble(credito);
                var cc = banca.Get(iban);
                cc.Versamento(cr);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
