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
    public partial class FinishedFormTrack : Form
    {
        public FinishedFormTrack()
        {
            InitializeComponent();
        }

        private void FinishedForm_Load(object sender, EventArgs e)
        {
            txtResult.Text = "عملیات کاشت بذر" + " " + Program.seed + " " + "توسط کشاورز" + " " + Program.Name + " " + "با استفاده از ابزار" + " " + Program.tools + " " + "و با کمک تراکتوربا قدرت" + " " + Program.Power + " " + "و وزن"+" "+Program.weight + " " + "انجام شد.";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
