using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sleep = Int32.Parse(textBox2.Text);
            int loop = Int32.Parse(textBox3.Text);

            Thread.Sleep(sleep);
            for (var i = 0; i < loop; i++)
            {
                SendKeys.Send(textBox1.Text);
            }
        }
    }
}
