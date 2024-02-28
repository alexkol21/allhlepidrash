using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLILEPIDRASI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            richTextBox1.Hide();
            richTextBox2.Hide();
            richTextBox3.Hide();
            this.WindowState = FormWindowState.Maximized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Visible = checkBox3.Checked;
        }
    }
}
