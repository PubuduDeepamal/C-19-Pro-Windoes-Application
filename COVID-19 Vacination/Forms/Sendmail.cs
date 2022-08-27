using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Threading;
using MailKit.Net.Smtp;

namespace COVID_19_Vacination.Forms
{
    public partial class Sendmail : Form
    {
        function fn = new function();
        string query;

        public Sendmail()
        {
            InitializeComponent();
        }

        private void Sendmail_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select Email from patient where Date1 = '" + dateTimePicker1.Text + "'";


            listBoxEMails.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxEMails.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            buttonSend.Enabled = false;
            pictureBoxLoading.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonSend.Enabled = true;
            pictureBoxLoading.Visible = false;
            MessageBox.Show("Email Sent Successfully...!");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;


            //declare the smtp object
            SmtpClient client = new SmtpClient();
            client.Timeout = 30000;
            client.AuthenticationMechanisms.Remove("XOAUTH2");

            BodyBuilder builder = new BodyBuilder();
            builder.TextBody = textBoxHTMLBody.Text;

            //Define the mail headers
            MimeMessage mail = new MimeMessage();
            mail.Subject = textBoxSubject.Text;
            mail.Body = builder.ToMessageBody();

            client.Connect(textBoxSMTP.Text, int.Parse(textBoxPORT.Text), checkBoxSSL.Checked);
            client.Authenticate(textBoxUSER.Text, textBoxPASSWORD.Text);



            foreach (string email in listBoxEMails.Items)
            {

                mail.From.Add(new MailboxAddress("COVID-19 Vaccination ", textBoxUSER.Text));
                mail.To.Add(new MailboxAddress(email));
                client.Send(mail);

                Thread.Sleep(1000);

            }

            client.Disconnect(true);


        }
    }
}
