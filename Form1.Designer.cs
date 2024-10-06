namespace Original_Audio_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            trackBar1 = new TrackBar();
            button2 = new Button();
            button3 = new Button();
            control = new Panel();
            icon = new PictureBox();
            panel1 = new Panel();
            title = new Label();
            splash_img = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox8 = new PictureBox();
            messagebox = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            close_kasutamu = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splash_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            messagebox.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_kasutamu).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OriginalAudioPlayer_logo;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.Location = new Point(0, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1152, 1);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(22, 19);
            button1.Name = "button1";
            button1.Size = new Size(143, 36);
            button1.TabIndex = 2;
            button1.Text = "ファイルを開く";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.stop;
            pictureBox4.Location = new Point(251, 48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(169, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.sa;
            pictureBox3.Location = new Point(179, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.usior;
            pictureBox5.Location = new Point(650, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.start;
            pictureBox6.Location = new Point(440, 48);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(169, 46);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(947, 13);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(155, 45);
            trackBar1.TabIndex = 8;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // button2
            // 
            button2.Location = new Point(910, 12);
            button2.Name = "button2";
            button2.Size = new Size(31, 23);
            button2.TabIndex = 9;
            button2.Text = "◀";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1108, 12);
            button3.Name = "button3";
            button3.Size = new Size(31, 23);
            button3.TabIndex = 10;
            button3.Text = "▶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // control
            // 
            control.BackColor = Color.Transparent;
            control.BorderStyle = BorderStyle.FixedSingle;
            control.Controls.Add(pictureBox5);
            control.Controls.Add(pictureBox4);
            control.Controls.Add(pictureBox3);
            control.Controls.Add(pictureBox6);
            control.Controls.Add(button1);
            control.Location = new Point(126, 356);
            control.Name = "control";
            control.Size = new Size(887, 139);
            control.TabIndex = 11;
            // 
            // icon
            // 
            icon.BackColor = Color.Transparent;
            icon.Location = new Point(126, 87);
            icon.Name = "icon";
            icon.Size = new Size(278, 241);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 12;
            icon.TabStop = false;
            icon.Click += pictureBox7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(title);
            panel1.Location = new Point(442, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 99);
            panel1.TabIndex = 13;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("メイリオ", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            title.Location = new Point(27, 25);
            title.Name = "title";
            title.Size = new Size(172, 55);
            title.TabIndex = 0;
            title.Text = "タイトル";
            // 
            // splash_img
            // 
            splash_img.Image = Properties.Resources.splash_2;
            splash_img.Location = new Point(0, -9);
            splash_img.Name = "splash_img";
            splash_img.Size = new Size(10, 17);
            splash_img.TabIndex = 14;
            splash_img.TabStop = false;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox8
            // 
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = Properties.Resources.pen;
            pictureBox8.Location = new Point(819, 13);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // messagebox
            // 
            messagebox.AutoScroll = true;
            messagebox.BackgroundImage = Properties.Resources.kei;
            messagebox.BackgroundImageLayout = ImageLayout.Stretch;
            messagebox.Controls.Add(panel3);
            messagebox.Location = new Point(1063, 464);
            messagebox.Name = "messagebox";
            messagebox.Size = new Size(734, 419);
            messagebox.TabIndex = 16;
            messagebox.Visible = false;
            messagebox.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(guna2HtmlLabel2);
            panel3.Controls.Add(guna2HtmlLabel1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(pictureBox9);
            panel3.Location = new Point(39, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(667, 364);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 265);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "壁紙";
            // 
            // pictureBox12
            // 
            pictureBox12.Cursor = Cursors.Hand;
            pictureBox12.Image = Properties.Resources.obu_3;
            pictureBox12.ImageLocation = "";
            pictureBox12.InitialImage = Properties.Resources.kei1;
            pictureBox12.Location = new Point(261, 296);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(204, 95);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 6;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Cursor = Cursors.Hand;
            pictureBox11.Image = Properties.Resources.umaidango_15_4_;
            pictureBox11.ImageLocation = "";
            pictureBox11.InitialImage = Properties.Resources.kei1;
            pictureBox11.Location = new Point(34, 296);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(204, 95);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(3, -11);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(3, 2);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = null;
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(26, 284);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "再生ボタンの色";
            // 
            // pictureBox10
            // 
            pictureBox10.Cursor = Cursors.Hand;
            pictureBox10.Image = Properties.Resources._02_c;
            pictureBox10.Location = new Point(21, 155);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(376, 58);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = Properties.Resources.スクリーンショット_2024_09_19_185055;
            pictureBox9.Location = new Point(21, 52);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(376, 58);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // close_kasutamu
            // 
            close_kasutamu.Image = Properties.Resources.close_button;
            close_kasutamu.Location = new Point(1148, 67);
            close_kasutamu.Name = "close_kasutamu";
            close_kasutamu.Size = new Size(52, 50);
            close_kasutamu.SizeMode = PictureBoxSizeMode.StretchImage;
            close_kasutamu.TabIndex = 0;
            close_kasutamu.TabStop = false;
            close_kasutamu.Click += close_kasutamu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 70);
            panel2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(334, 25);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 0;
            label3.Text = "About\r\n";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1151, 535);
            Controls.Add(close_kasutamu);
            Controls.Add(messagebox);
            Controls.Add(splash_img);
            Controls.Add(pictureBox8);
            Controls.Add(panel1);
            Controls.Add(icon);
            Controls.Add(control);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Original Audio Player";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splash_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            messagebox.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_kasutamu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TrackBar trackBar1;
        private Button button2;
        private Button button3;
        private Panel control;
        private PictureBox icon;
        private Panel panel1;
        private Label title;
        private PictureBox splash_img;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox8;
        private Panel messagebox;
        private PictureBox close_kasutamu;
        private Panel panel3;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private Panel panel2;
        private Label label2;
        private Label label3;
    }
}
