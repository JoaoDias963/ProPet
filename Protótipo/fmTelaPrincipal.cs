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
    public partial class fmTelaPrincipal : Form
    {
        public fmTelaPrincipal()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        public fmTelaPrincipal(object c) : this()
        {
            this.usuario = (Usuario)c;
        }

        private void btCachorros_Click(object sender, EventArgs e)
        {
            fmCadastrarCachorro cad = new fmCadastrarCachorro();
            cad.MdiParent = this;
            cad.Location = new Point(128, 0);
            cad.Show();

            btCachorros.BackColor = Color.White;
            btCachorros.ForeColor = Color.Black;

            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fmBoasVindas boas = new fmBoasVindas();            
            boas.MdiParent = this;
            boas.Location = new Point(128, 0);
            boas.Show();
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;
            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;
        }
          
        private void btCaoPanheiros_Click(object sender, EventArgs e)
        {
            fmCadastrarPessoas Pessoas = new fmCadastrarPessoas();
            Pessoas.MdiParent = this;
            Pessoas.Location = new Point(128, 0);
            Pessoas.Show();

            btCaoPanheiros.ForeColor = Color.Black;
            btCaoPanheiros.BackColor = Color.White;

            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;

        }

        private void btAdocao_Click(object sender, EventArgs e)
        {
            fmCadastrarAdocao adocao = new fmCadastrarAdocao();
            adocao.MdiParent = this;
            adocao.Location = new Point(128, 0);
            adocao.Show();

            btAdocao.BackColor = Color.White;
            btAdocao.ForeColor = Color.Black;

            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;

        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            fmCadastrarProduto produto = new fmCadastrarProduto(usuario);
            produto.MdiParent = this;
            produto.Location = new Point(128, 0);
            produto.Show();
            
            btProdutos.ForeColor = Color.Black;
            btProdutos.BackColor = Color.White;

            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            DialogResult fecha = MessageBox.Show("Deseja fechar o programa?", "Já vai indo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (fecha == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btGerarRelatorios_Click(object sender, EventArgs e)
        {
            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;

            fmRelats relats = new fmRelats();
            relats.Show();
            relats.MdiParent = this;
            relats.Location = new Point(128, 0);
            
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {
            btProdutos.ForeColor = Color.White;
            btProdutos.BackColor = Color.Black;
            btAdocao.BackColor = Color.Black;
            btAdocao.ForeColor = Color.White;
            btCaoPanheiros.ForeColor = Color.White;
            btCaoPanheiros.BackColor = Color.Black;
            btCachorros.BackColor = Color.Black;
            btCachorros.ForeColor = Color.White;

            fmAlterarSenha altera = new fmAlterarSenha(usuario);
            altera.Show();
            
        }
    }
}
