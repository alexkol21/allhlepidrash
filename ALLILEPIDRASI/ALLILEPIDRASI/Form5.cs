using ALLILEPIDRASI.Properties;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "E:\\programming\\allhlepi\\ALLILEPIDRASI\\ALLILEPIDRASI\\Resources\\iron maiden.mp4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
