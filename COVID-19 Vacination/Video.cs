using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19_Vacination
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void Video_Load(object sender, EventArgs e)
        {
            Playlist.ValueMember = "path";
            Playlist.DisplayMember = "FileName";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer file = Playlist.SelectedItem as MediaPlayer;
            if(file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaPlayer> files = new List<MediaPlayer>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaPlayer() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });

                    }
                    Playlist.DataSource = files;
                    



                }

            }
        }
    }
}
