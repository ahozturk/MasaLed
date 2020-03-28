namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Btn_reconnect = new System.Windows.Forms.Button();
            this.Pnl_Baglan = new System.Windows.Forms.Panel();
            this.Btn_red = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_pink = new System.Windows.Forms.Button();
            this.Btn_white = new System.Windows.Forms.Button();
            this.Btn_purple = new System.Windows.Forms.Button();
            this.Btn_turquoise = new System.Windows.Forms.Button();
            this.Btn_yellow = new System.Windows.Forms.Button();
            this.Btn_blue = new System.Windows.Forms.Button();
            this.Btn_green = new System.Windows.Forms.Button();
            this.Btn_kapat = new System.Windows.Forms.Button();
            this.Btn_Azalt = new System.Windows.Forms.Button();
            this.Btn_Yukselt = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Btn_music = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Baglan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(3, 59);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(90, 27);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // Btn_reconnect
            // 
            this.Btn_reconnect.Location = new System.Drawing.Point(27, 12);
            this.Btn_reconnect.Name = "Btn_reconnect";
            this.Btn_reconnect.Size = new System.Drawing.Size(72, 20);
            this.Btn_reconnect.TabIndex = 3;
            this.Btn_reconnect.Text = "Reconnect";
            this.Btn_reconnect.UseVisualStyleBackColor = true;
            this.Btn_reconnect.Click += new System.EventHandler(this.Btn_reconnect_Click);
            // 
            // Pnl_Baglan
            // 
            this.Pnl_Baglan.Controls.Add(this.comboBox1);
            this.Pnl_Baglan.Controls.Add(this.Btn_Connect);
            this.Pnl_Baglan.Controls.Add(this.comboBox2);
            this.Pnl_Baglan.Location = new System.Drawing.Point(27, 38);
            this.Pnl_Baglan.Name = "Pnl_Baglan";
            this.Pnl_Baglan.Size = new System.Drawing.Size(127, 92);
            this.Pnl_Baglan.TabIndex = 4;
            // 
            // Btn_red
            // 
            this.Btn_red.BackColor = System.Drawing.Color.Red;
            this.Btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_red.Location = new System.Drawing.Point(12, 10);
            this.Btn_red.Name = "Btn_red";
            this.Btn_red.Size = new System.Drawing.Size(95, 90);
            this.Btn_red.TabIndex = 5;
            this.Btn_red.UseVisualStyleBackColor = false;
            this.Btn_red.Click += new System.EventHandler(this.Btn_red_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.Btn_pink);
            this.panel1.Controls.Add(this.Btn_white);
            this.panel1.Controls.Add(this.Btn_purple);
            this.panel1.Controls.Add(this.Btn_turquoise);
            this.panel1.Controls.Add(this.Btn_yellow);
            this.panel1.Controls.Add(this.Btn_blue);
            this.panel1.Controls.Add(this.Btn_green);
            this.panel1.Controls.Add(this.Btn_red);
            this.panel1.Location = new System.Drawing.Point(810, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 324);
            this.panel1.TabIndex = 6;
            // 
            // Btn_pink
            // 
            this.Btn_pink.BackColor = System.Drawing.Color.Fuchsia;
            this.Btn_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pink.Location = new System.Drawing.Point(248, 224);
            this.Btn_pink.Name = "Btn_pink";
            this.Btn_pink.Size = new System.Drawing.Size(95, 90);
            this.Btn_pink.TabIndex = 13;
            this.Btn_pink.UseVisualStyleBackColor = false;
            // 
            // Btn_white
            // 
            this.Btn_white.BackColor = System.Drawing.Color.White;
            this.Btn_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_white.Location = new System.Drawing.Point(130, 224);
            this.Btn_white.Name = "Btn_white";
            this.Btn_white.Size = new System.Drawing.Size(95, 90);
            this.Btn_white.TabIndex = 11;
            this.Btn_white.UseVisualStyleBackColor = false;
            // 
            // Btn_purple
            // 
            this.Btn_purple.BackColor = System.Drawing.Color.BlueViolet;
            this.Btn_purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_purple.Location = new System.Drawing.Point(248, 117);
            this.Btn_purple.Name = "Btn_purple";
            this.Btn_purple.Size = new System.Drawing.Size(95, 90);
            this.Btn_purple.TabIndex = 10;
            this.Btn_purple.UseVisualStyleBackColor = false;
            // 
            // Btn_turquoise
            // 
            this.Btn_turquoise.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_turquoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_turquoise.Location = new System.Drawing.Point(130, 117);
            this.Btn_turquoise.Name = "Btn_turquoise";
            this.Btn_turquoise.Size = new System.Drawing.Size(95, 90);
            this.Btn_turquoise.TabIndex = 9;
            this.Btn_turquoise.UseVisualStyleBackColor = false;
            // 
            // Btn_yellow
            // 
            this.Btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.Btn_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_yellow.Location = new System.Drawing.Point(12, 117);
            this.Btn_yellow.Name = "Btn_yellow";
            this.Btn_yellow.Size = new System.Drawing.Size(95, 90);
            this.Btn_yellow.TabIndex = 8;
            this.Btn_yellow.UseVisualStyleBackColor = false;
            // 
            // Btn_blue
            // 
            this.Btn_blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_blue.Location = new System.Drawing.Point(248, 10);
            this.Btn_blue.Name = "Btn_blue";
            this.Btn_blue.Size = new System.Drawing.Size(95, 90);
            this.Btn_blue.TabIndex = 7;
            this.Btn_blue.UseVisualStyleBackColor = false;
            // 
            // Btn_green
            // 
            this.Btn_green.BackColor = System.Drawing.Color.Lime;
            this.Btn_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_green.Location = new System.Drawing.Point(130, 10);
            this.Btn_green.Name = "Btn_green";
            this.Btn_green.Size = new System.Drawing.Size(95, 90);
            this.Btn_green.TabIndex = 6;
            this.Btn_green.UseVisualStyleBackColor = false;
            // 
            // Btn_kapat
            // 
            this.Btn_kapat.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_kapat.BackgroundImage")));
            this.Btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_kapat.Location = new System.Drawing.Point(675, 271);
            this.Btn_kapat.Name = "Btn_kapat";
            this.Btn_kapat.Size = new System.Drawing.Size(95, 90);
            this.Btn_kapat.TabIndex = 16;
            this.Btn_kapat.UseVisualStyleBackColor = false;
            // 
            // Btn_Azalt
            // 
            this.Btn_Azalt.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_Azalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Azalt.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Azalt.Image")));
            this.Btn_Azalt.Location = new System.Drawing.Point(675, 159);
            this.Btn_Azalt.Name = "Btn_Azalt";
            this.Btn_Azalt.Size = new System.Drawing.Size(95, 90);
            this.Btn_Azalt.TabIndex = 15;
            this.Btn_Azalt.UseVisualStyleBackColor = false;
            // 
            // Btn_Yukselt
            // 
            this.Btn_Yukselt.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_Yukselt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Yukselt.BackgroundImage")));
            this.Btn_Yukselt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Yukselt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Yukselt.Location = new System.Drawing.Point(675, 47);
            this.Btn_Yukselt.Name = "Btn_Yukselt";
            this.Btn_Yukselt.Size = new System.Drawing.Size(95, 90);
            this.Btn_Yukselt.TabIndex = 14;
            this.Btn_Yukselt.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(30, 328);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 5;
            // 
            // Btn_music
            // 
            this.Btn_music.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_music.BackgroundImage")));
            this.Btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_music.FlatAppearance.BorderSize = 0;
            this.Btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_music.Location = new System.Drawing.Point(549, 47);
            this.Btn_music.Name = "Btn_music";
            this.Btn_music.Size = new System.Drawing.Size(95, 90);
            this.Btn_music.TabIndex = 18;
            this.Btn_music.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1192, 406);
            this.Controls.Add(this.Btn_music);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Btn_kapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Azalt);
            this.Controls.Add(this.Btn_Yukselt);
            this.Controls.Add(this.Pnl_Baglan);
            this.Controls.Add(this.Btn_reconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_Baglan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Btn_reconnect;
        private System.Windows.Forms.Panel Pnl_Baglan;
        private System.Windows.Forms.Button Btn_red;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_pink;
        private System.Windows.Forms.Button Btn_white;
        private System.Windows.Forms.Button Btn_purple;
        private System.Windows.Forms.Button Btn_turquoise;
        private System.Windows.Forms.Button Btn_yellow;
        private System.Windows.Forms.Button Btn_blue;
        private System.Windows.Forms.Button Btn_green;
        private System.Windows.Forms.Button Btn_kapat;
        private System.Windows.Forms.Button Btn_Azalt;
        private System.Windows.Forms.Button Btn_Yukselt;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Btn_music;
        private System.Windows.Forms.Timer timer1;
    }
}

