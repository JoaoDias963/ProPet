using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo
{
    public partial class fmCaoDispPPessoa : Form
    {
        public fmCaoDispPPessoa()
        {
            InitializeComponent();
        }
        Pessoa pessoa = new Pessoa();
        public fmCaoDispPPessoa(object p):this()
        {
            this.pessoa = (Pessoa)p;
        }

        private void fmCaoDispPPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'propetDataSet.cachorro'. Você pode movê-la ou removê-la conforme necessário.
            if (pessoa.PorteInteresse != "Qualquer Porte")
            {
                List<Cachorro> listaCachorros = new CachorroDAO().ListaPorteDisponiveis(this.pessoa.PorteInteresse);

                dvgCachorros.DataSource = listaCachorros;
            }
            else
            {
                List<Cachorro> listaCachorros = new CachorroDAO().ListaTodosDisponiveis();

                dvgCachorros.DataSource = listaCachorros;
            }
        }

        private void btSelecionaCao_Click(object sender, EventArgs e)
        {
            fmCadastrarAdocao fmAdocao = new Protótipo.fmCadastrarAdocao((Cachorro)dvgCachorros.CurrentRow.DataBoundItem, this.pessoa);
            fmAdocao.MdiParent = MdiParent;
            fmAdocao.Location = new Point(128, 0);
            fmAdocao.Show();
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
