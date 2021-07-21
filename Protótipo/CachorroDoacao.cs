using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class CachorroDoacao:Cachorro
    {
        Pessoa dono;

        internal Pessoa Dono
        {
            get
            {
                return dono;
            }

            set
            {
                dono = value;
            }
        }
    }
}
