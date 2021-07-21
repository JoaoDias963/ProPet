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
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

      
        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            lbUsuario.Hide();
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbSenha.Hide();
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                System.Media.SystemSounds.Question.Play();
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Usuario pegaUsuario()
        {
            Usuario u = new Usuario();
            u.Nome = tbLogin.Text;
            u.Senha = tbPassword.Text;
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.VerificaUsuario(u);
            return u;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new Protótipo.UsuarioDAO();

            if(usuarioDAO.VerificaUsuario(pegaUsuario()))
            {
                fmTelaPrincipal principal = new fmTelaPrincipal(pegaUsuario());
                fmBoasVindas boas = new fmBoasVindas();
                principal.Show();
                boas.MdiParent = principal;
                boas.Location = new Point(128, 0);
                boas.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llCadastrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmCadastrarUsuario novoUsu = new fmCadastrarUsuario();
            DialogResult escolha = MessageBox.Show("Função disponível somente para o Administrador.\nPor favor digite a Senha do Administrador",
                "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (escolha == DialogResult.OK)
            {
                novoUsu.Show();
            }
            else if(escolha == DialogResult.Cancel)
            {
                novoUsu.Close();
            } 
        }

        private void llEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbLogin.Text != "")
            {
                UsuarioDAO usuarioDAO = new Protótipo.UsuarioDAO();
                usuarioDAO.TrocaSenha(pegaUsuario());

                MessageBox.Show("Sua senha foi resetada para:\n\n                 \"1234\"", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esqueceu a senha? Não tem problema. Apenas digite o seu login \n                   e clique em 'Esqueci a Senha' novamente! ", "CADE O CHINELOOO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogin.Focus();
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //login somente letra e backspace ativado
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

               e.Handled = true;
            }
            if (tbLogin.Text.Length > 20)
            {
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbLogin.Text = "";
                
            }                  
                          
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evento senha letra+numero sem simbolo com enter
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if (tbPassword.Text.Length > 20)
            {
                e.Handled = false;
                MessageBox.Show("Máximo de 20 caracteres, somente letras e números são permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPassword.Text = "";
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btEntrar.PerformClick();
            }
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
