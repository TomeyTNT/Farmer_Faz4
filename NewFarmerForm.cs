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
    public partial class NewFarmerForm : Form
    {
        public NewFarmerForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.Name = txtFName.Text + " " + txtLName.Text;
            Program.Age = txtAge.Text;
            MessageBox.Show("کشاورز جدید ایجاد شد");
            this.Close();
            new ToolsForm().ShowDialog();
        }
    }
}
