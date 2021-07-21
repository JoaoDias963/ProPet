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
    public partial class fmCadastrarPessoas : Form
    {
        public fmCadastrarPessoas()
        {
            InitializeComponent();
            cbPorte.SelectedIndex = 6;            
            cbBairro.SelectedIndex = 0;
            rbAdotar.Checked = true;
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
            fmBuscarPessoas busca = new fmBuscarPessoas();
            busca.MdiParent = this.MdiParent;
            busca.Location = new Point(128, 0);
            busca.Show();
            this.Close();
        }

       

        private Pessoa pegaPessoa()
        {
            Pessoa p = new Pessoa();

            p.Nome = tbNome.Text;
            p.Cpf = mtbCpf.Text;
            p.Endereco = tbEndereco.Text;
            p.Numero =int.Parse(tbNumero.Text);
            p.Cep = mtbCep.Text;
            p.Complemento = tbComplemento.Text;
            p.Cidade = tbCidade.Text;
            p.Bairro = cbBairro.SelectedItem.ToString();
            if (mtbTelefone.Text == "")
            {
                p.Telefone = "";
            }
            else
            {
                p.Telefone = mtbTelefone.Text;
            }

            if (mtbCelular.Text == "")
            {
                p.Celular = "";
            }
            else
            {
                p.Celular = mtbCelular.Text;
            }

            if (tbEmail.Text == "")
            {
                p.Email = "";
            }
            else
            {
                p.Email = tbEmail.Text;
            }
            
            
            if (rbAdotar.Checked == true)
            {
                p.Interesse = "Adotar";
            }
            else if (rbDoar.Checked == true)
            {
                p.Interesse = "Doar";
                cbPorte.Enabled = false;
            }

          
            p.PorteInteresse = cbPorte.SelectedItem.ToString();
            p.DataRegistro = DateTime.Today;
            p.Desinteressado = 'N';

            return p;
        }

       

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new Protótipo.PessoaDAO();
            
            if(tbNome.Text.Trim() == "" || mtbCpf.MaskCompleted== false || tbEndereco.Text.Trim() == "" || tbNumero.Text == "" || tbCidade.Text.Trim() == "" || tbEndereco.Text.Trim() == "" || mtbCep.MaskCompleted==false)
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
                    pessoaDAO.Criar(pegaPessoa());
                    /*tentativa chamar cadastro cao doador*/

                    if (pegaPessoa().Interesse == "Doar")
                    {

                        if(DialogResult.OK== MessageBox.Show("Pessoa cadastrada com sucesso!!\n\nCadastre o(s) Cachorro(s) disponiveis para adoção", "Atenção", MessageBoxButtons.OKCancel))
                        {
                            fmCadastrarCachorroAdocao doar = new fmCadastrarCachorroAdocao((Pessoa)pegaPessoa());
                            doar.Show();
                            doar.MdiParent = MdiParent;
                            doar.Location = new Point(128, 0);
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("CãoPanheiro cadastrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (pegaPessoa().PorteInteresse == "Qualquer Porte")
                        {
                            List<Cachorro> lista = new CachorroDAO().ListaTodosDisponiveis();
                            if (lista.Count != 0)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Existem " + lista.Count + " cachorro(s) disponivel(is)\nRealizar Adoção agora?", "Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    fmCaoDispPPessoa fmCaoDisp = new fmCaoDispPPessoa(pegaPessoa());
                                    fmCaoDisp.Show();
                                    fmCaoDisp.MdiParent = MdiParent;
                                    fmCaoDisp.Location = new Point(128, 0);
                                }
                            }
                            
                        }
                        else
                        {
                            List<Cachorro> lista = new CachorroDAO().ListaPorteDisponiveis(pegaPessoa().PorteInteresse);
                            if (lista.Count != 0)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Existem " + lista.Count + " cachorro(s) disponivel(is)\nRealizar Adoção agora?", "Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    fmCaoDispPPessoa fmCaoDisp = new fmCaoDispPPessoa(pegaPessoa());
                                    fmCaoDisp.Show();
                                    fmCaoDisp.MdiParent = MdiParent;
                                    fmCaoDisp.Location = new Point(128, 0);
                                }
                            }
                        }
                    }

                    limpaTela();
                }
            }



        }

        private void limpaTela()
        {
            tbNome.Text = "";
            mtbCpf.Text = "";
            tbEndereco.Text = "";
            tbComplemento.Text = "";
            cbBairro.SelectedIndex = 0;
            mtbCep.Text = "";
            tbCidade.Text = "";
            mtbTelefone.Text = "";
            mtbCelular.Text = "";
            tbEmail.Text = "";            
            rbAdotar.Checked = true;
            cbPorte.SelectedIndex = 6;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        
      

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (tbNome.Text.Length > 50)
            {

                tbNome.Clear();
                MessageBox.Show("Máximo de 50 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {

                e.Handled = true;
            }
            
            if (tbEndereco.Text.Length > 100)
            {

                tbEndereco.Clear();
                MessageBox.Show("Máximo de 100 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Por favor,\n Digite números por extenso", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)|| char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (tbNumero.Text.Length > 5)
            {

                tbNumero.Clear();
                MessageBox.Show("Máximo de 5 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void mtbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        
        

        public static bool validaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();                
            return cpf.EndsWith(digito);
        }
    

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
            if (mtbCpf.Text.Length == 14)
            {
                PessoaDAO pessoaDAO = new PessoaDAO();
                if (pessoaDAO.AchaPessoa(mtbCpf.Text).Cpf != null)
                {
                    MessageBox.Show("CPF já cadastrado!!\nEntre com um CPF válido!", "OPS!", MessageBoxButtons.OK);
                    mtbCpf.Text = "";
                }

                if (!validaCpf(mtbCpf.Text))
                {
                    mtbCpf.Text = "";
                    MessageBox.Show("CPF Invalido, Por favor digite novamente","CPF invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    mtbCpf.Focus();
                }
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

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (tbEmail.Text.Length > 254)
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
            if(pbInvalido.Visible == true)
            {
                tbEmail.Text = "";
                pbInvalido.Visible = false;
            }
        }

        private void tbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {

                e.Handled = true;
            }

            if (tbCidade.Text.Length > 50)
            {

               tbCidade.Clear();
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

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            mtbCpf.SelectionStart = 0;
        }

        private void mtbCep_Click(object sender, EventArgs e)
        {
            mtbCep.SelectionStart = 0;
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

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
        }

        private void mtbCpf_Enter(object sender, EventArgs e)
        {
            mtbCpf.SelectionStart = 0;
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
