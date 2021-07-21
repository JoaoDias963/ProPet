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
    public partial class fmCachorrosDisponiveis : Form
    {
        public fmCachorrosDisponiveis()
        {
            InitializeComponent();
            CachorroDAO cachorroDAO = new CachorroDAO();
            List<Cachorro> listaCachorros = cachorroDAO.ListaTodosDisponiveis();
            List<Cachorro> listaCachorrosExternos = cachorroDAO.ListaTodosDisponiveisExternos();

            dgvCachorros.DataSource = listaCachorros;
            
        }



        private void fmCachorrosDisponiveis_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'propetDataSet.cachorro'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
           
                fmCadastrarAdocao adocao = new fmCadastrarAdocao((Cachorro)dgvCachorros.CurrentRow.DataBoundItem);
                adocao.MdiParent = MdiParent;
                adocao.Location = new Point(128, 0);
                adocao.Show();
                Close();
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
