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

    public partial class addCC : Form
    {
        /// <summary>
        /// banca su cui farò le operazioni...
        /// </summary>
        private Banca banca = null;
        private int nMovimenti = 0; // numero di movimenti sul conto corrente
        private int maxMovimenti= 50; // max movimenti sul conto corrente
        private double maxPrelievo = 250;

        public addCC()
        {
            InitializeComponent();
            // inizializzo il valore del credito iniziale a 0
            txtCreditoIniziale.Text = "0";
        }

        private void BtnCreaCC_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var cognome = txtCognome.Text;
            var dataNascita = dtpDataNascita.Value;
            var email = txtEmail.Text;
            var indirizzo = txtIndirizzo.Text;
            var creditoIniziale = txtCreditoIniziale.Text;

            if (nome.Length > 0 && cognome.Length > 0)
            {
                ContoCorrente cc = null;

                if (cbContoCorrenteOnline.Checked)
                {
                    cc = new ContoCorrenteOnline(maxPrelievo, 0, nMovimenti, maxMovimenti);
                }
                else
                {
                    cc = new ContoCorrente(0, nMovimenti, maxMovimenti);
                }
                Intestatario soggetto = new Intestatario(string.Format("{0} {1}", cognome, nome), dataNascita, indirizzo, email);
                cc.SetIntestatario(soggetto);
                banca.Add(cc);
                if (Convert.ToDouble(creditoIniziale) > 0)
                {
                    cc.Versamento(Convert.ToDouble(creditoIniziale));
                }
               
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Il campo Nome e Cognome sono obbligatori.");
            }
        }

        /// <summary>
        /// passo l'istanza della banca che utilizzerò per le operazioni 
        /// </summary>
        /// <param name="banca_"></param>
        public void SetBanca(Banca banca_)
        {
            banca = banca_;
        }
    }
}
