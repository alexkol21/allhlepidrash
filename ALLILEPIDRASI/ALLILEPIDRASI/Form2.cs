using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLILEPIDRASI
{
    public partial class Form2 : Form
    {
        SoundPlayer Guitar = new SoundPlayer(soundLocation: @"E:\programming\allhlepi\ALLILEPIDRASI\ALLILEPIDRASI\Resources\guitar.wav");
        SoundPlayer Trumpet = new SoundPlayer(soundLocation: @"E:\programming\allhlepi\ALLILEPIDRASI\ALLILEPIDRASI\Resources\trumpet.wav");

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guitar.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trumpet.Play();
        }
    }
}
