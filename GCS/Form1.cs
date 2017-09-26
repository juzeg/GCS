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

      

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LM == null)
            {
                LM = new LoadMission();
                LM.FormClosed += LM_FormClosed;
                LM.Show();
            }
            else
            {
                LM.Activate();
            }

        }
        private void LM_FormClosed(object seender, FormClosedEventArgs e)
        {
            LM = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}