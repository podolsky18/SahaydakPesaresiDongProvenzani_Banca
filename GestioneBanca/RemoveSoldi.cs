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
    public partial class RemoveSoldi : Form
    {
        private Banca banca = null;
        private string iban = "";
        public RemoveSoldi()
        {
            InitializeComponent();
        }

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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var prelievo = txtPrelievo.Text;

            if (prelievo.Length > 0)
            {
                var cr = Convert.ToDouble(prelievo);
                var cc = banca.Get(iban);
                cc.Prelievo(cr);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
