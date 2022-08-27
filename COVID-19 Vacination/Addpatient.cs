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
using COVID_19_Vacination.Forms;
using MySql.Data.MySqlClient;

namespace COVID_19_Vacination
{
    public partial class Addpatient : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
        MySqlCommand cm = new MySqlCommand();

        public int Patient_ID { get; private set; }

        public Addpatient()
        {
            InitializeComponent();
        }

        private void Addpatient_Load(object sender, EventArgs e)
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            txtEmail.Clear();
            txtTlephone.Clear();
            guna2ComboBoxvaccine1.SelectedIndex = -1;
            guna2ComboBoxvaccine2.SelectedIndex = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            
            try
            {


                cm = new MySqlCommand("insert into patient values(@Name,@ID_NO,@Address,@Tlephone,@Email,@vaccine_1,@vaccine_2,@Date1,@Date2)", con);
                cm.Parameters.AddWithValue("@Name", txtName.Text);
                cm.Parameters.AddWithValue("@ID_NO", txtIdNo.Text);
                cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                cm.Parameters.AddWithValue("@Tlephone", txtTlephone.Text);
                cm.Parameters.AddWithValue("@Email", txtEmail.Text);
                cm.Parameters.AddWithValue("@vaccine_1", guna2ComboBoxvaccine1.Text);
                cm.Parameters.AddWithValue("@vaccine_2", guna2ComboBoxvaccine2.Text);
                cm.Parameters.AddWithValue("@Date1", dateTimePicker1.Text);
                cm.Parameters.AddWithValue("@Date2", dateTimePicker2.Text);

                con.Open();


                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("PATIENT DATA ADD SUCCESFULLY...!");
                clear();

                print a = new print();
                a.Show();

                //this.Dispose();

                



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
                cm = new MySqlCommand("update patient set Name = @Name, Address = @Address, Tlephone = @Tlephone, Email = @Email, Vaccine_1 = @vaccine_1, Vaccine_2= @vaccine_2,Date1 = @Date1,Date2= @Date2 where ID = '" + txtIdNo.Text + "' ", con);
                cm.Parameters.AddWithValue("@Name", txtName.Text);
                cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                cm.Parameters.AddWithValue("@Tlephone", txtTlephone.Text);
                cm.Parameters.AddWithValue("@Email", txtEmail.Text);
                cm.Parameters.AddWithValue("@vaccine_1", guna2ComboBoxvaccine1.Text);
                cm.Parameters.AddWithValue("@vaccine_2", guna2ComboBoxvaccine2.Text);
                cm.Parameters.AddWithValue("@Date1", dateTimePicker1.Text);
                cm.Parameters.AddWithValue("@Date2", dateTimePicker2.Text);

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("PATIENT DATA UPDATE SUCCESFULLY...!");
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
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2ComboBoxvaccine1.Focus();
            }
        }

        private void guna2ComboBoxvaccine1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2ComboBoxvaccine2.Focus();
            }
        }

        private void guna2ComboBoxvaccine2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker2.Focus();
            }
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd_Click(sender, e);
                txtName.Focus();
                clear();
            }
        }

        private void txtIdNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.'
                    && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void txtTlephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.'
                    && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
    }
}
