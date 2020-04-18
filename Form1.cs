using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace ModemSignalParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///api/device/signal

            WebClient wc = new WebClient();
            webBrowser1.Navigate( @"http://192.168.8.1/api/device/signal");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"http://192.168.8.1");

        }
    }
}
