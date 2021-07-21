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
    public partial class fmCadastrarProduto : Form
    {
        public fmCadastrarProduto()
        {
            InitializeComponent();
            gbNovoItem.Visible = false;
        }
        Usuario usuario = new Usuario();

        public fmCadastrarProduto(object c) : this()
        {
            this.usuario = (Usuario)c;
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            
            if(usuarioDAO.VerificaAdmin(usuario.Nome,usuario.Senha))
                gbNovoItem.Visible = true;
        }

        private void pbCadastrar_MouseHover(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoAlterado;
            lbCadastrar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbCadastrar_MouseLeave(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botao;
            lbCadastrar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void pbBuscar_MouseHover(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botaoAlteradoNaoSelecionado;
            lbBuscar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbBuscar_MouseLeave(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botaoNormal;
            lbBuscar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            fmBuscarProduto busca = new fmBuscarProduto(usuario);
            busca.MdiParent = this.MdiParent;
            busca.Location = new Point(128, 0);
            busca.Show();
            this.Close();
        }

        private Produto pegaProduto()
        {
            Produto p = new Protótipo.Produto();
                       
            p.Nome = tbNome.Text;
            p.UnidadeMedida = tbUnidadeMedida.Text;            
            p.Categoria = cbCategoria.SelectedItem.ToString();
                     

            return p;
        }

        private void btCadastrarItem_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == -1 || tbNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha todos os campos do novo Produto", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                ProdutoDAO produtoDAO = new Protótipo.ProdutoDAO();
                EstoqueDAO estoqueDAO = new Protótipo.EstoqueDAO();

                produtoDAO.Criar(pegaProduto());
                estoqueDAO.CriarPrimeiro(pegaProduto());

                MessageBox.Show("Produto Cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                fmCadastrarProduto produto = new fmCadastrarProduto(usuario);
                
                produto.MdiParent = this.MdiParent;
                Close();
                produto.Location = new Point(128, 0);
                produto.Show();

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            tbUnidadeMedida.Text = "";
            
        }

        static ProdutoDAO produtoDAO = new Protótipo.ProdutoDAO();

        List<Produto> lista = produtoDAO.ListaTodos();
        private void fmCadastrarProduto_Load(object sender, EventArgs e)
        {         
            foreach (Produto p in lista)
                cbProduto.Items.Add(p.Nome);
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduto.SelectedIndex != -1)
            {
                lbMedida.Visible = true;
                lbMedida.Text = lista[cbProduto.SelectedIndex].UnidadeMedida;
                
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbProduto.SelectedIndex = -1;
            lbMedida.Text = "";
            nudQuantidade.Value = 1;
        }

        private Estoque pegaEstoque()
        {
            Estoque e = new Protótipo.Estoque();

            e.Produto = lista[cbProduto.SelectedIndex];
            e.Quantidade = long.Parse(nudQuantidade.Value.ToString());

            return e;
        }
        private void btCadastrarEstoque_Click(object sender, EventArgs e)
        {
            if(cbProduto.SelectedIndex == -1 || nudQuantidade.Value.ToString() == "0" )
            {
                MessageBox.Show("Por favor selecione valores válidos para todos os campos","Atenção",MessageBoxButtons.OK);
            }
            else
            {

                EstoqueDAO estoqueDAO = new Protótipo.EstoqueDAO();

                estoqueDAO.Criar(pegaEstoque());

                MessageBox.Show("Produto adicionado no Estoque", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbProduto.SelectedIndex = -1;
                lbMedida.Text = "";
                nudQuantidade.Value = 1;

            }
        }

      

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (tbNome.Text.Length > 20)
            {

                tbNome.Clear();
                MessageBox.Show("Máximo de 20 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex >= 0 && cbCategoria.SelectedIndex <= 5)
            {
                tbUnidadeMedida.Text = "Quilograma(kg)";
            }
            else if (cbCategoria.SelectedIndex == 6)
            {
                tbUnidadeMedida.Text = "Litro(L)";
            }
            else if (cbCategoria.SelectedIndex > 6)
            {
                tbUnidadeMedida.Text = "Unidade(Un)";
            }
        }

        private void tbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
