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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnInitialFarmer_Click(object sender, EventArgs e)
        {
            Program.Name = "امین احمدی";
            Program.Age = "32";
            new ToolsForm().ShowDialog();
        }

        private void btnNewFarmer_Click(object sender, EventArgs e)
        {
            new NewFarmerForm().ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
