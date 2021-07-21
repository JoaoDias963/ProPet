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
    public partial class frRelatCachorros : Form
    {
        public frRelatCachorros()
        {
            InitializeComponent();
        }

        private void frRelatCachorros_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM cachorro;";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            propetDataSet ds = new propetDataSet();

            ds.Clear();
            try
            {
                da.Fill(ds, "cachorro");
            }
            catch (System.Exception)
            {

            }
            finally
            {
                crystCachorros report = new crystCachorros();
                report.SetDataSource(ds);

                crystRepCachorro.ReportSource = report;
                conn.Close();
            }
            
        }
    }
}
