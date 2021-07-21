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
    public partial class fmDetalhesCachorro : Form
    {
        Cachorro cachorro;
        public fmDetalhesCachorro()
        {
            InitializeComponent();
         
           
        }
        public fmDetalhesCachorro(object c) : this()
        {
            this.cachorro = (Cachorro)c;
            tbNomeCachorro.Text = cachorro.NomeCao;
            if(tbNomeCachorro.Text == "Cachorro externo")
            {
                tbNomeCachorro.ReadOnly = true;
            }

            cbRaca.Text = cachorro.Raca;
            cbBairro.Text = cachorro.Bairro;
            cbIdade.Text = cachorro.Idade;

            if (cachorro.Sexo == 'F')
                rbFemea.Checked = true;
            else
                rbMacho.Checked = true;

            cbCor.Text = cachorro.Cor;
            cbPorte.Text = cachorro.Porte;
            mtbDataRegistro.Text = cachorro.DataRegistro.ToString("dd/MM/yyyy");
            
            if(cachorro.Vacinado == true)
            {
                chbSimVacinado.Checked = true;
            }

            if(cachorro.Falecido == true)
            {
                chbSimFalecido.Checked = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
        }
        private Cachorro pegaCachorro()
        {
            Cachorro c = new Cachorro();
            c.NomeCao = tbNomeCachorro.Text;
            c.Raca = cbRaca.SelectedItem.ToString();
            c.Bairro = cbBairro.SelectedItem.ToString();
            c.Idade = cbIdade.SelectedItem.ToString();

            if (rbMacho.Checked)
                c.Sexo = 'M';
            else if (rbFemea.Checked)
                c.Sexo = 'F';

            c.Cor = cbCor.SelectedItem.ToString();
            c.Porte = cbPorte.SelectedItem.ToString();
            c.DataRegistro = Convert.ToDateTime(mtbDataRegistro.Text);
            c.IdCao = this.cachorro.IdCao;
            if (chbSimVacinado.Checked == true)
            {
                c.Vacinado = true;
            }

            if(chbSimFalecido.Checked == true)
            {
                c.Falecido = true;
            }

            return c;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Cachorro cachorro = pegaCachorro();
            if (tbNomeCachorro.Text.Trim() == "")
            {
                MessageBox.Show("Por favor Digite o nome do Cachorro", "Atenção", MessageBoxButtons.OK);
            }else if (DialogResult.Yes == MessageBox.Show("Deseja confirmar as mudanças realizadas?", "Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                /*codigo edição cachorro*/
                CachorroDAO cachorrodao = new CachorroDAO();
                cachorrodao.Editar(cachorro);
                
            }
            else
            {
                Close();
            }

            

            MessageBox.Show("Cachorro editado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            fmBuscarCachorro busca = new fmBuscarCachorro();
            busca.MdiParent = MdiParent;
            busca.Location = new Point(128, 0);
            busca.Show();
            this.Close();
            
        }


        private void mtbDataRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void mcDataRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataRegistro.Text = mcDataRegistro.SelectionStart.ToString("dd/MM/yyyy");
            mcDataRegistro.Visible = false;
        }

        private void tbNomeCachorro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (tbNomeCachorro.Text.Length > 20)
            {

                tbNomeCachorro.Clear();
                MessageBox.Show("Máximo de 20 caracteres e somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbNomeCachorro_KeyDown(object sender, KeyEventArgs e)
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
    }
}
