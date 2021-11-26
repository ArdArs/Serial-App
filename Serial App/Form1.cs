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

namespace Serial_App
{
    public partial class Form1 : Form
    {
        private SerialPort serial;
        private string speed = "115200";
        private string port;
        private string[] nlValues = {"\n", "\r", "\n\r", ";"};
        private string inputNl = "\n";
        private const Int32 timeout = 50;
        private Timer tmrserialinput = new Timer();
        private string lastString;
        public Form1()
        {
            InitializeComponent();
            tmrserialinput.Interval = timeout;
            tmrserialinput.Start();
            tmrserialinput.Tick += new System.EventHandler(tickerSerial);
        }
        private void tickerSerial(object sender, EventArgs e)
        {
            if (serial != null && serial.IsOpen && serial.BytesToRead > 0)
            {
                lastString = serial.ReadLine();
                lastInputStr.Text = lastString;
            }
        }
        private void indexChanged(object sender, EventArgs e)
        {
            //Port changed
            port = ComLs.SelectedItem.ToString();
        }

        private void refreshButt_Click(object sender, EventArgs e)
        {
            ComLs.Items.Clear();
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++) {
                ComLs.Items.Add(SerialPort.GetPortNames()[i]);
            }
            
        }

        private void baudrateChanged(object sender, EventArgs e)
        {
            speed = speedLs.SelectedItem.ToString();
        }

        private void exitButtClick(object sender, EventArgs e)
        {
            if (serial != null)
                serial.Close();
            Form1.ActiveForm.Close();
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialConnect.Text == "Connect")
                {
                    if (serial == null)
                        serial = new SerialPort(port, int.Parse(speed));
                    serial.Open();
                    serialConnect.Text = "Disconnect";
                }
                else if (serialConnect.Text == "Disconnect")
                {
                    serial.Close();
                    serialConnect.Text = "Connect";
                }


            }
            catch(Exception ex) {
                Console.WriteLine(ex);
                MessageBox.Show("Error connecting", "Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshButt_Click(null, null);
            nwLineVal.SelectedItem = '\n';
            nwLineVal.SelectedIndex = 0;
        }

        private void sendbuttonClick(object sender, EventArgs e)
        {
            if (serial != null && textLine.Text != "")
            {
                serial.Write(textLine.Text);
                if (checkBox1.Enabled)
                    serial.Write("\n");
                if (checkBox1.Enabled)
                    serial.Write("\r");
                textLine.Text = "";
            }
            else if (serial == null)
            {
                MessageBox.Show("Connect to Serial port!", "Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textLine.Text == "")
            {
                MessageBox.Show("Ener the text to text line", "Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void changeNL_Click(object sender, EventArgs e)
        {
            if (serial != null)
            {
                if (textBox1.Text != "")
                    serial.NewLine = textBox1.Text;
                else if (textBox1.Text == "")
                {
                    serial.NewLine = nwLineVal.SelectedText;
                }
            }
            else
            {
                MessageBox.Show("Open serial port!", "Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
