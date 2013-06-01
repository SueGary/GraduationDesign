using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEIS_SPZZ.UIL.zhongsuyu
{
    public partial class yuyue : Form
    {
        int mdino;
        int[] mdi;
        int k = 0;
        public yuyue()
        {
            InitializeComponent();
            this.mdino = mdino;
            this.mdi = mdi;
            this.Text = mdino.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void yuyue_FormClosing(object sender, FormClosingEventArgs e)
        {
            mdi[mdino] = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("yyyyMMdd");
            string str = "HK" + data;
            if (k < 10)
            {
                str = str + "00" + k;
            }
            else if (k < 100)
            {
                str = str + "0" + k;
            }
            else
            {
                str = str + k;
            }
            textBox1.Text = str;
            k++;
        }
    }
}
