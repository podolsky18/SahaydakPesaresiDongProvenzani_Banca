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
    /// prelievo
    /// </summary>
    public partial class Prelievo : Form
    {
        private Model.Banca banca = null;
        private string iban = "";
        public Prelievo()
        {
            InitializeComponent();
        }

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
        /// effettuo il prelievo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // importo del prelievo
            var importo = Convert.ToDouble(txtPrelievo.Text);

            // se il valore del prelievo è maggiore di 0 effettuo l'operazione
            if (importo > 0)
            {
                // tramite iban  nella banca trovo il conto corrente su cui fare l'operazione (non controllo eventuali errori perché iban è stato selezionato dalla lista, 
                // è quindi sicuramente esistente)
                var cc = banca.Get(iban);

                // eseguo operazione, controllo se c'è un errore
                if (cc.Prelievo(importo) != importo)
                {
                    MessageBox.Show("Prelievo ha restituito un errore e l'operazione non è stata effettuata.");
                }
                // esco dal dialogo
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
