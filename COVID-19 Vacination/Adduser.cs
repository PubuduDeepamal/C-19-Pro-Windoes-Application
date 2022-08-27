using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COVID_19_Vacination
{
    public partial class Adduser : Form
    {
        function fn = new function();
        String query;

        public Adduser()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themecolor.primaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = Themecolor.secondaryColor;

                }
            }
            //lblList.ForeColor = Themecolor.secondaryColor;
        }

        private void clear()
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
         
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into admin values('" + txtUserID.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                fn.setData(query);

                MessageBox.Show(" User Add succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There is a problem. Please contact the Software Engineer");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = " delete  from admin where userid = '" + txtUserID.Text + "' ";

                fn.setData(query);

                MessageBox.Show(" User Delete succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clear();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There is a problem. Please contact the Software Engineer");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update admin set username	 ='" + txtUsername.Text + "', password ='" + txtPassword.Text + "' where userid  ='" + txtUserID.Text + "'";
                fn.setData(query);

                MessageBox.Show(" User Update succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clear();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There is a problem. Please contact the Software Engineer");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            Admin();
        }

        private void Admin()
        {

            MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
            con.Open();


            if (txtUserID.Text != "")
            {

                MySqlCommand cmd = new MySqlCommand("Select username,password from admin where userid =@ID", con);
                cmd.Parameters.AddWithValue("@ID", (txtUserID.Text));
                MySqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtUsername.Text = da.GetValue(0).ToString();
                    txtPassword.Text = da.GetValue(1).ToString();
                    

                }
                con.Close();
            }

        }
    }
}
