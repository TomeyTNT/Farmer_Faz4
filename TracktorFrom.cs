using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class TracktorFrom : Form
    {
        public TracktorFrom()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.Power = txtPower.Text + "";
            Program.weight = txtWeight.Text + "";
            Program.Tracktor = "استفاده شده است";
            Program.UseTracktor = true;
            MessageBox.Show("مشخصات تراکتور اضافه شد");
            this.Close();
            new FinishedFormTrack().ShowDialog();
        }
    }
}
