using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Protótipo
{
    public partial class fmDetalhesPessoas : Form
    {
        Pessoa pessoa;
        public fmDetalhesPessoas()
        {
            InitializeComponent();
                   
           
                      
        }
        public fmDetalhesPessoas(object p) : this()
        {
            this.pessoa = (Pessoa)p;
            tbNome.Text = pessoa.Nome;
            mtbCpf.Text = pessoa.Cpf;
            tbEndereco.Text = pessoa.Endereco;
            tbNumero.Text = pessoa.Numero.ToString();
            tbCidade.Text = pessoa.Cidade.ToString();
            tbComplemento.Text = pessoa.Complemento;
            cbBairro.Text = pessoa.Bairro;
            mtbCep.Text = pessoa.Cep;
            mtbTelefone.Text = pessoa.Telefone;
            mtbCelular.Text = pessoa.Celular;
            tbEmail.Text = pessoa.Email;
            
            if (pessoa.Interesse == "Adotar")
            {
                rbAdotar.Checked = true;
                pessoa.Desinteressado = 'N';
            }
                
            else if(pessoa.Interesse == "Doar")
            {
                rbDoar.Checked = true;
                pessoa.Desinteressado = 'N';
            }
            else if(pessoa.Desinteressado == 'S')
            {
                
                rbDesinteressado.Checked = true;
                pessoa.Interesse = "Sem Interesse";
            }
            else
            {
                rbDesinteressado.Checked = false;
            }
            
            cbPorte.Text = pessoa.PorteInteresse;
        }
        private Pessoa pegaPessoa()
        {
            Pessoa p = new Pessoa();
            p.Nome = tbNome.Text;
            p.Cpf = mtbCpf.Text;
            p.Endereco = tbEndereco.Text;
            p.Cep = mtbCep.Text;
            p.Cidade = tbCidade.Text;
            p.Numero = int.Parse(tbNumero.Text);
            p.Complemento = tbComplemento.Text;
            p.Bairro = cbBairro.SelectedItem.ToString();
            p.Telefone = mtbTelefone.Text;
            p.Celular = mtbCelular.Text;
            p.Email = tbEmail.Text;

            if (rbAdotar.Checked == true)
            {
                p.Interesse = "Adotar";
            }
            else if (rbDoar.Checked == true)
            {
                p.Interesse = "Doar";
            }         

            p.PorteInteresse = cbPorte.SelectedItem.ToString();

            if(rbDesinteressado.Checked == true)
            {
                p.Desinteressado = 'S';
                p.Interesse = "Sem Interesse";
            }
            else
            {
                p.Desinteressado = 'N';
            }

            p.DataRegistro = DateTime.Today;

            return p;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new Protótipo.PessoaDAO();

            if (tbNome.Text.Trim() == "" || mtbCpf.Text.Trim() == "" || tbEndereco.Text.Trim() == "" || tbNumero.Text.Trim() == "" || tbCidade.Text.Trim() == "" || tbEndereco.Text.Trim() == "" || mtbCep.MaskCompleted == false)
            {
                MessageBox.Show("Digite todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (mtbCelular.MaskCompleted == false && mtbTelefone.MaskCompleted == false && tbEmail.Text == "")
                {
                    mtbCelular.Text = "";
                    mtbTelefone.Text = "";
                    tbEmail.Text = "";
                    MessageBox.Show("Por favor, digite pelo menos um contato válido.", "Ops!", MessageBoxButtons.OK);
                }
                else
                {
                    pessoaDAO.Editar(pegaPessoa());
                    /* chamar cadastro cao doador*/

                    if (pegaPessoa().Interesse == "Doar")
                    {
                        fmCadastrarCachorroAdocao doar = new fmCadastrarCachorroAdocao((Pessoa) pegaPessoa());
                        MessageBox.Show("Cadastre o(s) Cachorro(s) disponiveis para adoção", "Atenção", MessageBoxButtons.OK);
                        doar.Show();
                        doar.MdiParent = MdiParent;
                        doar.Location = new Point(128, 0);
                       
                    }
                    else
                    {
                        MessageBox.Show("CãoPanheiro editado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //limpaTela();

                    //btFechar.PerformClick();
                }
            }
        }

        private void limpaTela()
        {
            tbNome.Text = "";
            mtbCpf.Text = "";
            tbEndereco.Text = "";
            tbComplemento.Text = "";
            cbBairro.SelectedIndex = -1;
            mtbCep.Text = "";
            tbCidade.Text = "";
            mtbTelefone.Text = "";
            mtbCelular.Text = "";
            tbEmail.Text = "";            
            rbAdotar.Checked = true;
            cbPorte.SelectedIndex = -1;
        }




        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (tbNome.Text.Length > 50)
            {

                tbNome.Clear();
                MessageBox.Show("Máximo de 50 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if(tbNumero.Text.Length > 5)
            {
                tbNumero.Clear();
                MessageBox.Show("Máximo de 5 números permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            
            fmBuscarPessoas busca = new fmBuscarPessoas();
            busca.Show();
            busca.MdiParent = MdiParent;
            busca.Location = new Point(128, 0);
            
            Close();
        }

        private void mtbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbEndereco.Text.Length > 254)
            {

                tbEndereco.Clear();
                MessageBox.Show("Máximo de 254 caracteres permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (tbEmail.Text != "")
            {
                string email = tbEmail.Text;

                Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

                if (rg.IsMatch(email))
                {
                    pbValido.Visible = true;
                    pbInvalido.Visible = false;
                }
                else
                {
                    pbInvalido.Visible = true;
                    pbValido.Visible = false;
                }
            }
            else
            {
                pbInvalido.Visible = false;
                pbValido.Visible = false;
            }


        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (pbInvalido.Visible == true)
            {
                tbEmail.Text = "";
                pbInvalido.Visible = false;
            }
        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            if(mtbTelefone.MaskCompleted == false)
            {
                mtbTelefone.Text = "";
            }
        }

        private void mtbCelular_Leave(object sender, EventArgs e)
        {
            if (mtbCelular.MaskCompleted == false)
            {
                mtbTelefone.Text = "";
            }
        }

        private void tbEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Por favor,\n Digite números por extenso", "Atenção", MessageBoxButtons.OK);
            }
            if (tbEndereco.Text.Length > 100)
            {

                tbEndereco.Clear();
                MessageBox.Show("Máximo de 100 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))))
            {
                e.Handled = true;
            }

            if (tbComplemento.Text.Length > 50)
            {

                tbComplemento.Clear();
                MessageBox.Show("Máximo de 50 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {

                e.Handled = true;
            }

            if (tbEndereco.Text.Length > 50)
            {

                tbEndereco.Clear();
                MessageBox.Show("Máximo de 50 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mtbTelefone_Click(object sender, EventArgs e)
        {
            mtbTelefone.SelectionStart = 0;
        }

        private void mtbCelular_Click(object sender, EventArgs e)
        {
            mtbCelular.SelectionStart = 0;
        }

        private void mtbCep_Click(object sender, EventArgs e)
        {

            mtbCep.SelectionStart = 0;
        }

        private void rbDoar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDoar.Checked == true)
            {
                btMostrar.Enabled = true;
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            fmMostrarCachorroDoacao doacao = new fmMostrarCachorroDoacao((Pessoa)pegaPessoa());
            doacao.Show();
            doacao.MdiParent = MdiParent;
            doacao.Location = new Point(128, 0);
            
        }

        private void tbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbCep_Enter(object sender, EventArgs e)
        {
            mtbCep.SelectionStart = 0;
        }

        private void mtbTelefone_Enter(object sender, EventArgs e)
        {
            mtbTelefone.SelectionStart = 0;
        }

        private void mtbCelular_Enter(object sender, EventArgs e)
        {
            mtbCelular.SelectionStart = 0;
        }
    }
}
