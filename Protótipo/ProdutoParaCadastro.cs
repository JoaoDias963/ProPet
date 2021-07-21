using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class ProdutoParaCadastro
    {
        private string categoria;
        private string nome;
        private string medida;
        private string prodPorte;



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

        public string Medida
        {
            get
            {
                return medida;
            }

            set
            {
                medida = value;
            }
        }

        public string ProdPorte
        {
            get
            {
                return prodPorte;
            }

            set
            {
                prodPorte = value;
            }
        }
    }
}
