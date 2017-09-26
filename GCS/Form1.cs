using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCS
{
    public partial class GCS : Form
    {
        public GCS()
        {
            InitializeComponent();
        }

      public   NewMission NM;
      public   DataDisplay DD;

        private void dataDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DD == null)
            {
                DD = new DataDisplay();
                DD.FormClosed += new FormClosedEventHandler(DD_FormClosed);
                DD.Show();

            }
            else DD.Activate();

        }

        void DD_FormClosed(object sender, FormClosedEventArgs e)
        {


            DD = null;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NM == null)
            {
                NM = new NewMission();
                NM.FormClosed += new FormClosedEventHandler(NM_FormClosed);
                NM.Show();

            }
            else NM.Activate();
            
        }
        void NM_FormClosed(object seender, FormClosedEventArgs e)
        {
            NM = null;

        }
    }
}
