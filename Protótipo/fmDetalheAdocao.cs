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
    public partial class fmDetalheAdocao : Form
    {
        public fmDetalheAdocao()
        {
            InitializeComponent();
        }
            

        private void mtbDataAdocao_Click(object sender, EventArgs e)
        {
            mcDataAdocao.Visible = true;
        }

        private void mcDataAdocao_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataAdocao.Text = mcDataAdocao.SelectionStart.ToString("dd/MM/yyyy");
            mcDataAdocao.Visible = false;
        }

        private void cbPorteCachorro_SelectedValueChanged(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = false;
        }

        private void cbPorteCachorro_Click(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = true;
        }

        private void cbPorteCachorro_MouseLeave(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = false;
        }

        private void mtbDataRegistro_Click(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = true;
        }

        private void mcDataRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataRegistro.Text = mcDataRegistro.SelectionStart.ToString("dd/MM/yyyy");
            mcDataRegistro.Visible = false;
        }

        private void mcDataRegistro_MouseLeave(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = false;
        }

        private void cbPorte_MouseHover(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = true;
        }

        private void cbPorte_MouseLeave(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja confirmar as mudanças realizadas?", "Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                /*codigo cadastro cachorro*/
                /*codigo limpa tela para cadastrar novo cachorro*/
            }
            else
            {
                /*codigo cadastro cachorro e fecha tela*/
            }
        }

        private void tbNomeCachorro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
        }
    }
}
