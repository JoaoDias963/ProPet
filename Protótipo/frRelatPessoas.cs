using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Propet;

namespace Protótipo
{
    public partial class frRelatPessoas : Form
    {
        public frRelatPessoas()
        {
            InitializeComponent();
        }

        private void frRelatPessoas_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM pessoa;";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            propetDataSet ds = new propetDataSet();

            ds.Clear();
            
            da.Fill(ds, "pessoa");
            
            crystPessoas report = new crystPessoas();
            report.SetDataSource(ds);

            crysRPessoa.ReportSource = report;
            conn.Close();
            
        }
    }
}
