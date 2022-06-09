using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //btn.Enabled = false;
            btn.Text = "Click";

            lblStatus.Text += "+";
            tbStatus.Text += "+";

            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
                elapspedTime = 0;
            }
            else
            {
                timer1.Enabled = false;
                lblStatus.Text = "";
                tbStatus.Text = "";
                toolStripProgressBar1.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapspedTime++;
            lblStatus.Text = elapspedTime + "초 경과";
            tbStatus.Text = elapspedTime + "초 경과";
            toolStripProgressBar1.Value = elapspedTime;
        }

        private int elapspedTime = 0;
    }
}
