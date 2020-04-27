using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca.Model
{
    class Prelievo: Movimento
    {
        public Prelievo(DateTime data_, double importo_) :
                                 base(data_, "Prelievo", importo_)
        {

        }

        public double Get()
        {
            return Importo;
        }
    }
}
