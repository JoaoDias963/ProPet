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
    public partial class fmCadastrarUsuario : Form
    {
        public fmCadastrarUsuario()
        {
            InitializeComponent();
           
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            //VALIDAR
            lbSenhaAdm.Hide();
            if (tbPassword.Text != "")
            {
                lbUsuario.Show();
                tbNovoUsuario.Show();

            }

        }  
       
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Usuario pegaUsuario()
        {
            Usuario u = new Usuario();
            u.Nome = tbNovoUsuario.Text;
            u.Senha = tbSenhaCadastro.Text;
            u.Administrador = false;

            return u;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text.Trim()=="" || tbNovoUsuario.Text.Trim() =="" || tbSenhaCadastro.Text.Trim() == "")
            {
                MessageBox.Show("Digite todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario usuario = pegaUsuario();

                UsuarioDAO usuarioDAO = new UsuarioDAO();

                if (usuarioDAO.VerificaAdmin("admin", tbPassword.Text))
                {
                    usuarioDAO.Criar(usuario);

                    MessageBox.Show("Usuário Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Close();
                }
                else
                {
                    MessageBox.Show("Senha do administrador incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Text = "";
                    tbPassword.Focus();
                }
            }
           
        }


        private void tbNovoUsuario_TextChanged(object sender, EventArgs e)
        {
            lbSenhaCadastro.Show();
            tbSenhaCadastro.Show();
            btCadastrar.Show();

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

        }

        private void tbNovoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //login somente letra e backspace ativado
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (tbNovoUsuario.Text.Length > 20)
            {
                e.Handled = false;
                tbNovoUsuario.Clear();
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void tbSenhaCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evento senha letra+numero sem simbolo com enter
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if (tbSenhaCadastro.Text.Length > 20)
            {
                e.Handled = false;
                tbSenhaCadastro.Clear();
                MessageBox.Show("Máximo de 20 caracteres, somente letras e números são permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }


            if (e.KeyChar == (char)Keys.Enter)
            {
                btCadastrar.PerformClick();
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

        private void tbNovoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbSenhaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
