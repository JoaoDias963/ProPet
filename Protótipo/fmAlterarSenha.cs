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
    public partial class fmAlterarSenha : Form
    {
        Usuario usuario = new Usuario();
        public fmAlterarSenha()
        {
            InitializeComponent();
        }

        public fmAlterarSenha(object u) : this()
        {
            this.usuario = (Usuario)u;
        }

        private void tbSenhaAntiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if (tbSenhaAntiga.Text.Length > 20)
            {
                e.Handled = false;
                MessageBox.Show("Máximo de 20 caracteres, somente letras e números são permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSenhaAntiga.Text = "";
            }
        }

        private void tbSenhaAntiga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if (tbSenhaAntiga.Text.Length > 20)
            {
                e.Handled = false;
                MessageBox.Show("Máximo de 20 caracteres, somente letras e números são permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSenhaAntiga.Text = "";
            }
        }

        private void tbConfirmaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbConfirmaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if (tbSenhaAntiga.Text.Length > 20)
            {
                e.Handled = false;
                MessageBox.Show("Máximo de 20 caracteres, somente letras e números são permitidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSenhaAntiga.Text = "";
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuario.Senha = tbSenhaAntiga.Text;
            if(usuarioDAO.VerificaUsuario(usuario))
            {
                if(tbNovaSenha.Text == tbConfirmaSenha.Text)
                {
                    usuario.Senha = tbConfirmaSenha.Text;
                    usuarioDAO.AlteraSenha(usuario);
                    MessageBox.Show("Senha alterada com sucesso!", "Parabéns", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Nova senha não confere", "Errou!",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Senha antiga não confere", "Errou!", MessageBoxButtons.OK);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
