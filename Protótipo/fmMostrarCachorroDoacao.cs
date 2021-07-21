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
    public partial class fmMostrarCachorroDoacao : Form
    {
        Pessoa pessoa;
        public fmMostrarCachorroDoacao()
        {
            InitializeComponent();

           
        }

        public fmMostrarCachorroDoacao(object p) : this()
        {
            this.pessoa = (Pessoa)p;
            CachorroDAO cachorroDAO = new CachorroDAO();

            List<CachorroDoacao> lista = cachorroDAO.ListaCachorroDoacaoCPF(pessoa);
            dgvCachorroDoacao.DataSource = lista;
        }
       

        private void btDetalhes_Click(object sender, EventArgs e)
        {
            fmDetalhesCachorro detalhes = new fmDetalhesCachorro((Cachorro)dgvCachorroDoacao.CurrentRow.DataBoundItem);
            detalhes.MdiParent = MdiParent;
            detalhes.Show();
            detalhes.Location = new Point(128,0);
        }

        private void fmMostrarCachorroDoacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'propetDataSet.cachorrodoacao'. Você pode movê-la ou removê-la conforme necessário.
            this.cachorrodoacaoTableAdapter.Fill(this.propetDataSet.cachorrodoacao);

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
