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
    /// creo un dialogo che mi permette di creare un conto corrente sulla banca
    /// </summary>
    public partial class CreaCC : Form
    {
        /// <summary>
        /// banca su cui farò le operazioni..
        /// </summary>
        private Model.Banca banca = null;

        public CreaCC()
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

            // controllo che le credenziali siano valide
            if (nome.Length > 0 && cognome.Length > 0)
            {
                ContoCorrente cc = null;

                // controllo il tipo di conto corrente che si vuole creare
                if (cbContoCorrenteOnline.Checked)
                {
                    // creo il conto  corrente con un valore iniziale di saldo uguale a 0
                    cc = new ContoCorrenteOnline(ParametriApplicazione.maxPrelievoOnline, 0, ParametriApplicazione.maxMovimenti);
                }
                else
                {
                    // creo il conto  corrente con un valore iniziale di saldo uguale a 0
                    cc = new ContoCorrente(0, ParametriApplicazione.maxMovimenti);
                }
                // creo dati anagrafici del soggetto 
                Intestatario soggetto = new Intestatario(string.Format("{0} {1}", cognome, nome), dataNascita, indirizzo, email);
                // assegno i dati anagrafici al conto corrente 
                cc.SetIntestatario(soggetto);
                // aggiunge alla banca il conto corrente
                banca.Add(cc);
                // se il credito iniziale è maggiore di 0, allora effettuo un versamento con il valore del credito iniziale
                if (Convert.ToDouble(creditoIniziale) > 0)
                {
                    // effettuo il versamento del credito iniziale
                    cc.Versamento(Convert.ToDouble(creditoIniziale));
                }
               // esco dal dialogo assegnando il result ad ok
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
        public void SetBanca(Model.Banca banca_)
        {
            banca = banca_;
        }
    }
}
