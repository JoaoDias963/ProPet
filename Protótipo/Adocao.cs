using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Adocao
    {
        private int idAdocao;
        private Pessoa pessoa;
        private Cachorro cachorro;
        private DateTime dataAdocao;

        internal Pessoa Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
            }
        }

        internal Cachorro Cachorro
        {
            get
            {
                return cachorro;
            }

            set
            {
                cachorro = value;
            }
        }

        public DateTime DataAdocao
        {
            get
            {
                return dataAdocao;
            }

            set
            {
                dataAdocao = value;
            }
        }

        public int IdAdocao
        {
            get
            {
                return idAdocao;
            }

            set
            {
                idAdocao = value;
            }
        }
    }
}
