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
    public partial class rtExtrato : Form
    {
        public rtExtrato()
        {
            InitializeComponent();
        }

        private void rtExtrato_Load(object sender, EventArgs e)
        {
            List<Adocao> lista = new AdocaoDAO().ListaPorId(new AdocaoDAO().voltaMaxId());
            List<Cachorro> lista2 = new CachorroDAO().ListaPorId(lista[0].Cachorro.IdCao);
            List<Pessoa> lista3 = new List<Pessoa>();

            Pessoa p = new PessoaDAO().AchaPessoa(lista[0].Pessoa.Cpf);

            lista3.Add(p);

            crExtrato report = new crExtrato();

            report.Database.Tables[0].SetDataSource(lista);
            report.Database.Tables[1].SetDataSource(lista2);
            report.Database.Tables[2].SetDataSource(lista3);

            crystExtrato.ReportSource = report;
        }
    }
}
