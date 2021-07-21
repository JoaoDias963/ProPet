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
    public partial class fmBuscarAdocao : Form
    {
        public fmBuscarAdocao()
        {
            InitializeComponent();
          
            atualizaDataGrid();
        }

        private void pbBuscar_MouseHover(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botaoAlterado;
            lbBuscar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbBuscar_MouseLeave(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botao;
            lbBuscar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void pbCadastrar_MouseHover(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoAlteradoNaoSelecionado;
            lbCadastrar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbCadastrar_MouseLeave(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoNormal;
            lbCadastrar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void pbCadastrar_Click(object sender, EventArgs e)
        {
            fmCadastrarAdocao cadastro = new fmCadastrarAdocao();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Location = new Point(128, 0);
            cadastro.Show();
        }

        private void atualizaDataGrid()
        {
            dgvAdocoes.Rows.Clear();
            AdocaoDAO adocaoDAO = new AdocaoDAO();

            
        
                List<Adocao> listaAdocoes = adocaoDAO.ListaTodos();

                foreach (Adocao a in listaAdocoes)
                {
                    dgvAdocoes.Rows.Add(a.Pessoa.Nome, a.Pessoa.Cpf, a.Cachorro.NomeCao, a.Cachorro.Raca, a.Cachorro.Sexo, a.DataAdocao);

                }
            
        }

        

        
    
     


        private void tbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (tbPesquisar.Text.Length > 20)
            {
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPesquisar.Text = "";

            }
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            dgvAdocoes.Rows.Clear();
            AdocaoDAO adocaoDAO = new AdocaoDAO();
            List<Adocao> listaAdocao = adocaoDAO.ListaPesquisa(tbPesquisar.Text);
            

            foreach (Adocao a in listaAdocao)
            {
                dgvAdocoes.Rows.Add(a.Pessoa.Nome, a.Pessoa.Cpf, a.Cachorro.NomeCao, a.Cachorro.Raca, a.Cachorro.Sexo, a.DataAdocao);

            }
        }

        private void tbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
