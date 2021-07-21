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
    public partial class frRelatAdocao : Form
    {
        public frRelatAdocao()
        {
            InitializeComponent();
        }

        private void frRelatAdocao_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM adocao;";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            propetDataSet ds = new propetDataSet();

            ds.Clear();
            da.Fill(ds, "adocao");
            crAdocao report = new crAdocao();
            report.SetDataSource(ds);

            crystVAdocao.ReportSource = report;
            conn.Close();
            }
        }
    }

