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
namespace COVID_19_Vacination.Forms
{
    public partial class print : Form
    {
       

        public print()
        {
            
            InitializeComponent();
            
            category();
            


        }

       

        private void print_Load(object sender, EventArgs e)
        {
            
        }

        


        private void category()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=covid-19;uid=root;pwd='';CharSet=utf8");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from patient ", con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt;


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=covid-19;uid=root;pwd='';CharSet=utf8");
            MySqlCommand cmd;


            MySqlDataAdapter dr;


            con.Open();
            DataTable dt = new DataTable();
            cmd = new MySqlCommand("select * from patient where ID= '" + comboBox1.Text + "' ", con);

            dr = new MySqlDataAdapter(cmd);
            dr.Fill(dt);

            con.Close();

            CrystalReport2 cr = new CrystalReport2();
            cr.Database.Tables["patient"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;

            cr.PrintToPrinter(1, false, 0, 0);
        }
    }
}
