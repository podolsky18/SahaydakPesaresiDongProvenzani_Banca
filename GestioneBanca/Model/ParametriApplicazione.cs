using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca.Model
{
    static class ParametriApplicazione
    {
        public static int maxMovimenti = 50; // max movimenti sul conto corrente
        public static double maxPrelievoOnline = 250; // max prelievo
        public static double CostoOperazione = 0.50; // costo dell'operazione che viene applicato su ogni movimento (solo quando nMovimenti > 50)
        public static double CostoOperazioneOnline = 0.50; // costo dell'operazione online..
    }
}
