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
        }
        string[] ports = SerialPort.GetPortNames();

        private void Form1_Load(object sender, EventArgs e)
        {
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
            }
        }

        private void Btn_reconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Pnl_Baglan.Visible = true;
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
        }

        void Yazdir(int r, float ra, int g, float ga, int b, float ba)
        {
            serialPort1.WriteLine("cr" + r * ra + "g" + g * ga + "b" + b * ba);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && serialPort1.IsOpen)
            {
                var singleDevice = (NAudio.CoreAudioApi.MMDevice)comboBox1.SelectedItem;
                progressBar1.Value = (int)(singleDevice.AudioMeterInformation.MasterPeakValue * 100);
                sesSeviyesi = ((int)(singleDevice.AudioMeterInformation.MasterPeakValue * 100));
                label1.Text = sesSeviyesi.ToString();
                
                if(sesSeviyesi == 0)
                {
                    //serialPort1.WriteLine("c");
                    Yazdir(0, 0, 0, 0, 0, 0);
                }
                else if(sesSeviyesi < (50 + ((trackBar1.Value - 5) * 5)))
                {
                    //serialPort1.WriteLine("cr" + sesSeviyesi * 2.5 + "g0b0");
                    Yazdir(sesSeviyesi, 2.5f, 0, 0, 0, 0);
                }
                else if(sesSeviyesi < (75 + ((trackBar1.Value - 5) * 5)))
                {
                    //serialPort1.WriteLine("cr0g" + sesSeviyesi * 2.5 + "b0");
                    Yazdir(sesSeviyesi, 2.5f, sesSeviyesi, 1f, 0, 0);
                }
                else if(sesSeviyesi <= (100 + ((trackBar1.Value - 5) * 5)))
                {
                    //serialPort1.WriteLine("cr0g0b" + sesSeviyesi * 2.5);
                    Yazdir(sesSeviyesi, 2.5f, sesSeviyesi, 2.5f, sesSeviyesi, 2.5f);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }
    }
}