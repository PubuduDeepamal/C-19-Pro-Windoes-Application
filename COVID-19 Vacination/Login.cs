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

namespace COVID_19_Vacination
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Username = "";

        private void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            guna2ComboBoxRole.SelectedIndex = -1;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Your Username Or Password");
            }

            else
            {
                try
                {
                    if (guna2ComboBoxRole.SelectedItem.ToString() == "Admin")
                    {
                        MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");

                        
                        string query1 = "select * from  admin where username ='" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "' ";


                       
                        MySqlDataAdapter cmd1 = new MySqlDataAdapter(query1, con);
                        con.Open();
                        

                        DataTable tb1 = new DataTable();
                        cmd1.Fill(tb1);

                        if (tb1.Rows.Count == 1)
                        {
                            Username = txtUsername.Text;
                            Dashboard a = new Dashboard();
                            a.Show();
                            this.Hide();

                        }

                        
                        else
                        {
                            MessageBox.Show("Check Your Username or Password Again....!");
                        }

                        con.Close();

                    }

                    else if (guna2ComboBoxRole.SelectedItem.ToString() == "User")
                    {
                        MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");

                        string query = "select * from  staff where Username ='" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "' ";

                        MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);

                        con.Open();
                        DataTable tb = new DataTable();
                        cmd.Fill(tb);

                        DataTable tb1 = new DataTable();


                        if (tb.Rows.Count == 1)
                        {
                            Username = txtUsername.Text;
                            User a = new User();
                            a.Show();
                            this.Hide();

                        }

                        else
                        {
                            MessageBox.Show("Check Your Username or Password Again....!");
                        }

                        con.Close();

                    }

                    else
                    {
                        MessageBox.Show("Please Select Role What You Want....!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("There is a problem. Please contact the SW engineer");
                }
            }
        }

        private void guna2ComboBoxRole_KeyDown(object sender, KeyEventArgs e)
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
                btnLog_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
