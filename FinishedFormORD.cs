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
    public partial class FinishedFormORD : Form
    {
        public FinishedFormORD()
        {
            InitializeComponent();
        }

        private void FinishedFormORD_Load(object sender, EventArgs e)
        {
            txtResult.Text = "عملیات کاشت بذر" + " " + Program.seed + " " + "توسط کشاورز" + " " + Program.Name + " " + "با استفاده از ابزار" + " " + Program.tools + " " + "انجام شد.";

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
