using MySql.Data.MySqlClient;
using Propet;
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
    public partial class frRelatEstoque : Form
    {
        public frRelatEstoque()
        {
            InitializeComponent();
        }

        private void frRelatEstoque_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM estoque;";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            propetDataSet ds = new propetDataSet();

            ds.Clear();
            da.Fill(ds, "estoque");
            crEstoque report = new crEstoque();
            report.SetDataSource(ds);

            crystVEstoque.ReportSource = report;
            conn.Close();
        }
    }
}
