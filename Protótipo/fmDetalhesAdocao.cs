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
    public partial class fmDetalhesAdocao : Form
    {
        public fmDetalhesAdocao()
        {
            InitializeComponent();
            cbBairro.DataSource = Enum.GetNames(typeof(fmCadastrarCachorro.Bairro));
            cbBairroCachorro.DataSource = Enum.GetNames(typeof(fmCadastrarCachorro.Bairro));
            cbRaca.DataSource = Enum.GetNames(typeof(fmCadastrarCachorro.Raca));
            cbRacaCachorro.DataSource = Enum.GetNames(typeof(fmCadastrarCachorro.Raca));
            cbCorCachorro.SelectedIndex = -1;
            cbIdadeCachorro.SelectedIndex = -1;
            cbPorte.SelectedIndex = -1;
            cbPorteCachorro.SelectedIndex = -1;
            cbBairro.SelectedIndex = -1;
            cbBairroCachorro.SelectedIndex = -1;
            cbRaca.SelectedIndex = -1;
            cbRacaCachorro.SelectedIndex = -1;

        }

        private void chbPessoas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPessoas.Checked == true)
            {
                chbData.Checked = false;
                chbCachorro.Checked = false;

                gbPessoas.Visible = true;
                lbNome.Visible = true;
                tbNome.Visible = true;
                lbCpf.Visible = true;
                mtbCpf.Visible = true;
                lbEndereco.Visible = true;
                tbEndereco.Visible = true;
                lbNumero.Visible = true;
                tbNumero.Visible = true;
                lbApartamento.Visible = true;
                pnApartamento.Visible = true;
                rbSim.Visible = true;
                rbNão.Visible = true;
                lbBloco.Visible = true;
                tbBloco.Visible = true;
                lbApto.Visible = true;
                tbApto.Visible = true;
                lbBairro.Visible = true;
                cbBairro.Visible = true;
                lbCep.Visible = true;
                mtbCep.Visible = true;
                lbCidade.Visible = true;
                tbCidade.Visible = true;
                lbTelefone.Visible = true;
                mtbTelefone.Visible = true;
                lbCelular.Visible = true;
                mtbCelular.Visible = true;
                lbEmail.Visible = true;
                tbEmail.Visible = true;
                lbInteresse.Visible = true;
                pnInteresse.Visible = true;
                rbSimInteresse.Visible = true;
                rbNaoInteresse.Visible = true;
                lbRacaEspecifica.Visible = true;
                pnRacaEspecifica.Visible = true;
                rbSimRaca.Visible = true;
                rbNaoRaca.Visible = true;
                lbRaca.Visible = true;
                cbRaca.Visible = true;
                lbPorte.Visible = true;
                cbPorte.Visible = true;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;
            }
            else
            {
                gbPessoas.Visible = false;
                lbNome.Visible = false;
                tbNome.Visible = false;
                lbCpf.Visible = false;
                mtbCpf.Visible = false;
                lbEndereco.Visible = false;
                tbEndereco.Visible = false;
                lbNumero.Visible = false;
                tbNumero.Visible = false;
                lbApartamento.Visible = false;
                rbSim.Visible = false;
                rbNão.Visible = false;
                lbBloco.Visible = false;
                tbBloco.Visible = false;
                lbApto.Visible = false;
                tbApto.Visible = false;
                lbBairro.Visible = false;
                cbBairro.Visible = false;
                lbCep.Visible = false;
                mtbCep.Visible = false;
                lbCidade.Visible = false;
                tbCidade.Visible = false;
                lbTelefone.Visible = false;
                mtbTelefone.Visible = false;
                lbCelular.Visible = false;
                mtbCelular.Visible = false;
                lbEmail.Visible = false;
                tbEmail.Visible = false;
                lbInteresse.Visible = false;
                rbSimInteresse.Visible = false;
                rbNaoInteresse.Visible = false;
                lbRacaEspecifica.Visible = false;
                rbSimRaca.Visible = false;
                rbNaoRaca.Visible = false;
                lbRaca.Visible = false;
                cbRaca.Visible = false;
                lbPorte.Visible = false;
                cbPorte.Visible = false;
                pnRacaEspecifica.Visible = false;
                pnInteresse.Visible = false;
                pnApartamento.Visible = false;

                gbCachorro.Visible = false;
                lbNomeCachorro.Visible = false;
                tbNomeCachorro.Visible = false;
                lbRacaCachorro.Visible = false;
                cbRacaCachorro.Visible = false;
                lbBairroCachorro.Visible = false;
                cbBairroCachorro.Visible = false;
                lbIdadeCachorro.Visible = false;
                cbIdadeCachorro.Visible = false;
                lbGeneroCachorro.Visible = false;
                rbFemea.Visible = false;
                rbMacho.Visible = false;
                lbCorCachorro.Visible = false;
                cbCorCachorro.Visible = false;
                lbPorteCachorro.Visible = false;
                cbPorteCachorro.Visible = false;
                lbDataRegistroCachorro.Visible = false;
                mtbDataRegistro.Visible = false;

                gbData.Visible = false;
                lbDataAdocao.Visible = false;
                mtbDataAdocao.Visible = false;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;
            }



        }

        private void cbPorte_Click(object sender, EventArgs e)
        {
            rtbPortes.Visible = true;
        }

        private void rtbPortes_MouseLeave(object sender, EventArgs e)
        {
            rtbPortes.Visible = false;

        }

        private void mtbDataRegistro_MouseHover(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = true;
        }

        private void mtbDataRegistro_MouseLeave(object sender, EventArgs e)
        {
            mcDataRegistro.Visible = false;
        }

        private void mcDataRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbDataRegistro.Text = mcDataRegistro.SelectionStart.ToString("dd/MM/yyyy");
            mcDataRegistro.Visible = false;
        }

        private void chbCachorro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCachorro.Checked == true)
            {
                chbData.Checked = false;
                chbPessoas.Checked = false;

                gbCachorro.Visible = true;
                lbNomeCachorro.Visible = true;
                tbNomeCachorro.Visible = true;
                lbRacaCachorro.Visible = true;
                cbRacaCachorro.Visible = true;
                lbBairroCachorro.Visible = true;
                cbBairroCachorro.Visible = true;
                lbIdadeCachorro.Visible = true;
                cbIdadeCachorro.Visible = true;
                lbGeneroCachorro.Visible = true;
                rbFemea.Visible = true;
                rbMacho.Visible = true;
                lbCorCachorro.Visible = true;
                cbCorCachorro.Visible = true;
                lbPorteCachorro.Visible = true;
                cbPorteCachorro.Visible = true;
                lbDataRegistroCachorro.Visible = true;
                mtbDataRegistro.Visible = true;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;

            }
            else
            {
                gbPessoas.Visible = false;
                lbNome.Visible = false;
                tbNome.Visible = false;
                lbCpf.Visible = false;
                mtbCpf.Visible = false;
                lbEndereco.Visible = false;
                tbEndereco.Visible = false;
                lbNumero.Visible = false;
                tbNumero.Visible = false;
                lbApartamento.Visible = false;
                rbSim.Visible = false;
                rbNão.Visible = false;
                lbBloco.Visible = false;
                tbBloco.Visible = false;
                lbApto.Visible = false;
                tbApto.Visible = false;
                lbBairro.Visible = false;
                cbBairro.Visible = false;
                lbCep.Visible = false;
                mtbCep.Visible = false;
                lbCidade.Visible = false;
                tbCidade.Visible = false;
                lbTelefone.Visible = false;
                mtbTelefone.Visible = false;
                lbCelular.Visible = false;
                mtbCelular.Visible = false;
                lbEmail.Visible = false;
                tbEmail.Visible = false;
                lbInteresse.Visible = false;
                rbSimInteresse.Visible = false;
                rbNaoInteresse.Visible = false;
                lbRacaEspecifica.Visible = false;
                rbSimRaca.Visible = false;
                rbNaoRaca.Visible = false;
                lbRaca.Visible = false;
                cbRaca.Visible = false;
                lbPorte.Visible = false;
                cbPorte.Visible = false;
                pnRacaEspecifica.Visible = false;
                pnInteresse.Visible = false;
                pnApartamento.Visible = false;

                gbCachorro.Visible = false;
                lbNomeCachorro.Visible = false;
                tbNomeCachorro.Visible = false;
                lbRacaCachorro.Visible = false;
                cbRacaCachorro.Visible = false;
                lbBairroCachorro.Visible = false;
                cbBairroCachorro.Visible = false;
                lbIdadeCachorro.Visible = false;
                cbIdadeCachorro.Visible = false;
                lbGeneroCachorro.Visible = false;
                rbFemea.Visible = false;
                rbMacho.Visible = false;
                lbCorCachorro.Visible = false;
                cbCorCachorro.Visible = false;
                lbPorteCachorro.Visible = false;
                cbPorteCachorro.Visible = false;
                lbDataRegistroCachorro.Visible = false;
                mtbDataRegistro.Visible = false;

                gbData.Visible = false;
                lbDataAdocao.Visible = false;
                mtbDataAdocao.Visible = false;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;

            }
        }

        private void cbPorteCachorro_MouseHover(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = true;

        }

        private void cbPorteCachorro_MouseLeave(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = false;
        }

        private void cbPorteCachorro_Click(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = true;
        }

        private void cbPorteCachorro_SelectedValueChanged(object sender, EventArgs e)
        {
            rtbPorteCachorro.Visible = false;
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbData.Visible = true;
            //Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (chbPessoas.Checked == true)
            {
                tbNome.ReadOnly = false;

                mtbCpf.ResetText();

                tbEndereco.ReadOnly = false;

                tbNumero.ReadOnly = false;

                rbSim.Checked = false;
                rbNão.Checked = false;

                tbBloco.ReadOnly = false;

                tbApto.ReadOnly = false;

                cbBairro.SelectedIndex = -1;

                mtbCep.ReadOnly = false;

                tbCidade.ReadOnly = false;

                mtbTelefone.ReadOnly = false;

                mtbCelular.ReadOnly = false;

                tbEmail.ReadOnly = false;

                rbSimInteresse.Checked = false;
                rbNaoInteresse.Checked = false;

                rbSimRaca.Checked = false;
                rbNaoRaca.Checked = false;

                cbRaca.SelectedIndex = -1;

                cbPorte.SelectedIndex = -1;

            }
            else if (chbCachorro.Checked == true)
            {

                tbNomeCachorro.ReadOnly = false;

                cbRacaCachorro.SelectedIndex = -1;

                cbBairroCachorro.SelectedIndex = -1;

                cbIdadeCachorro.SelectedIndex = -1;

                rbFemea.Checked = false;
                rbMacho.Checked = false;

                cbCorCachorro.SelectedIndex = -1;

                cbPorteCachorro.SelectedIndex = -1;

                mtbDataRegistro.ReadOnly = false;
            }
            else if (chbData.Checked == true)
            {
                mtbDataAdocao.ReadOnly = false;
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterações salvas com sucesso!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            Close();
        }

        private void chbData_CheckedChanged(object sender, EventArgs e)
        {
            if (chbData.Checked == true)
            {
                chbPessoas.Checked = false;
                chbCachorro.Checked = false;


                gbData.Visible = true;
                lbDataAdocao.Visible = true;
                mcDataAdocao.Visible = true;
            
                gbPessoas.Visible = false;
                lbNome.Visible = false;
                tbNome.Visible = false;
                lbCpf.Visible = false;
                mtbCpf.Visible = false;
                lbEndereco.Visible = false;
                tbEndereco.Visible = false;
                lbNumero.Visible = false;
                tbNumero.Visible = false;
                lbApartamento.Visible = false;
                rbSim.Visible = false;
                rbNão.Visible = false;
                lbBloco.Visible = false;
                tbBloco.Visible = false;
                lbApto.Visible = false;
                tbApto.Visible = false;
                lbBairro.Visible = false;
                cbBairro.Visible = false;
                lbCep.Visible = false;
                mtbCep.Visible = false;
                lbCidade.Visible = false;
                tbCidade.Visible = false;
                lbTelefone.Visible = false;
                mtbTelefone.Visible = false;
                lbCelular.Visible = false;
                mtbCelular.Visible = false;
                lbEmail.Visible = false;
                tbEmail.Visible = false;
                lbInteresse.Visible = false;
                rbSimInteresse.Visible = false;
                rbNaoInteresse.Visible = false;
                lbRacaEspecifica.Visible = false;
                rbSimRaca.Visible = false;
                rbNaoRaca.Visible = false;
                lbRaca.Visible = false;
                cbRaca.Visible = false;
                lbPorte.Visible = false;
                cbPorte.Visible = false;
                pnRacaEspecifica.Visible = false;
                pnInteresse.Visible = false;
                pnApartamento.Visible = false;

                gbCachorro.Visible = false;
                lbNomeCachorro.Visible = false;
                tbNomeCachorro.Visible = false;
                lbRacaCachorro.Visible = false;
                cbRacaCachorro.Visible = false;
                lbBairroCachorro.Visible = false;
                cbBairroCachorro.Visible = false;
                lbIdadeCachorro.Visible = false;
                cbIdadeCachorro.Visible = false;
                lbGeneroCachorro.Visible = false;
                rbFemea.Visible = false;
                rbMacho.Visible = false;
                lbCorCachorro.Visible = false;
                cbCorCachorro.Visible = false;
                lbPorteCachorro.Visible = false;
                cbPorteCachorro.Visible = false;
                lbDataRegistroCachorro.Visible = false;
                mtbDataRegistro.Visible = false;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;

            }
            else
            {
                gbData.Visible = false;
                lbDataAdocao.Visible = false;
                mtbDataAdocao.Visible = false;

                gbPessoas.Visible = false;
                lbNome.Visible = false;
                tbNome.Visible = false;
                lbCpf.Visible = false;
                mtbCpf.Visible = false;
                lbEndereco.Visible = false;
                tbEndereco.Visible = false;
                lbNumero.Visible = false;
                tbNumero.Visible = false;
                lbApartamento.Visible = false;
                rbSim.Visible = false;
                rbNão.Visible = false;
                lbBloco.Visible = false;
                tbBloco.Visible = false;
                lbApto.Visible = false;
                tbApto.Visible = false;
                lbBairro.Visible = false;
                cbBairro.Visible = false;
                lbCep.Visible = false;
                mtbCep.Visible = false;
                lbCidade.Visible = false;
                tbCidade.Visible = false;
                lbTelefone.Visible = false;
                mtbTelefone.Visible = false;
                lbCelular.Visible = false;
                mtbCelular.Visible = false;
                lbEmail.Visible = false;
                tbEmail.Visible = false;
                lbInteresse.Visible = false;
                rbSimInteresse.Visible = false;
                rbNaoInteresse.Visible = false;
                lbRacaEspecifica.Visible = false;
                rbSimRaca.Visible = false;
                rbNaoRaca.Visible = false;
                lbRaca.Visible = false;
                cbRaca.Visible = false;
                lbPorte.Visible = false;
                cbPorte.Visible = false;
                pnRacaEspecifica.Visible = false;
                pnInteresse.Visible = false;
                pnApartamento.Visible = false;

                gbCachorro.Visible = false;
                lbNomeCachorro.Visible = false;
                tbNomeCachorro.Visible = false;
                lbRacaCachorro.Visible = false;
                cbRacaCachorro.Visible = false;
                lbBairroCachorro.Visible = false;
                cbBairroCachorro.Visible = false;
                lbIdadeCachorro.Visible = false;
                cbIdadeCachorro.Visible = false;
                lbGeneroCachorro.Visible = false;
                rbFemea.Visible = false;
                rbMacho.Visible = false;
                lbCorCachorro.Visible = false;
                cbCorCachorro.Visible = false;
                lbPorteCachorro.Visible = false;
                cbPorteCachorro.Visible = false;
                lbDataRegistroCachorro.Visible = false;
                mtbDataRegistro.Visible = false;

                cbCorCachorro.SelectedIndex = -1;
                cbIdadeCachorro.SelectedIndex = -1;
                cbPorte.SelectedIndex = -1;
                cbPorteCachorro.SelectedIndex = -1;
                cbBairro.SelectedIndex = -1;
                cbBairroCachorro.SelectedIndex = -1;
                cbRaca.SelectedIndex = -1;
                cbRacaCachorro.SelectedIndex = -1;
            }
        }
    }
}
