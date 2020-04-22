using System;

namespace Banca
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // esempio
            var banca = new Banca("Banca dei poveri", "Vicolo stretto"); // deve essere istanziata una sola banca
            var cc0 = banca.Add(new ContoCorrente(1000, 0, 50)); // aggiungo un conto corrente
            cc0.SetIntestatario(new Intestatario("Pietro Smusi", DateTime.Now, "Piazza della Vittoria", "pietrosmusi89@gmail.com")); // imposto intestatario ad un conto corrente
            Console.WriteLine("Saldo corrente " + cc0.Saldo());
            cc0.Versamento(100); // faccio un versamento
            Console.WriteLine("Versamento di 100 euro... ");
            cc0.Prelievo(1000); // prelievo
            Console.WriteLine("Prelievo di 1000 euro... ");
            var saldo = cc0.Saldo(); // saldo
            Console.WriteLine("Saldo corrente " + saldo); // stampa il saldo rimanente


            // esempio successivo
            var cc1 = banca.Add(new ContoCorrente(1000, 51, 50)); // aggiungo un conto corrente
            cc1.SetIntestatario(new Intestatario("Pietro Smusi", DateTime.Now, "Piazza della Vittoria", "pietrosmusi89@gmail.com")); // imposto intestatario ad un conto corrente
            Console.WriteLine("\nSaldo corrente " + cc1.Saldo());
            cc1.Versamento(100); // faccio un versamento
            Console.WriteLine("Versamento di 100 euro... ");
            cc1.Prelievo(1000); // prelievo
            Console.WriteLine("Prelievo di 1000 euro... ");
            Double saldo1 = cc1.Saldo(); // saldo
            Console.WriteLine("Saldo corrente " + saldo1); // stampa il saldo rimanente



            // situazione prima del bonifico 
            Console.WriteLine("Saldo conto corrente mittente " + cc0.Saldo().ToString());
            Console.WriteLine("Saldo conto corrente destinatario " + cc1.Saldo().ToString());
            Console.WriteLine("\nBonifico di 50 euro in corso...\n");
            banca.Bonifico(cc0.iban, cc1.iban, 50); // esempio di un bonifico tra due conti correnti
            // situazione dopo il bonifico
            Console.WriteLine("Saldo conto corrente mittente " + cc0.Saldo().ToString());
            Console.WriteLine("Saldo conto corrente destinario " + cc1.Saldo().ToString());
            Console.ReadKey();
        }
    }
}
