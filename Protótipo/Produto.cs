using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Produto
    {
        private int idProduto;
        private string categoria;
        private string nome;
        private string unidadeMedida;       

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string UnidadeMedida
        {
            get
            {
                return unidadeMedida;
            }

            set
            {
                unidadeMedida = value;
            }
        }

        public int IdProduto
        {
            get
            {
                return idProduto;
            }

            set
            {
                idProduto = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }
    }
}
