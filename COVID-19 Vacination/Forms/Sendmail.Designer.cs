namespace COVID_19_Vacination.Forms
{
    partial class Sendmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sendmail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEMails = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHTMLBody = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.checkBoxAUTH = new System.Windows.Forms.CheckBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.textBoxUSER = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPORT = new System.Windows.Forms.TextBox();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Day ";
            // 
            // listBoxEMails
            // 
            this.listBoxEMails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEMails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEMails.FormattingEnabled = true;
            this.listBoxEMails.ItemHeight = 23;
            this.listBoxEMails.Location = new System.Drawing.Point(18, 175);
            this.listBoxEMails.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEMails.Name = "listBoxEMails";
            this.listBoxEMails.Size = new System.Drawing.Size(353, 510);
            this.listBoxEMails.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("CG Times", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 40);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 12, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(167, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 49);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "    SEARCH";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Subject: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Email Body ";
            // 
            // textBoxHTMLBody
            // 
            this.textBoxHTMLBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHTMLBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHTMLBody.Location = new System.Drawing.Point(379, 175);
            this.textBoxHTMLBody.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHTMLBody.Multiline = true;
            this.textBoxHTMLBody.Name = "textBoxHTMLBody";
            this.textBoxHTMLBody.Size = new System.Drawing.Size(234, 511);
            this.textBoxHTMLBody.TabIndex = 47;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject.Location = new System.Drawing.Point(457, 83);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(331, 32);
            this.textBoxSubject.TabIndex = 50;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(815, 542);
            this.pictureBoxLoading.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(379, 124);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 61;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // checkBoxAUTH
            // 
            this.checkBoxAUTH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAUTH.AutoSize = true;
            this.checkBoxAUTH.Checked = true;
            this.checkBoxAUTH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAUTH.Location = new System.Drawing.Point(815, 433);
            this.checkBoxAUTH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxAUTH.Name = "checkBoxAUTH";
            this.checkBoxAUTH.Size = new System.Drawing.Size(190, 21);
            this.checkBoxAUTH.TabIndex = 60;
            this.checkBoxAUTH.Text = "Authentication Required?";
            this.checkBoxAUTH.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(815, 216);
            this.checkBoxSSL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(56, 21);
            this.checkBoxSSL.TabIndex = 59;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(639, 380);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Password:";
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPASSWORD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPASSWORD.Location = new System.Drawing.Point(815, 378);
            this.textBoxPASSWORD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.PasswordChar = '*';
            this.textBoxPASSWORD.Size = new System.Drawing.Size(379, 30);
            this.textBoxPASSWORD.TabIndex = 57;
            // 
            // textBoxUSER
            // 
            this.textBoxUSER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUSER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUSER.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSER.Location = new System.Drawing.Point(815, 312);
            this.textBoxUSER.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxUSER.Name = "textBoxUSER";
            this.textBoxUSER.Size = new System.Drawing.Size(379, 30);
            this.textBoxUSER.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(639, 321);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 55;
            this.label11.Text = "User Name: ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(639, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Port:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(639, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Server IP/Name: ";
            // 
            // textBoxPORT
            // 
            this.textBoxPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPORT.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPORT.Location = new System.Drawing.Point(815, 248);
            this.textBoxPORT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPORT.Name = "textBoxPORT";
            this.textBoxPORT.Size = new System.Drawing.Size(379, 30);
            this.textBoxPORT.TabIndex = 52;
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSMTP.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSMTP.Location = new System.Drawing.Point(815, 170);
            this.textBoxSMTP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(379, 30);
            this.textBoxSMTP.TabIndex = 51;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.Location = new System.Drawing.Point(919, 468);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(137, 53);
            this.buttonSend.TabIndex = 62;
            this.buttonSend.Text = "     SEND";
            this.buttonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Sendmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 708);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.checkBoxAUTH);
            this.Controls.Add(this.checkBoxSSL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.textBoxUSER);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPORT);
            this.Controls.Add(this.textBoxSMTP);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHTMLBody);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxEMails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sendmail";
            this.Text = "Sendmail";
            this.Load += new System.EventHandler(this.Sendmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEMails;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHTMLBody;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.CheckBox checkBoxAUTH;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.TextBox textBoxUSER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPORT;
        private System.Windows.Forms.TextBox textBoxSMTP;
        private System.Windows.Forms.Button buttonSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}