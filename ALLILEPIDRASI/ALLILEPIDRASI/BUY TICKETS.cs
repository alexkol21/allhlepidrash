using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALLILEPIDRASI
{
    public partial class BUY_TICKETS : Form
    {
        public BUY_TICKETS()
        {
            InitializeComponent();
            textBox1.Hide();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η ΠΛΗΡΩΜΗ ΠΡΑΓΜΑΤΟΠΟΙΗΘΗΚΕ ΜΕ ΕΠΙΤΥΧΙΑ!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1 .Visible = checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
