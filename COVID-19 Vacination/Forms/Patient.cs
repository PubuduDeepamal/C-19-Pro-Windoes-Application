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
    public partial class Patient : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;

        public Patient()
        {
            InitializeComponent();
            Loaddata();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            Loaddata();

            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Addpatient a = new Addpatient();
            a.btnadd.Enabled = true;
            a.btnupdate.Enabled = false;
            a.btnclear.Enabled = true;
            a.ShowDialog();
            Loaddata();
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = guna2DataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "edit")
            {
                Addpatient a = new Addpatient();
                a.txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                a.txtIdNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                a.txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                a.txtTlephone.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                a.txtEmail.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                a.guna2ComboBoxvaccine1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                a.guna2ComboBoxvaccine2.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                a.dateTimePicker1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                a.dateTimePicker2.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


                a.btnadd.Enabled = false;
                a.btnupdate.Enabled = true;
                a.txtIdNo.Enabled = false;
                a.ShowDialog();
            }

            else if (colname == "delete")
            {
                con.Open();

                cm = new MySqlCommand("delete from patient where ID = '" + guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'   ", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has Been Succesfully Deleted...!");
            }

            Loaddata();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }

