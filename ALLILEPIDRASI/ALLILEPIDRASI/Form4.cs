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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUY_TICKETS buy_tickets = new BUY_TICKETS();
            buy_tickets.ShowDialog();
        }
    }
}
