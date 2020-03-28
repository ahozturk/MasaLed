using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int sesSeviyesi = 0;

        public Form1()
        {
            InitializeComponent();
            NAudio.CoreAudioApi.MMDeviceEnumerator en = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 2;
        }
        string[] ports = SerialPort.GetPortNames();

        int model = 0;
        float parlaklik = 2.5f;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text != "")
            {
                serialPort1.PortName = comboBox2.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                Pnl_Baglan.Visible = false;
                timer1.Enabled = true;
                panel2.Visible = true;
            }
        }

        private void Btn_reconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Pnl_Baglan.Visible = true;
        }

        

        void Yazdir(int r, float ra, int g, float ga, int b, float ba)
        {
            serialPort1.WriteLine("cr" + r * ra + "g" + g * ga + "b" + b * ba);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && serialPort1.IsOpen)
            {
                if (model == 0) 
                {
                    Yazdir(0, 0, 0, 0, 0, 0);
                }
                else if(model == 1)
                {
                    var singleDevice = (NAudio.CoreAudioApi.MMDevice)comboBox1.SelectedItem;
                    progressBar1.Value = (int)(singleDevice.AudioMeterInformation.MasterPeakValue * 100);
                    sesSeviyesi = ((int)(singleDevice.AudioMeterInformation.MasterPeakValue * 100));

                    if (sesSeviyesi == 0)
                    {
                        Yazdir(0, 0, 0, 0, 0, 0);
                    }
                    else if (sesSeviyesi < (50 + ((trackBar1.Value - 5) * 5)))
                    {
                        Yazdir(sesSeviyesi, 2.5f, 0, 0, 0, 0);
                    }
                    else if (sesSeviyesi < (75 + ((trackBar1.Value - 5) * 5)))
                    {
                        Yazdir(sesSeviyesi, 2.5f, sesSeviyesi, 1f, 0, 0);
                    }
                    else if (sesSeviyesi <= (100 + ((trackBar1.Value - 5) * 5)))
                    {
                        Yazdir(sesSeviyesi, 2.5f, sesSeviyesi, 2.5f, sesSeviyesi, 2.5f);
                    }
                }
                else if(model == 2)
                {
                    Yazdir(100, parlaklik, 0, 0, 0, 0);
                    timer1.Enabled = false;
                }
                else if (model == 3)
                {
                    Yazdir(0, 0, 100, parlaklik, 0, 0);
                    timer1.Enabled = false;
                }
                else if (model == 4)
                {
                    Yazdir(0, 0, 0, 0, 100, parlaklik);
                    timer1.Enabled = false;
                }
                else if (model == 5)
                {
                    Yazdir(100, parlaklik, 50, parlaklik, 0, 0);
                    timer1.Enabled = false;
                }
                else if (model == 6)
                {
                    Yazdir(0, 0, 100, parlaklik, 100, parlaklik);
                    timer1.Enabled = false;
                }
                else if (model == 7)
                {
                    Yazdir(70, parlaklik, 0, 0, 100, parlaklik);
                    timer1.Enabled = false;
                }
                else if (model == 8)
                {
                    Yazdir(100, parlaklik, 0, 0, 50, parlaklik);
                    timer1.Enabled = false;
                }
                else if (model == 9)
                {
                    Yazdir(100, parlaklik, 100, parlaklik, 100, parlaklik);
                    timer1.Enabled = false;
                }
            }
        }

        private void Btn_Yukselt_Click(object sender, EventArgs e)
        {
            if(parlaklik <= 2)
            {
                parlaklik += 0.5f;
                timer1.Enabled = true;
            }
        }

        private void Btn_Azalt_Click(object sender, EventArgs e)
        {
            if(parlaklik >= 1)
            {
                parlaklik -= 0.5f;
                timer1.Enabled = true;
            }
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
            model = 2;
            timer1.Enabled = true;
        }

        private void Btn_green_Click(object sender, EventArgs e)
        {
            model = 3;
            timer1.Enabled = true;
        }

        private void Btn_blue_Click(object sender, EventArgs e)
        {
            model = 4;
            timer1.Enabled = true;
        }

        private void Btn_music_Click(object sender, EventArgs e)
        {
            model = 1;
            timer1.Enabled = true;
        }

        private void Btn_yellow_Click(object sender, EventArgs e)
        {
            model = 5;
            timer1.Enabled = true;
        }

        private void Btn_kapat_Click(object sender, EventArgs e)
        {
            model = 0;
            timer1.Enabled = true;
        }

        private void Btn_turquoise_Click(object sender, EventArgs e)
        {
            model = 6;
            timer1.Enabled = true;
        }

        private void Btn_purple_Click(object sender, EventArgs e)
        {
            model = 7;
            timer1.Enabled = true;
        }

        private void Btn_pink_Click(object sender, EventArgs e)
        {
            model = 8;
            timer1.Enabled = true;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Yazdir(Convert.ToInt32(numericUpDown1.Value), 2.5f, Convert.ToInt32(numericUpDown2.Value), 2.5f, Convert.ToInt32(numericUpDown3.Value), 2.5f);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Yazdir(Convert.ToInt32(numericUpDown1.Value), 2.5f, Convert.ToInt32(numericUpDown2.Value), 2.5f, Convert.ToInt32(numericUpDown3.Value), 2.5f);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Yazdir(Convert.ToInt32(numericUpDown1.Value), 2.5f, Convert.ToInt32(numericUpDown2.Value), 2.5f, Convert.ToInt32(numericUpDown3.Value), 2.5f);
        }

        private void Btn_white_Click(object sender, EventArgs e)
        {
            model = 9;
            timer1.Enabled = true;
        }
    }
}