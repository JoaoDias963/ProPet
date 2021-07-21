using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string endereco;
        private string cep;
        private int numero;
        private string complemento;
        private string bairro;
        private string telefone;
        private string celular;
        private string email;
        private string interesse;
        private string porteInteresse;       
        private DateTime dataRegistro;
        private string cidade;
        private char desinteressado;

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

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Interesse
        {
            get
            {
                return interesse;
            }

            set
            {
                interesse = value;
            }
        }

        public string PorteInteresse
        {
            get
            {
                return porteInteresse;
            }

            set
            {
                porteInteresse = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
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

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public char Desinteressado
        {
            get
            {
                return desinteressado;
            }

            set
            {
                desinteressado = value;
            }
        }
    }
}
