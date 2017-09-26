using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace GCS
{
    public partial class GCS : Form
    {
        public DataDisplay DD;
        public LoadMission LM;
        public NewMission NM;



        public GCS()
        {
            InitializeComponent();
        }

        private void dataDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DD == null)
            {
                DD = new DataDisplay();
                DD.FormClosed += DD_FormClosed;
                DD.Show();
            }
            else
            {
                DD.Activate();
            }
        }

        private void DD_FormClosed(object sender, FormClosedEventArgs e)
        {
            DD = null;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NM == null)
            {
                NM = new NewMission();
                NM.FormClosed += NM_FormClosed;
                NM.Show();
            }
            else
            {
                NM.Activate();
            }
        }

        private void NM_FormClosed(object seender, FormClosedEventArgs e)
        {
            NM = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Text += serialPort1.ReadLine();
            textBox1.Text += "\n";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void SendCommand_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.WriteLine(textBox2.Text);
            else
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    serialPort1.WriteLine(textBox2.Text);
                }
                catch
                {
                    textBox1.Text += "connection cannont be estabilished \n";
                }
            textBox2.Text = null;
        }
    }
}