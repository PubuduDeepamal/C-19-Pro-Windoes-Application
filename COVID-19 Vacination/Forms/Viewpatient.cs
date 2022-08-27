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
    public partial class Viewpatient : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        public Viewpatient()
        {
            InitializeComponent();
            Loaddata();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Loaddata()
        {
            int i = 0;
            guna2DataGridView1.Rows.Clear();
            cm = new MySqlCommand("select * from patient", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtIdNoSearch_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                int i = 0;

                con.Open();
                guna2DataGridView1.Rows.Clear();
                cm = new MySqlCommand("select Name,ID,Address,Tlephone,Email,vaccine_1,vaccine_2,Date1,Date2 from patient where ID like '%" + txtIdNoSearch.Text + "%'   ", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                dt.Clear();
                da.Fill(dt);

                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    guna2DataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
                dr.Close();
                con.Close();
                con.Close();
            }
        }
    }
}
