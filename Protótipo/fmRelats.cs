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
    public partial class fmRelats : Form
    {
        public fmRelats()
        {
            InitializeComponent();
        }

        private void btRtCachorro_Click(object sender, EventArgs e)
        {
            frRelatCachorros relatCao = new frRelatCachorros();
            relatCao.Show();
        }

        private void btRtPessoa_Click(object sender, EventArgs e)
        {
            frRelatPessoas relatPessoa = new frRelatPessoas();
            relatPessoa.Show();
        }

        private void btRtAdocao_Click(object sender, EventArgs e)
        {
            frRelatAdocao relatAdocao = new frRelatAdocao();
            relatAdocao.Show();
        }

        private void btRtEstoque_Click(object sender, EventArgs e)
        {
            frRelatEstoque relatEstoque = new frRelatEstoque();
            relatEstoque.Show();
        }
    }
}
