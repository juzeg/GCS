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
    public partial class systemcheck2 : Form
    {
        public systemcheck2()
        {
            InitializeComponent();
        }

        private void Scientist_CheckedChanged(object sender, EventArgs e)
        {
            if (Scientist.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void Programmer_CheckedChanged(object sender, EventArgs e)
        {
            if (Programmer.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void Engeneer_CheckedChanged(object sender, EventArgs e)
        {
            if (Engeneer.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void database_CheckedChanged(object sender, EventArgs e)
        {
            if (database.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void power1_CheckedChanged(object sender, EventArgs e)
        {
            if (power1.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void power3_CheckedChanged(object sender, EventArgs e)
        {
            if (power3.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void power2_CheckedChanged(object sender, EventArgs e)
        {
            if (power2.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void power4_CheckedChanged(object sender, EventArgs e)
        {
            if (power4.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void temperature_CheckedChanged(object sender, EventArgs e)
        {
            if (temperature.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void pressure_CheckedChanged(object sender, EventArgs e)
        {
            if (pressure.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void camera_CheckedChanged(object sender, EventArgs e)
        {
            if (camera.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void gps_CheckedChanged(object sender, EventArgs e)
        {
            if (gps.Checked == true) progress.Value += 6;
            else progress.Value -= 6;
        }

        private void satellite_CheckedChanged(object sender, EventArgs e)
        {
            if (satellite.Checked == true) progress.Value += 7;
            else progress.Value -= 7;
        }

        private void ground_CheckedChanged(object sender, EventArgs e)
        {
            if (ground.Checked == true) progress.Value += 7;
            else progress.Value -= 7;
        }

        private void reserve_CheckedChanged(object sender, EventArgs e)
        {
            if (reserve.Checked == true) progress.Value += 7;
            else progress.Value -= 7;
        }

        private void comunication4_CheckedChanged(object sender, EventArgs e)
        {
            if (comunication4.Checked == true) progress.Value += 7;
            else progress.Value -= 7;
        }
    }
}
