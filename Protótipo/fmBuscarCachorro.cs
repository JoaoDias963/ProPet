using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo
{
    public partial class fmBuscarCachorro : Form
    {
        public fmBuscarCachorro()
        {
            InitializeComponent();           
            cbPorte.SelectedIndex = -1;
            CachorroDAO cachorroDAO = new CachorroDAO();
            List<Cachorro> listaCachorros = cachorroDAO.ListaTodos();

            dgvCachorros.DataSource = listaCachorros;
            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            CachorroDAO cachorroDAO = new CachorroDAO();

            if (chbFemea.Checked == true && chbPorte.Checked == false )
            {
                List<Cachorro> listaCachorros = cachorroDAO.ListaGenero('F');

                dgvCachorros.DataSource = listaCachorros;
            }
            else if(chbMacho.Checked == true && chbPorte.Checked == false )
            {
                List<Cachorro> listaCachorros = cachorroDAO.ListaGenero('M');

                dgvCachorros.DataSource = listaCachorros;
            }
            else if (chbPorte.Checked == true && chbFemea.Checked == false && chbMacho.Checked==false )
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Cachorro> listaCachorros = cachorroDAO.ListaPorte(cbPorte.SelectedItem.ToString());

                    dgvCachorros.DataSource = listaCachorros;
                }
                

            }else if (chbSimFalecidos.Checked == true && chbFemea.Checked == false && chbMacho.Checked == false && chbPorte.Checked == false)
            {
                List<Cachorro> listaCachorros = cachorroDAO.ListaFalecidos();
                dgvCachorros.DataSource = listaCachorros;
            }
            else if(chbFemea.Checked ==true && chbPorte.Checked==true )
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Cachorro> listaCachorros = cachorroDAO.ListaGeneroPorte('F', cbPorte.SelectedItem.ToString());
                    dgvCachorros.DataSource = listaCachorros;
                }
            }
                
            else if(chbMacho.Checked == true && chbPorte.Checked == true)
            {
                if (cbPorte.SelectedIndex != -1)
                {
                    List<Cachorro> listaCachorros = cachorroDAO.ListaGeneroPorte('M', cbPorte.SelectedText);
                    dgvCachorros.DataSource = listaCachorros;
                }
                
            }else if(chbFemea.Checked ==false && chbMacho.Checked == false && chbPorte.Checked == false && chbSimFalecidos.Checked == false)
            {
                List<Cachorro> listaCachorros = cachorroDAO.ListaTodos();
                
                dgvCachorros.DataSource = listaCachorros;
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
            fmCadastrarCachorro cadastro = new fmCadastrarCachorro();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Location = new Point(128, 0);
            cadastro.Show();
        }

        

        
        private void chbPorte_CheckedChanged(object sender, EventArgs e)
        {

           
            if(chbPorte.Checked == false)
            {
                cbPorte.SelectedIndex = -1;
                cbPorte.Enabled = false;
            }
            else
            {
                cbPorte.Enabled = true;
                chbSimFalecidos.Checked = false;
            }
           
        }

        
      

        private void chbFemea_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFemea.Checked == true)
            {
                chbMacho.Checked = false;
                chbSimFalecidos.Checked = false;
                
                atualizaDataGrid();
            }else            
            {              
                atualizaDataGrid();
            }
        }

        private void chbMacho_CheckedChanged(object sender, EventArgs e)
        {

            if (chbMacho.Checked == true)
            {
                chbFemea.Checked = false;
                chbSimFalecidos.Checked = false;
                atualizaDataGrid();
            }else            
            {              
                atualizaDataGrid();
            }
        }

        private void btDetalhes_Click(object sender, EventArgs e)
        {
            fmDetalhesCachorro detalhes = new fmDetalhesCachorro((Cachorro)dgvCachorros.CurrentRow.DataBoundItem);
            detalhes.Show();
            detalhes.MdiParent = MdiParent;
            detalhes.Location = new Point(128, 0);
            this.Close();
        }

        private void cbRacaSelecionada(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }

        private void cbPorteSelecionado(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }

        private void tbPesquisarEscrevendo(object sender, EventArgs e)
        {
            CachorroDAO cachorroDAO = new CachorroDAO();
            List<Cachorro> listaCachorros = cachorroDAO.ListaPesquisa(tbPesquisar.Text);

            dgvCachorros.DataSource = listaCachorros;

        }

        private void chbSimFalecidos_CheckedChanged(object sender, EventArgs e)
        {
            if ( chbSimFalecidos.Checked == true)
            {
                falecidoDataGridViewCheckBoxColumn.Visible = true;
                chbFemea.Checked = false;
                chbMacho.Checked = false;                
                chbPorte.Checked = false;
                atualizaDataGrid();
            }
            else
            {
                falecidoDataGridViewCheckBoxColumn.Visible = false;
                atualizaDataGrid();
            }
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
