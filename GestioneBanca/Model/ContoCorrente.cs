using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBanca.Model
{
    public class ContoCorrente
    {
        protected double saldo { get; set; } = 0; // saldo del conto corrente
        protected int nMovimenti { get; set; } = 0; // numero di movimenti sul conto corrente
        protected int maxMovimenti { get; set; } = 50; // max movimenti sul conto corrente
        public string iban { get; set; } // iban

        protected bool online = false; // indica che il conto corrente è di tipo online

        protected Intestatario intestatario = null;

        /// <summary>
        /// // lista dei movimenti
        /// </summary>
        protected List<Movimento> elencoMovimenti = new List<Movimento>();

        /// <summary>
        /// elenco dei movimenti giornalieri 
        /// </summary>
        private Dictionary<string, List<Movimento>> elencoMovimentiPerData = new Dictionary<string, List<Movimento>>();

        /// <summary>
        /// costruttore della classe
        /// </summary>
        /// <param name="saldo_"></param>
        /// <param name="maxMovimenti_"></param>
        public ContoCorrente(double saldo_, int maxMovimenti_)
        {
            saldo = saldo_;
            maxMovimenti = maxMovimenti_;
        }

        /// <summary>
        /// funzione per archiviare un bonifico 
        /// </summary>
        /// <param name="bonifico_"></param>
        public virtual void Add(Bonifico bonifico_)
        {
            elencoMovimenti.Add(bonifico_);
        }

        /// <summary>
        /// ritorna l'elenco dei bonifica archiviati
        /// </summary>
        /// <returns></returns>
        public List<Movimento> GetMovimenti()
        {
            return elencoMovimenti;
        }

        /// <summary>
        /// ritorta l'elenco dei movimenti raggruppati per data
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Movimento>> GetMovimentiPerData()
        {
            return elencoMovimentiPerData;
        }

        /// <summary>
        /// assegno l'intestaraio del conto corrente
        /// </summary>
        /// <param name="intestatario_"></param>
        public void SetIntestatario(Intestatario intestatario_)
        {
            intestatario = intestatario_;
        }

        /// <summary>
        /// restituisco l'intestatario del conto corrente
        /// </summary>
        /// <returns>intestatario</returns>
        public Intestatario GetIntestatario()
        {
            return intestatario;
        }

        /// <summary>
        /// prelievo di una somma dal conto corrente
        /// </summary>
        /// <param name="sommaDaPrelevare"></param>
        /// <returns>somma prelevata</returns>
        public virtual double Prelievo(double sommaDaPrelevare)
        {
            // creo il prelievo
            var prelievo = new Prelievo(DateTime.Now, sommaDaPrelevare);

            // registro il prelievo effettuato
            elencoMovimenti.Add(prelievo);

            // verifico se nell'elenco movimentiPerData è già stata inserita 
            // una data corrispondente alla data del movimento che devo inserire
            if (elencoMovimentiPerData.ContainsKey(prelievo.GetData().ToShortDateString()))
            {
                List<Movimento> items;

                // recupera l'elenco dei movimenti per quella data 
                if (elencoMovimentiPerData.TryGetValue(prelievo.GetData().ToShortDateString(), out items))
                {
                    // aggiunge il nuovo movimento 
                    items.Add(prelievo);
                }
            }
            else
            {
                // creo un elenco movimenti nuovo
                var items = new List<Movimento>();
                // aggiungo il movimento
                items.Add(prelievo);
                // aggiungo all'elenco movimentiPerData l'elenco movimento associandolo alla data
                elencoMovimentiPerData.Add(prelievo.GetData().ToShortDateString(), items);
            }

            saldo -= sommaDaPrelevare;
            nMovimenti++;

            // se il numero dei movimenti supera maxMovimenti applico un costo all'applicazione
            if (nMovimenti > maxMovimenti)
            {
                // applico il costo dell'operazione in base al tipo del conto corrente
                if (online)
                {
                    saldo -= ParametriApplicazione.CostoOperazioneOnline;
                }
                else
                {
                    saldo -= ParametriApplicazione.CostoOperazione;
                }
            }
            return sommaDaPrelevare;
        }

        /// <summary>
        /// versamento di una somma nel conto corrente
        /// </summary>
        /// <param name="sommaDaVersare"></param>
        /// <returns>somma versata</returns>
        public double Versamento(double sommaDaVersare)
        {
            var versamento = new Versamento(DateTime.Now, sommaDaVersare);

            // registro il versamento effettuato
            elencoMovimenti.Add(versamento);

            // verifico se nell'elenco movimentiPerData è già stata inserita 
            // una data corrispondente alla data del movimento che devo inserire
            if (elencoMovimentiPerData.ContainsKey(versamento.GetData().ToShortDateString()))
            {
                List<Movimento> items;

                // recupera l'elenco dei movimenti per quella data 
                if (elencoMovimentiPerData.TryGetValue(versamento.GetData().ToShortDateString(), out items))
                {
                    // aggiunge il nuovo movimento 
                    items.Add(versamento);
                }
            }
            else
            {
                // creo un elenco movimenti nuovo
                var items = new List<Movimento>();
                // aggiungo il movimento
                items.Add(versamento);
                // aggiungo all'elenco movimentiPerData l'elenco movimento associandolo alla data
                elencoMovimentiPerData.Add(versamento.GetData().ToShortDateString(), items);
            }

            saldo += sommaDaVersare;
            nMovimenti++;

            // se il numero dei movimenti supera maxMovimenti applico un costo all'applicazione
            if (nMovimenti > maxMovimenti)
            {
                // applico il costo dell'operazione in base al tipo del conto corrente
                if (online)
                {
                    saldo -= ParametriApplicazione.CostoOperazioneOnline;
                }
                else
                {
                    saldo -= ParametriApplicazione.CostoOperazione;
                }
            }
            return sommaDaVersare;
        }

        /// <summary>
        /// saldo
        /// </summary>
        /// <returns>saldo</returns>
        public double Saldo()
        {
            return saldo;
        }
    }
}
