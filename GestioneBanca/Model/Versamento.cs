using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca.Model
{
    class Versamento: Movimento
    {
        
        public Versamento(DateTime data_, double importo_) :
                                 base(data_, "Versamento", importo_)
        {

        }

        public double Get()
        {
            return Importo;
        }
    }
}
