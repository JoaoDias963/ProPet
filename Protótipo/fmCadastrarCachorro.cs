using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Protótipo
{
    public partial class fmCadastrarCachorro : Form
    {
        private Pessoa pessoa;

        public fmCadastrarCachorro()
        {
            InitializeComponent();
            cbRaca.SelectedIndex = 0;
            cbBairro.SelectedIndex = 0;
            cbIdade.SelectedIndex = 0;
            cbCor.SelectedIndex = 0;
            cbPorte.SelectedIndex = 0;
            rbFemea.Checked = true;
            mtbDataRegistro.Text = DateTime.Today.ToString("dd/MM/yyyy");
            mcDataRegistro.MaxDate = DateTime.Now;
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
            if (chbSimVacinado.Checked == true)
            {
                c.Vacinado = true;
            }
            c.IdCao = (new CachorroDAO().lastIdCao()) - 1;

            return c;
        }
            
               
        private void pbCadastrar_MouseHover(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoAlterado;
            lbCadastrar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbCadastrar_MouseLeave(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botao;
            lbCadastrar.BackColor= Color.FromArgb(55, 149, 88);
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
            fmBuscarCachorro busca = new fmBuscarCachorro();
            busca.MdiParent = this.MdiParent;
            busca.Location = new Point(128, 0);
            busca.Show();
            this.Close();
        }

        private void cbPorte_MouseHover(object sender, EventArgs e)
        {
            rtbPortes.Visible = true;
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void cbPorte_MouseLeave(object sender, EventArgs e)
        {
            rtbPortes.Visible = false;
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbNomeCachorro.Clear();
            cbRaca.SelectedIndex = 0;
            cbBairro.SelectedIndex = 0;
            cbIdade.SelectedIndex = 0;            
            cbCor.SelectedIndex = -0;
            cbPorte.SelectedIndex = 0;
            mcDataRegistro.Hide();
            mtbDataRegistro.Text = DateTime.Today.ToString("dd/MMm/yyyy");
            chbSimVacinado.Checked = false;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(tbNomeCachorro.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do Cachorro.", "Atençao", MessageBoxButtons.OK);
            }
            else
            {
                Cachorro cachorro = pegaCachorro();

                CachorroDAO cachorrodao = new CachorroDAO();
                cachorrodao.Criar(cachorro);

                MessageBox.Show("Cachorro cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);

                List<Pessoa> lista = new PessoaDAO().ListaPessoaInteressada(pegaCachorro().Porte);
                if (lista.Count != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Existem " + lista.Count + " pessoa(s) interessada(s) nesse cachorro\nRealizar Adoção agora?", "Escolha uma opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        fmPessoasQuerendoCao fmPessoaInt = new fmPessoasQuerendoCao(pegaCachorro());
                        fmPessoaInt.Show();
                        fmPessoaInt.MdiParent = MdiParent;
                        fmPessoaInt.Location = new Point(128, 0);
                        btCancelar.PerformClick();
                    }
                }

                btCancelar.PerformClick();
            }
            
        }

        private void cbRaca_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void cbBairro_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void cbIdade_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void rbFemea_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void rbMacho_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void cbCor_Click(object sender, EventArgs e)
        {
            if (mcDataRegistro.Visible == true)
            {
                mcDataRegistro.Visible = false;
            }
        }

        private void mcDataRegistro_MouseLeave(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = false;
        }

        private void tbNomeCachorro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) ||  char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
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

        private void mtbDataRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
    }
}
