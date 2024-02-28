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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            checkBox8.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            
            
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = checkBox1.Checked;
            checkBox3.Visible = checkBox1.Checked;
            checkBox4.Visible = checkBox1.Checked;
            richTextBox1.Text = checkBox1.Text + "  " + "3.70" + Environment.NewLine;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Visible = checkBox5.Checked;
            checkBox7.Visible = checkBox5.Checked;
            checkBox8.Visible = checkBox5.Checked;
            bool cap = true;
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
                
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chartreuse;
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
        }
    }
}
