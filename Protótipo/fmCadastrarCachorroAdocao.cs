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
    public partial class fmCadastrarCachorroAdocao : Form
    {
        Pessoa pessoa;
        public fmCadastrarCachorroAdocao()
        {
            InitializeComponent();
            rbFemea.Checked = true;            
            cbCor.SelectedIndex = 0;
            cbIdade.SelectedIndex = 0;
            cbPorte.SelectedIndex = 0;
            cbRaca.SelectedIndex = 0;
            mtbDataRegistro.Text= mcDataRegistro.TodayDate.ToString("dd/MM/yyyy");

        }

        public fmCadastrarCachorroAdocao(object p) : this()
        {
            this.pessoa = (Pessoa)p;
            lbDono.Text = pessoa.Nome;

        }
        private CachorroDoacao pegaCachorro()
        {
            CachorroDoacao c = new CachorroDoacao();
            c.Dono = pessoa;
            c.NomeCao = "Cachorro externo";
            c.Raca = cbRaca.SelectedItem.ToString();
            c.Bairro = pessoa.Bairro;
            c.Idade = cbIdade.SelectedItem.ToString();

            if (rbMacho.Checked)
                c.Sexo = 'M';
            else if (rbFemea.Checked)
                c.Sexo = 'F';

            c.Cor = cbCor.SelectedItem.ToString();
            c.Porte = cbPorte.SelectedItem.ToString();
            c.DataRegistro = Convert.ToDateTime(mtbDataRegistro.Text);
            if (chbSimVacinado.Checked == true)
            {
                c.Vacinado = true;
            }

            return c;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Deseja cadastrar mais Cachorros?","Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                /*codigo cadastro cachorro*/
                CachorroDAO cachorroDAO = new CachorroDAO();

                cachorroDAO.CriarCachorroDoacao(pegaCachorro());
                cachorroDAO.CriarCaoExterno(pegaCachorro());
              
                
                /*codigo limpa tela para cadastrar novo cachorro*/
                rbFemea.Checked = true;
                
                cbCor.SelectedIndex = 0;
                cbIdade.SelectedIndex = 0;
                cbPorte.SelectedIndex = 0;
                cbRaca.SelectedIndex = 0;
                mtbDataRegistro.Text = mcDataRegistro.TodayDate.ToString("dd/MM/yyyy");

            }
            else
            {
                /*codigo cadastro cachorro e fecha tela*/
                CachorroDAO cachorroDAO = new CachorroDAO();

                cachorroDAO.CriarCachorroDoacao(pegaCachorro());
                cachorroDAO.CriarCaoExterno(pegaCachorro());

                Close();
                
            }
        }

        private void mcDataRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataRegistro.Text = mcDataRegistro.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void mtbDataRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtbDataRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
    }
}
