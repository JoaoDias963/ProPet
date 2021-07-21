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
    public partial class fmPessoasQuerendoCao : Form
    {
        Cachorro cachorro;
        public fmPessoasQuerendoCao()
        {
            InitializeComponent();
        }
        public fmPessoasQuerendoCao(object c):this()
        {
            this.cachorro = (Cachorro)c;
        }

        private void fmPessoasQuerendoCao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'propetDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.

            List<Pessoa> listaTodos = new PessoaDAO().ListaTodos();
            List<Pessoa> lista= new List<Pessoa>();

            foreach (Pessoa p in listaTodos)
            {
                if (p.Interesse == "Adotar")
                {
                    if (p.PorteInteresse == "Qualquer Porte")
                    {
                        lista.Add(p);
                    }
                    else
                    {
                        if (p.PorteInteresse == this.cachorro.Porte)
                        {
                            lista.Add(p);
                        }
                    }
                }
            }
            dgvPessoas.DataSource = lista;
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            fmCadastrarAdocao fmAdocao = new Protótipo.fmCadastrarAdocao(this.cachorro,(Pessoa)dgvPessoas.CurrentRow.DataBoundItem);
            fmAdocao.MdiParent = MdiParent;
            fmAdocao.Location = new Point(128, 0);
            fmAdocao.Show();
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
