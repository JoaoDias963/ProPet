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
    public partial class fmBuscarPessoas : Form
    {
        public fmBuscarPessoas()
        {
            InitializeComponent();
            cbPorte.SelectedIndex = -1;
            
        }

        private void atualizaDataGrid()
        {
            PessoaDAO pessoaDAO = new PessoaDAO();

            if (chbAdotar.Checked == true && chbPorte.Checked == false && cbSim.Checked==false)
            {
                List<Pessoa> lista = pessoaDAO.ListaInteresse("Adotar");
                dgvPessoas.DataSource = lista;
            }
            else if ( chbDoar.Checked == true && chbPorte.Checked == false && cbSim.Checked == false)
            {
                List<Pessoa> lista = pessoaDAO.ListaInteresse("Doar");
                dgvPessoas.DataSource = lista;
            }
            else if (chbPorte.Checked == true && cbSim.Checked == false && chbAdotar.Checked == false && chbDoar.Checked == false)
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Pessoa> lista = pessoaDAO.ListaPorteInteresse(cbPorte.SelectedItem.ToString());
                    dgvPessoas.DataSource = lista;
                }
            }
            else if (cbSim.Checked == true)
            {
                List<Pessoa> lista = pessoaDAO.ListaSemInteresse('S');
                dgvPessoas.DataSource = lista;
            }
            else if (chbAdotar.Checked == true && chbPorte.Checked == true)
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Pessoa> lista = pessoaDAO.ListaInteressePorte("Adotar", cbPorte.SelectedItem.ToString());
                    dgvPessoas.DataSource = lista;
                }
            }
            else if (chbDoar.Checked == true && chbPorte.Checked == true)
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Pessoa> lista = pessoaDAO.ListaInteressePorte("Doar", cbPorte.SelectedItem.ToString());
                    dgvPessoas.DataSource = lista;
                }          
            }
            else if (chbDoar.Checked == false && chbPorte.Checked == false && cbSim.Checked == false)
            {
                List<Pessoa> lista = pessoaDAO.ListaTodos();
                dgvPessoas.DataSource = lista;
            }
        }
            
            

        private void pbBuscar_MouseHover(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botaoAlterado;
            lbBuscar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbBuscar_MouseLeave(object sender, EventArgs e)
        {
            pbBuscar.Image = Properties.Resources.botao;
            lbBuscar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void pbCadastrar_MouseHover(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoAlteradoNaoSelecionado;
            lbCadastrar.BackColor = Color.FromArgb(0, 162, 232);
        }

        private void pbCadastrar_MouseLeave(object sender, EventArgs e)
        {
            pbCadastrar.Image = Properties.Resources.botaoNormal;
            lbCadastrar.BackColor = Color.FromArgb(55, 149, 88);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void pbCadastrar_Click(object sender, EventArgs e)
        {
            fmCadastrarPessoas cadastro = new fmCadastrarPessoas();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Location = new Point(128, 0);
            cadastro.Show();
            this.Close();
        }

       

        private void chbPorte_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPorte.Checked == true)
            {
                cbPorte.Enabled = true;
            }
            else
            {
                cbPorte.Enabled = false;
                cbPorte.SelectedIndex = -1;
            }
        }



        private void pbBuscar_Click(object sender, EventArgs e)
        {
            fmBuscarPessoas buscar = new fmBuscarPessoas();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void chbAdotar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdotar.Checked == true)
            {
                chbDoar.Checked = false;
                cbSim.Checked = false;
                atualizaDataGrid();
            }
            else
                atualizaDataGrid();
        }

        private void chbDoar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDoar.Checked == true)
            {
                chbAdotar.Checked = false;
                cbSim.Checked = false;
                atualizaDataGrid();
            }
            else
                atualizaDataGrid();
        }

        private void chbInteresse_CheckStateChanged(object sender, EventArgs e)
        {
            
            atualizaDataGrid();
        }

        private void btDetalhes_Click(object sender, EventArgs e)
        {
            
            fmDetalhesPessoas pessoas = new fmDetalhesPessoas((Pessoa)dgvPessoas.CurrentRow.DataBoundItem);
            pessoas.Show();
            pessoas.MdiParent = MdiParent;
            pessoas.Location = new Point(128, 0);
            
        }

        private void fmBuscarPessoas_Load(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            List<Pessoa> lista = pessoaDAO.ListaTodos();

            dgvPessoas.DataSource = lista;
        }

        private void cbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }

        private void cbPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }

        private void PesquisarEscrevendo(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            List<Pessoa> listaPessoas = pessoaDAO.ListaPesquisa(tbPesquisar.Text);

            dgvPessoas.DataSource = listaPessoas;
        }

        private void tbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
            if (tbPesquisar.Text.Length > 20)
            {
                MessageBox.Show("Máximo de 20 caracteres, somente letras são permitidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPesquisar.Text = "";

            }
        }

        private void cbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSim.Checked == true)
            {
                chbAdotar.Checked = false;
                chbDoar.Checked = false;
                chbPorte.Checked = false;
                cbPorte.SelectedIndex = -1;
            
                atualizaDataGrid();
            }
            else
            {
              
                atualizaDataGrid();
            }
            
        }

        private void tbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbPorte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86 || e.Control && e.Alt && e.KeyValue == 220 || e.Control && e.Alt && e.KeyValue == 221 || e.Shift && e.KeyValue == 45)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
