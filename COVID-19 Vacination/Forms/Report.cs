using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace COVID_19_Vacination.Forms
{
    public partial class Report : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=covid-19;uid=root;pwd='';CharSet=utf8");
        MySqlCommand cmd;
        MySqlDataAdapter dr;
        string date1;
        string date2;
        string date3;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;


            DataTable dt = new DataTable();

            cmd = new MySqlCommand("SELECT * FROM patient WHERE Date1 between '" + date1 + "' and '" + date2 + "' ", con);
            dr = new MySqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport1 cr = new CrystalReport1();
            cr.Database.Tables["patient"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;

            con.Close();
        }

        private void btnDailyVView_Click(object sender, EventArgs e)
        {


            DateTime dtdate1 = DateTime.Parse(dateTimePicker3.Text);

            con.Open();

            DataTable dt = new DataTable();

            cmd = new MySqlCommand("SELECT * FROM patient WHERE Date1 =  '" + dtdate1.ToString("yyyy-MM-dd") + "'", con);
            dr = new MySqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport1 cr = new CrystalReport1();
            cr.Database.Tables["patient"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;

            con.Close();
        }
    }
}
