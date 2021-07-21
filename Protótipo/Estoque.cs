using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Estoque
    {
        private Produto produto;
        private long quantidade;
        private DateTime dataRegistro;

        public long Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        internal Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public DateTime DataRegistro
        {
            get
            {
                return dataRegistro;
            }

            set
            {
                dataRegistro = value;
            }
        }
    }
}
