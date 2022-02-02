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
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.seed = txtSeed.Text;
            Program.tools = txtTools.Text;
            MessageBox.Show("بذر و ابزار اضافه شدند");
            this.Close();
            DialogResult dr = MessageBox.Show("آیا میخواهید از تراکتور استفاده کنید؟", "پیام سیستم",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                new TracktorFrom().ShowDialog();
            }
            else if (dr == DialogResult.No)
            {
                new FinishedFormORD().ShowDialog();
            }
        }
    }
}
