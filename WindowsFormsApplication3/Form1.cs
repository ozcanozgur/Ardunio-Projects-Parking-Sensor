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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        delegate void SetTextDelegate(string value);
        

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Form1 load", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            serialPort1 = new SerialPort();
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }


        

       
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (BackBar.Visible == true)
                BackBar.Visible = false;
            else if (BackBar.Visible == false)
                BackBar.Visible = true;
            else
                BackBar.Visible = false;


        }

        
        private void buttonConnect_Click(object sender, EventArgs e)
        {

            /*serialPort1.PortName = "COM7";
            serialPort1.Open();
            if (!serialPort1.IsOpen) return;
            buttonConnect.Enabled = false;
            */

            try
            {
                serialPort1.PortName = "COM7";
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error opening the serial port!");
            }

        }

       

        private void buttonDis_Click(object sender, EventArgs e)
        {
            /*if (serialPort1.IsOpen)
                serialPort1.Close();
            buttonConnect.Enabled = true;
            */
            if (serialPort1.IsOpen)
                serialPort1.Close();
            MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        
        public void SetText(string value)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(SetText), value);
                }
                catch { }
            else
            {
                string[] input;
                input = value.Split(' ');
                int distanceB;
                int distanceF;
                if (input.Length > 1)
                {
                    
                    distanceF = int.Parse(input[0]);
                    distanceB = int.Parse(input[1]);
                    BackBar.Text = distanceB.ToString();
                    if (distanceB >= 50)
                    {
                        pictureBox2.Width = 107;
                        pictureBox2.Height = 284;
                        pictureBox2.Location = new Point(604, 125);
                        pictureBox2.Image = Image.FromFile("../../parantezSagMavi.png");
                        BackBar.Value = 180;
                    }
                    else if (distanceB < 50 && distanceB >= 40)
                    {
                        pictureBox2.Width = 107;
                        pictureBox2.Height = 275;
                        pictureBox2.Location = new Point(584, 129);
                        pictureBox2.Image = Image.FromFile("../../parantezSag.png");
                        BackBar.ProgressColor = Color.LimeGreen;
                        BackBar.ForeColor = Color.LimeGreen;
                        BackBar.Value = 180 - (50-distanceB)*3;
                    }
                    else if (distanceB < 40 && distanceB >= 30)
                    {
                        pictureBox2.Width = 87;
                        pictureBox2.Height = 245;
                        pictureBox2.Location = new Point(568, 145);
                        pictureBox2.Image = Image.FromFile("../../parantezSagSari.png");
                        BackBar.ProgressColor = Color.Yellow;
                        BackBar.ForeColor = Color.Yellow;
                        BackBar.Value = 180 - (50 - distanceB) *3;
                    }
                    else if (distanceB < 30 && distanceB >= 20)
                    {
                        pictureBox2.Width = 72;
                        pictureBox2.Height = 209;
                        pictureBox2.Location = new Point(568, 165);
                        pictureBox2.Image = Image.FromFile("../../parantezSagSari.png");
                        BackBar.ProgressColor = Color.Orange;
                        BackBar.ForeColor = Color.Orange;
                        BackBar.Value = 180 - (50 - distanceB) * 3;
                    }
                    else if (distanceB < 20 && distanceB >= 10)
                    {
                        pictureBox2.Width = 62;
                        pictureBox2.Height = 200;
                        pictureBox2.Location = new Point(568, 169);
                        pictureBox2.Image = Image.FromFile("../../parantezSagT.png");
                        BackBar.ProgressColor = Color.DarkOrange;
                        BackBar.ForeColor = Color.DarkOrange;
                        BackBar.Value = 180 - (50 - distanceB) * 4;
                    }
                    else if (distanceB < 10 && distanceB >= 4)
                    {
                        pictureBox2.Width = 52;
                        pictureBox2.Height = 176;
                        pictureBox2.Location = new Point(560, 181);
                        pictureBox2.Image = Image.FromFile("../../parantezSagK.png");
                        BackBar.ProgressColor = Color.Red;
                        BackBar.ForeColor = Color.Red;
                        BackBar.Value = 200 - (50 - distanceB) * 4;
                    }

                    if (distanceF >= 50)
                    {
                        pictureBox1.Width = 107;
                        pictureBox1.Height = 281;
                        pictureBox1.Location = new Point(107, 129);
                        pictureBox1.Image = Image.FromFile("../../parantezSolMavi.png");
                    }
                    else if (distanceF < 50 && distanceF >= 40)
                    {
                        pictureBox1.Width = 107;
                        pictureBox1.Height = 266;
                        pictureBox1.Location = new Point(112, 137);
                        pictureBox1.Image = Image.FromFile("../../parantezSol.png");
                    }
                    else if (distanceF < 40 && distanceF >= 30)
                    {
                        pictureBox1.Width = 77;
                        pictureBox1.Height = 224;
                        pictureBox1.Location = new Point(144, 161);
                        pictureBox1.Image = Image.FromFile("../../parantezSolSari.png");
                    }
                    else if (distanceF < 30 && distanceF >= 20)
                    {
                        pictureBox1.Width = 62;
                        pictureBox1.Height = 209;
                        pictureBox1.Location = new Point(164, 169);
                        pictureBox1.Image = Image.FromFile("../../parantezSolSari.png");
                    }
                    else if (distanceF < 20 && distanceF >= 10)
                    {
                        pictureBox1.Width = 52;
                        pictureBox1.Height = 200;
                        pictureBox1.Location = new Point(176, 173);
                        pictureBox1.Image = Image.FromFile("../../parantezSolT.png");
                    }
                    else if (distanceF < 10 && distanceF >= 4)
                    {
                        pictureBox1.Width = 52;
                        pictureBox1.Height = 167;
                        pictureBox1.Location = new Point(184, 189);
                        pictureBox1.Image = Image.FromFile("../../parantezSolK.png");
                    }
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = serialPort1.ReadLine();
            SetText(indata);
        }
    }
}
