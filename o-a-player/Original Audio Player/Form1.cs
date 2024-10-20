using System.Drawing;
using System.Drawing.Printing;
using System.Media;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using WMPLib;
using NReco.VideoConverter;
using System.Security.Policy;


namespace Original_Audio_Player
{


    public partial class Form1 : Form
    {


        int xizao;
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private double totalDuration;

        public Form1()
        {


            InitializeComponent();

            xizao = 0;

            trackBar1.Value = 5;
            wmp.settings.volume = 50;




        }




        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();




        }





        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            wmp.URL = (openFileDialog1.FileName);

            string path3 = (openFileDialog1.FileName);
            string file3 = Path.GetFileName(path3);
            title.Text = (file3); // èoóÕó·ÅFindex.html
            icon.Image = Properties.Resources.âπïÑ;

            wmp.controls.play();

        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splash_img.Image = Properties.Resources.splash_2;
            splash_img.Location = new Point(0, 2);
            splash_img.Name = "splash_img";
            splash_img.Size = new Size(1186, 605);
            splash_img.TabIndex = 14;
            splash_img.TabStop = false;

            timer2.Interval = 1400;
            timer2.Start();

            icon.BackColor = Color.FromArgb(48, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(48, 0, 0, 0);
            control.BackColor = Color.FromArgb(48, 0, 0, 0);
            title.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            wmp.controls.currentPosition -= 10;


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            wmp.controls.currentPosition += 10;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.settings.volume -= 10;
            trackBar1.Value -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmp.settings.volume += 10;
            trackBar1.Value += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            splash_img.Visible = false;
            timer2.Stop();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            messagebox.Visible = true;
            messagebox.Location = new Point(118, 67);
            close_kasutamu.Location = new Point(800, 67);
            close_kasutamu.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.stop;
            pictureBox6.Image = Properties.Resources.start;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.blue_stop;
            pictureBox6.Image = Properties.Resources.blue_start;
        }

        private void close_kasutamu_Click(object sender, EventArgs e)
        {
            messagebox.Visible = false;
            close_kasutamu.Visible = false;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.umaidango_15_4_;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.obu_3;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }
    }
}


