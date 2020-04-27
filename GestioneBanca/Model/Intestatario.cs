using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBanca.Model
{
    public class Intestatario
    {
        public string nomeCompleto { get; set; } // nome dell'intestatario
		private DateTime dataNascita { get; set; } // data nascita dell'intestatario
		private string indirizzo { get; set; } // indirizzo dell'intestatario 
		private string email { get; set; } // e-mail dell'intestatario

		/// <summary>
		/// costruttore
		/// </summary>
		/// <param name="nomeCompleto_"></param>
		/// <param name="dataNascita_"></param>
		/// <param name="indirizzo_"></param>
		/// <param name="email_"></param>
		public Intestatario(string nomeCompleto_, DateTime dataNascita_, string indirizzo_, string email_)
        {
            nomeCompleto = nomeCompleto_;
            dataNascita = dataNascita_;
            indirizzo = indirizzo_;
            email = email_;
        }
    }
}
