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
    public partial class AddStaff : Form
    {
        MySqlConnection con = new MySqlConnection ("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
        MySqlCommand cm = new MySqlCommand();

        public AddStaff()
        {
            InitializeComponent();
            
           
        }

        private void AddStaff_Load(object sender, EventArgs e)
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

        

        private void clear()
        {
            txtAddress.Clear();
            txtIdNo.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtTlephone.Clear();
            txtUsername.Clear();
            guna2ComboBoxPosition.SelectedIndex = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new MySqlCommand("insert into staff values(@Name,@ID_NO,@Address,@Tlephone,@Position,@Username,@Password)", con);
                cm.Parameters.AddWithValue("@Name", txtName.Text);
                cm.Parameters.AddWithValue("@ID_NO", txtIdNo.Text);
                cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                cm.Parameters.AddWithValue("@Tlephone", txtTlephone.Text);
                cm.Parameters.AddWithValue("@Position", guna2ComboBoxPosition.Text);
                cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                cm.Parameters.AddWithValue("@Password", txtPassword.Text);

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("STAFF DATA ADD SUCCESFULLY...!");
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
                cm = new MySqlCommand("update staff set Name = @Name, Address = @Address, Tlephone = @Tlephone, Position = @Position, Username = @Username, Password = @Password where ID_NO = '"+ txtIdNo.Text +"' ", con);
                cm.Parameters.AddWithValue("@Name", txtName.Text);
                cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                cm.Parameters.AddWithValue("@Tlephone", txtTlephone.Text);
                cm.Parameters.AddWithValue("@Position", guna2ComboBoxPosition.Text);
                cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                cm.Parameters.AddWithValue("@Password", txtPassword.Text);

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("STAFF DATA UPDATE SUCCESFULLY...!");
                this.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There is a problem. Please contact the Software Engineer");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIdNo.Focus();
            }
        }

        private void txtIdNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTlephone.Focus();
            }
        }

        private void txtTlephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2ComboBoxPosition.Focus();
            }
        }

        private void guna2ComboBoxPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
            }
            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd_Click(sender, e);
                txtName.Focus();
                clear();
            }
        }
    }
}
