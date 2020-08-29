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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pnl_Baglan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(3, 59);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(90, 27);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.TabStop = false;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            this.Btn_Connect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.TabStop = false;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_reconnect
            // 
            this.Btn_reconnect.Location = new System.Drawing.Point(27, 12);
            this.Btn_reconnect.Name = "Btn_reconnect";
            this.Btn_reconnect.Size = new System.Drawing.Size(72, 20);
            this.Btn_reconnect.TabIndex = 3;
            this.Btn_reconnect.TabStop = false;
            this.Btn_reconnect.Text = "Reconnect";
            this.Btn_reconnect.UseVisualStyleBackColor = true;
            this.Btn_reconnect.Click += new System.EventHandler(this.Btn_reconnect_Click);
            this.Btn_reconnect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Pnl_Baglan
            // 
            this.Pnl_Baglan.Controls.Add(this.comboBox1);
            this.Pnl_Baglan.Controls.Add(this.Btn_Connect);
            this.Pnl_Baglan.Controls.Add(this.comboBox2);
            this.Pnl_Baglan.Location = new System.Drawing.Point(27, 38);
            this.Pnl_Baglan.Name = "Pnl_Baglan";
            this.Pnl_Baglan.Size = new System.Drawing.Size(106, 92);
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
            this.Btn_red.TabStop = false;
            this.Btn_red.UseVisualStyleBackColor = false;
            this.Btn_red.Click += new System.EventHandler(this.Btn_red_Click);
            this.Btn_red.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
            this.panel1.Location = new System.Drawing.Point(262, 15);
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
            this.Btn_pink.TabStop = false;
            this.Btn_pink.UseVisualStyleBackColor = false;
            this.Btn_pink.Click += new System.EventHandler(this.Btn_pink_Click);
            this.Btn_pink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_white
            // 
            this.Btn_white.BackColor = System.Drawing.Color.White;
            this.Btn_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_white.Location = new System.Drawing.Point(130, 224);
            this.Btn_white.Name = "Btn_white";
            this.Btn_white.Size = new System.Drawing.Size(95, 90);
            this.Btn_white.TabIndex = 11;
            this.Btn_white.TabStop = false;
            this.Btn_white.UseVisualStyleBackColor = false;
            this.Btn_white.Click += new System.EventHandler(this.Btn_white_Click);
            this.Btn_white.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_purple
            // 
            this.Btn_purple.BackColor = System.Drawing.Color.BlueViolet;
            this.Btn_purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_purple.Location = new System.Drawing.Point(248, 117);
            this.Btn_purple.Name = "Btn_purple";
            this.Btn_purple.Size = new System.Drawing.Size(95, 90);
            this.Btn_purple.TabIndex = 10;
            this.Btn_purple.TabStop = false;
            this.Btn_purple.UseVisualStyleBackColor = false;
            this.Btn_purple.Click += new System.EventHandler(this.Btn_purple_Click);
            this.Btn_purple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_turquoise
            // 
            this.Btn_turquoise.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_turquoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_turquoise.Location = new System.Drawing.Point(130, 117);
            this.Btn_turquoise.Name = "Btn_turquoise";
            this.Btn_turquoise.Size = new System.Drawing.Size(95, 90);
            this.Btn_turquoise.TabIndex = 9;
            this.Btn_turquoise.TabStop = false;
            this.Btn_turquoise.UseVisualStyleBackColor = false;
            this.Btn_turquoise.Click += new System.EventHandler(this.Btn_turquoise_Click);
            this.Btn_turquoise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_yellow
            // 
            this.Btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.Btn_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_yellow.Location = new System.Drawing.Point(12, 117);
            this.Btn_yellow.Name = "Btn_yellow";
            this.Btn_yellow.Size = new System.Drawing.Size(95, 90);
            this.Btn_yellow.TabIndex = 8;
            this.Btn_yellow.TabStop = false;
            this.Btn_yellow.UseVisualStyleBackColor = false;
            this.Btn_yellow.Click += new System.EventHandler(this.Btn_yellow_Click);
            this.Btn_yellow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_blue
            // 
            this.Btn_blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_blue.Location = new System.Drawing.Point(248, 10);
            this.Btn_blue.Name = "Btn_blue";
            this.Btn_blue.Size = new System.Drawing.Size(95, 90);
            this.Btn_blue.TabIndex = 7;
            this.Btn_blue.TabStop = false;
            this.Btn_blue.UseVisualStyleBackColor = false;
            this.Btn_blue.Click += new System.EventHandler(this.Btn_blue_Click);
            this.Btn_blue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_green
            // 
            this.Btn_green.BackColor = System.Drawing.Color.Lime;
            this.Btn_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_green.Location = new System.Drawing.Point(130, 10);
            this.Btn_green.Name = "Btn_green";
            this.Btn_green.Size = new System.Drawing.Size(95, 90);
            this.Btn_green.TabIndex = 6;
            this.Btn_green.TabStop = false;
            this.Btn_green.UseVisualStyleBackColor = false;
            this.Btn_green.Click += new System.EventHandler(this.Btn_green_Click);
            this.Btn_green.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_kapat
            // 
            this.Btn_kapat.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_kapat.BackgroundImage")));
            this.Btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_kapat.Location = new System.Drawing.Point(127, 249);
            this.Btn_kapat.Name = "Btn_kapat";
            this.Btn_kapat.Size = new System.Drawing.Size(95, 90);
            this.Btn_kapat.TabIndex = 16;
            this.Btn_kapat.TabStop = false;
            this.Btn_kapat.UseVisualStyleBackColor = false;
            this.Btn_kapat.Click += new System.EventHandler(this.Btn_kapat_Click);
            this.Btn_kapat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_Azalt
            // 
            this.Btn_Azalt.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_Azalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Azalt.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Azalt.Image")));
            this.Btn_Azalt.Location = new System.Drawing.Point(127, 132);
            this.Btn_Azalt.Name = "Btn_Azalt";
            this.Btn_Azalt.Size = new System.Drawing.Size(95, 90);
            this.Btn_Azalt.TabIndex = 15;
            this.Btn_Azalt.TabStop = false;
            this.Btn_Azalt.UseVisualStyleBackColor = false;
            this.Btn_Azalt.Click += new System.EventHandler(this.Btn_Azalt_Click);
            this.Btn_Azalt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_Yukselt
            // 
            this.Btn_Yukselt.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_Yukselt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Yukselt.BackgroundImage")));
            this.Btn_Yukselt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Yukselt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Yukselt.Location = new System.Drawing.Point(127, 15);
            this.Btn_Yukselt.Name = "Btn_Yukselt";
            this.Btn_Yukselt.Size = new System.Drawing.Size(95, 90);
            this.Btn_Yukselt.TabIndex = 14;
            this.Btn_Yukselt.TabStop = false;
            this.Btn_Yukselt.UseVisualStyleBackColor = false;
            this.Btn_Yukselt.Click += new System.EventHandler(this.Btn_Yukselt_Click);
            this.Btn_Yukselt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(30, 328);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TabStop = false;
            this.trackBar1.Value = 5;
            this.trackBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Btn_music
            // 
            this.Btn_music.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_music.BackgroundImage")));
            this.Btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_music.FlatAppearance.BorderSize = 0;
            this.Btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_music.Location = new System.Drawing.Point(14, 15);
            this.Btn_music.Name = "Btn_music";
            this.Btn_music.Size = new System.Drawing.Size(95, 90);
            this.Btn_music.TabIndex = 18;
            this.Btn_music.TabStop = false;
            this.Btn_music.UseVisualStyleBackColor = false;
            this.Btn_music.Click += new System.EventHandler(this.Btn_music_Click);
            this.Btn_music.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.Btn_Yukselt);
            this.panel2.Controls.Add(this.Btn_music);
            this.panel2.Controls.Add(this.Btn_Azalt);
            this.panel2.Controls.Add(this.Btn_kapat);
            this.panel2.Location = new System.Drawing.Point(530, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 370);
            this.panel2.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Ver Ayarı";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.White;
            this.numericUpDown3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(37, 314);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown3.TabIndex = 23;
            this.numericUpDown3.TabStop = false;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.numericUpDown3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Lime;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(37, 274);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.TabStop = false;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Red;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(37, 234);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.White;
            this.numericUpDown4.Location = new System.Drawing.Point(16, 91);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown4.TabIndex = 26;
            this.numericUpDown4.TabStop = false;
            this.numericUpDown4.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.Color.Lime;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown5.Location = new System.Drawing.Point(16, 59);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown5.TabIndex = 25;
            this.numericUpDown5.TabStop = false;
            this.numericUpDown5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.BackColor = System.Drawing.Color.Red;
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown6.ForeColor = System.Drawing.Color.White;
            this.numericUpDown6.Location = new System.Drawing.Point(16, 27);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown6.TabIndex = 24;
            this.numericUpDown6.TabStop = false;
            this.numericUpDown6.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.BackColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown7.ForeColor = System.Drawing.Color.White;
            this.numericUpDown7.Location = new System.Drawing.Point(71, 91);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown7.TabIndex = 29;
            this.numericUpDown7.TabStop = false;
            this.numericUpDown7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.BackColor = System.Drawing.Color.Lime;
            this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown8.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown8.Location = new System.Drawing.Point(71, 59);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown8.TabIndex = 28;
            this.numericUpDown8.TabStop = false;
            this.numericUpDown8.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.BackColor = System.Drawing.Color.Red;
            this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown9.ForeColor = System.Drawing.Color.White;
            this.numericUpDown9.Location = new System.Drawing.Point(71, 27);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown9.TabIndex = 27;
            this.numericUpDown9.TabStop = false;
            this.numericUpDown9.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.BackColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown10.ForeColor = System.Drawing.Color.White;
            this.numericUpDown10.Location = new System.Drawing.Point(126, 91);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown10.TabIndex = 32;
            this.numericUpDown10.TabStop = false;
            this.numericUpDown10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.BackColor = System.Drawing.Color.Lime;
            this.numericUpDown11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown11.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown11.Location = new System.Drawing.Point(126, 59);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown11.TabIndex = 31;
            this.numericUpDown11.TabStop = false;
            this.numericUpDown11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.BackColor = System.Drawing.Color.Red;
            this.numericUpDown12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown12.ForeColor = System.Drawing.Color.White;
            this.numericUpDown12.Location = new System.Drawing.Point(126, 27);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown12.TabIndex = 30;
            this.numericUpDown12.TabStop = false;
            this.numericUpDown12.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "H";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDown6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numericUpDown5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numericUpDown4);
            this.panel3.Controls.Add(this.numericUpDown10);
            this.panel3.Controls.Add(this.numericUpDown9);
            this.panel3.Controls.Add(this.numericUpDown11);
            this.panel3.Controls.Add(this.numericUpDown7);
            this.panel3.Controls.Add(this.numericUpDown12);
            this.panel3.Location = new System.Drawing.Point(320, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 126);
            this.panel3.TabIndex = 36;
            this.panel3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1192, 406);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Pnl_Baglan);
            this.Controls.Add(this.Btn_reconnect);
            this.Name = "Form1";
            this.Text = "Hakan Bey Napıyosunuz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Pnl_Baglan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

