using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Cachorro
    {
        private string nomeCao;
        private string raca;
        private char sexo;
        private string idade;
        private string cor;
        private string bairro;
        private string porte;
        private bool vacinado;
        private string observacao;
        private int idCao;
        private DateTime dataRegistro;
        private bool falecido;       


        public string NomeCao
        {
            get
            {
                return nomeCao;
            }

            set
            {
                nomeCao = value;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        

        public string Porte
        {
            get
            {
                return porte;
            }

            set
            {
                porte = value;
            }
        }

        public bool Vacinado
        {
            get
            {
                return vacinado;
            }

            set
            {
                vacinado = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }

        public int IdCao
        {
            get
            {
                return idCao;
            }

            set
            {
                idCao = value;
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

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public bool Falecido
        {
            get
            {
                return falecido;
            }

            set
            {
                falecido = value;
            }
        }
    }
}
