using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class Usuario
    {
        string nome;
        string senha;
        bool administrador;

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

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public bool Administrador
        {
            get
            {
                return administrador;
            }

            set
            {
                administrador = value;
            }
        }
    }
}
