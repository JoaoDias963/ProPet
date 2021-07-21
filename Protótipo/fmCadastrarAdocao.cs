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
    public partial class fmCadastrarAdocao : Form
    {
        Cachorro cachorro;
        Pessoa pessoa;
        public fmCadastrarAdocao()
        {
            InitializeComponent();
            mtbDataRegistro.Text = DateTime.Today.ToString("dd/MM/yyyy");
            mcDataRegistro.MaxDate = DateTime.Today;
        }

        public fmCadastrarAdocao(object c) : this()
        {
            this.cachorro = (Cachorro)c;

            tbSelecionado.Text = this.cachorro.NomeCao;
            if (cachorro != null)
            {
                mtbCpf.ReadOnly = false;
            }

            if (tbSelecionado.Text == "Cachorro externo")
            {
                lbDono.Visible = true;
                lbDono1.Visible = true;
                lbEnd.Visible = true;

                lbDono.Text = new CachorroDAO().VoltaDono(this.cachorro.IdCao).Nome;
                lbEnd.Text = (new CachorroDAO().VoltaDono(this.cachorro.IdCao).Endereco + ' ' + new CachorroDAO().VoltaDono(this.cachorro.IdCao).Numero);
            }
            else
            {
                lbDono.Visible = false;
                lbDono1.Visible = false;
                lbEnd.Visible = false;
            }
        }

        public fmCadastrarAdocao(object c,object p) : this()
        {
            this.cachorro = (Cachorro)c;
            this.pessoa = (Pessoa)p;

            tbSelecionado.Text = this.cachorro.NomeCao;
            mtbCpf.Text = this.pessoa.Cpf;
            mtbCpf.Enabled = false;
            btDisponiveis.Enabled = false;
            tbSelecionado.Enabled = false;
            mcDataRegistro.Enabled = false;
            mtbDataRegistro.Enabled = false;
        }


        private void mcDataRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataRegistro.Text = mcDataRegistro.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            fmBuscarAdocao adocao = new fmBuscarAdocao();
            adocao.MdiParent = MdiParent;
            adocao.Location = new Point(128, 0);
            adocao.Show();
            this.Close();
        }

        private void mtbCpfDigitando(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new Protótipo.PessoaDAO();
            

            if (mtbCpf.Text.Length == 14)
            {
                pessoa = pessoaDAO.AchaPessoa(mtbCpf.Text);
                if (pessoa.Nome != null)
                    lbNome.Text = pessoa.Nome;
                else
                    lbNome.Text = "Pessoa não encontrada!";
            }
            else
            {
                lbNome.Text = "Nome";
            }
        }

        private void mtbDataRegistro_Click(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = true;
        }

        private Adocao pegaAdocao()
        {
            Adocao a = new Adocao();
            a.Pessoa = pessoa;
            a.Cachorro = cachorro;
            a.DataAdocao = DateTime.Today;

            return a;

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (pessoa == null || cachorro == null)
            {
                MessageBox.Show("Por favor selecione uma pessoa e um cachorro para realizar a Adoção", "Atenção", MessageBoxButtons.OK);
            }
            else if(mtbCpf.MaskCompleted == false)
            {
                MessageBox.Show("Digite um CPF válido", "Atenção", MessageBoxButtons.OK);
            }else
            {
                AdocaoDAO adocaoDAO = new Protótipo.AdocaoDAO();
                adocaoDAO.Criar(pegaAdocao());

                MessageBox.Show("Adoção Realizada", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                rtExtrato extrato = new rtExtrato();
                    extrato.Show();
            }
        }

        private void btDisponiveis_Click(object sender, EventArgs e)
        {
            
                fmCachorrosDisponiveis disponiveis = new fmCachorrosDisponiveis();
                disponiveis.Show();
                disponiveis.MdiParent = MdiParent;
                disponiveis.Location = new Point(128, 0);
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            mtbCpf.Text = "";
            tbSelecionado.Text = "";
            cachorro = null;
            mtbCpf.ReadOnly = true;

            mtbCpf.Enabled = true;
            btDisponiveis.Enabled = true;
            tbSelecionado.Enabled = true;
            mcDataRegistro.Enabled = true;
            mtbDataRegistro.Enabled = true;
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (mtbCpf.ReadOnly == true)
            {
                MessageBox.Show("Por favor selecione um cachorro primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tbSelecionado_Click(object sender, EventArgs e)
        {
            if(cachorro == null)
            {
                MessageBox.Show("Por favor utilize o botão \"Mostrar Disponíveis\" para selecionar um Cachorro","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void mtbCpf_Enter(object sender, EventArgs e)
        {
            mtbCpf.SelectionStart =0;
        }

        private void mtbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbDataRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbSelecionado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (mtbCpf.Text.Length > 20)
            {
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCpf.Text = "";

            }
        }

        private void tbSelecionado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (tbSelecionado.Text.Length > 20)
            {
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSelecionado.Text = "";

            }
        }
    }
}
