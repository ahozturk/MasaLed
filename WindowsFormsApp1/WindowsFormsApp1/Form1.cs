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
        public Form1()
        {
            InitializeComponent();
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
    }
}
