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
    public partial class Dashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form ActiveForm;

        public Dashboard()
        {
            InitializeComponent();
            random = new Random();
            btncloseform.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //Methods
        private Color SeleteThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(Themecolor.ColorList.Count);
            }
            tempindex = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SeleteThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitlebar.BackColor = color;
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    Themecolor.primaryColor = color;
                    Themecolor.secondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    btncloseform.Visible = true;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(29, 17, 52);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActivateButton(btnSender);
            ActiveForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDextop.Controls.Add(childform);
            this.panelDextop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Staff(), sender);
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Patient(), sender);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Viewpatient(), sender);
        }

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Sendmail(), sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Report(), sender);
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitlebar.BackColor = Color.FromArgb(5, 152, 98);
            panellogo.BackColor = Color.FromArgb(0, 0, 39);
            currentButton = null;
            btncloseform.Visible = false;
        }

        private void btncloseform_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            Reset();
            totalCustomer();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Login.Username;

            timer1.Start();
            label5.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbltime.Text = DateTime.Now.ToLongTimeString();

           
            totalCustomer();
        }


        private void totalCustomer()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; database = covid-19; uid = root; pwd = ''; CharSet = utf8");
            con.Open();
            DateTime dtdate1 = DateTime.Parse(label5.Text);



            MySqlCommand cmd = new MySqlCommand("SELECT count(ID) FROM patient WHERE Date1 =  '" + dtdate1.ToString("yyyy-MM-dd") + "'", con);


            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            lblTotalCustomer.Text = dt.Rows[0][0].ToString();
            con.Close();


        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video a = new Video();
            a.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             Login a = new Login();
             a.Show();
             this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
